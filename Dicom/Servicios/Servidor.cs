using Dicom.Control;
using Dicom.HL7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Dicom.Servicios
{
    class Servidor
    {
        private readonly string IP = "192.168.43.88";
        private readonly int PUERTO = 52000;
        private readonly int PUERTO_CLIENTE = 53000;
        private readonly int CONEXIONES_MAXIMAS = 10;

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Servidor() { }
        
        /// <summary>
        /// Iniciando servidor
        /// </summary>
        public void Iniciar()
        {
            ThreadStart delegado = new ThreadStart(EscucharPuerto);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        /// <summary>
        /// Este hilo se encarga de escuchar mensajes HL7 
        /// </summary>
        public void EscucharPuerto()
        {
            try
            {
                Consola.Imprimir("Iniciando servidor...");
                Consola.Imprimir("IP: " + IP);
                Consola.Imprimir("Puerto: " + PUERTO);
                Consola.Imprimir("Número de conexiones máximo: " + CONEXIONES_MAXIMAS);

                while (true)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(IP), PUERTO);

                    socket.Bind(direccion);
                    socket.Listen(CONEXIONES_MAXIMAS);

                    Socket escuchar = socket.Accept();

                    byte[] bytes = new byte[32768];

                    int a = escuchar.Receive(bytes, 0, bytes.Length, 0);

                    Array.Resize(ref bytes, a);

                    string mensaje = Encoding.UTF8.GetString(bytes);

                    if (mensaje.Length > 0)
                    {
                        mensaje = mensaje.Substring(2);

                        string clienteIP = escuchar.RemoteEndPoint.ToString();

                        Consola.Imprimir("Mensaje recibido");

                        Thread hilo = new Thread(() => ConvertirMensaje(mensaje, clienteIP));
                        hilo.Start();

                        escuchar.Close();
                        socket.Close();
                    }
                    else
                    {
                        Consola.Imprimir("Ocurrió un problema con el mensaje: " + mensaje);
                    }
                }
            } catch(Exception e)
            {
                Consola.Imprimir("Ocurrió un problema al iniciar el puerto.");
                Consola.Imprimir(e.ToString());
            }
        }

        /// <summary>
        /// Este hilo convierte los mensajes
        /// </summary>
        /// <param name="mensaje">Mensaje a convertir</param>
        /// <param name="clienteIP">IP al que enviar la respuesta</param>
        private void ConvertirMensaje(string mensaje, string clienteIP)
        {
            Consola.Imprimir("Convirtiendo el mensaje...");

            ProcesadorMensaje procesadorMensaje = new ProcesadorMensaje(mensaje);
            procesadorMensaje.Empezar();

            EnviarACK(procesadorMensaje.ObtenerTipoMensajeRespuesta(),procesadorMensaje.ObtenerMSH(), clienteIP);
        }

        /// <summary>
        /// Envia el mensaje de respuesta
        /// </summary>
        /// <param name="tipoACK">Tipo de mensaje ACK</param>
        /// <param name="MSH">Header del mensaje</param>
        /// <param name="clienteIP">IP al que enviar la respuesta</param>
        private void EnviarACK(string tipoACK, Hashtable MSH, string clienteIP)
        {
            string mensaje = MensajeACK.GenerarMensaje(tipoACK,MSH);

            clienteIP = clienteIP.Split(':')[0];

            Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            Match match = regex.Match(clienteIP);
            if (match.Success)
            {
                Cliente cliente = new Cliente(clienteIP,PUERTO_CLIENTE);
                cliente.EnviarMensaje(mensaje);
            }
        }

    }
}
