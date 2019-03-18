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
        private readonly string ip;
        private readonly int puerto;
        private readonly int conexionesMaximas;

        public Servidor(string ip, int puerto, int conexionesMaximas)
        {
            this.ip = ip;
            this.puerto = puerto;
            this.conexionesMaximas = conexionesMaximas;

            ThreadStart delegado = new ThreadStart(EscucharPuerto);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        /*
         * Este hilo se encarga de escuchar mensajes HL7 
         */
        public void EscucharPuerto()
        {
            Consola.Imprimir("Iniciando servidor...");
            Consola.Imprimir("IP: " + ip);
            Consola.Imprimir("Puerto: " + puerto);
            Consola.Imprimir("Número de conexiones máximo: " + conexionesMaximas);

            while (true)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(ip), puerto);

                socket.Bind(direccion);
                socket.Listen(conexionesMaximas);

                Socket escuchar = socket.Accept();

                byte[] bytes = new byte[32768];

                int a = escuchar.Receive(bytes, 0, bytes.Length, 0);

                Array.Resize(ref bytes, a);

                string mensaje = Encoding.UTF8.GetString(bytes);
                mensaje = mensaje.Substring(2);

                string clienteIP = escuchar.RemoteEndPoint.ToString();

                Consola.Imprimir("Mensaje recibido");

                Thread hilo = new Thread(() => ConvertirMensaje(mensaje, clienteIP));
                hilo.Start();

                escuchar.Close();
                socket.Close();
            }
        }

        /*
         * Este hilo se encargar de procesar mensajes
         */
        private void ConvertirMensaje(string mensaje, string clienteIP)
        {
            ProcesadorMensaje procesadorMensaje = new ProcesadorMensaje(mensaje);
            procesadorMensaje.Empezar();

            EnviarACK(procesadorMensaje.ObtenerTipoMensajeRespuesta(),procesadorMensaje.ObtenerMSH(), clienteIP);
        }

        private void EnviarACK(string tipoACK, Hashtable MSH, string clienteIP)
        {
            string mensaje = MensajeACK.GenerarMensaje(tipoACK,MSH);

            clienteIP = clienteIP.Split(':')[0];

            Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            Match match = regex.Match(clienteIP);
            if (match.Success)
            {
                Cliente cliente = new Cliente(clienteIP,puerto);
                cliente.EnviarMensaje(mensaje);
            }
        }

    }
}
