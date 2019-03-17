using Dicom.Control;
using Dicom.HL7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dicom.Servicios
{
    class Servidor
    {

        public Servidor()
        {
            ThreadStart delegado = new ThreadStart(EscucharPuerto);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        /*
         * Este hilo se encarga de escuchar mensajes HL7 
         */
        public void EscucharPuerto()
        {
            string ip = "192.168.0.11";
            int puerto = 52000;
            int conexionesMaximas = 10;

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

                Consola.Imprimir("Mensaje recibido");

                Thread hilo = new Thread(() => ConvertirMensaje(mensaje));
                hilo.Start();

                escuchar.Close();
                socket.Close();
            }
        }

        /*
         * Este hilo se encargar de procesar mensajes
         */
        private void ConvertirMensaje(string mensaje)
        {
            ProcesadorMensaje procesadorMensaje = new ProcesadorMensaje(mensaje);
            procesadorMensaje.Empezar();
        }

    }
}
