using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Servicios
{
    class Cliente
    {
        private readonly string ip;
        private readonly int puerto;

        /// <summary>
        /// Constructor Cliente
        /// </summary>
        /// <param name="ip">IP a la que enviar</param>
        /// <param name="puerto">Puerto</param>
        public Cliente(string ip, int puerto)
        {
            this.ip = ip;
            this.puerto = puerto;
        }

        /// <summary>
        /// Enviar mensaje a través del socket
        /// </summary>
        /// <param name="mensaje">Mensaje a enviar</param>
        public void EnviarMensaje(string mensaje)
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(ip), puerto);

                socket.Connect(direccion);

                Consola.Imprimir("Enviando mensaje...");
                Consola.Imprimir(mensaje);

                byte[] bytes = Encoding.Default.GetBytes(mensaje);

                socket.Send(bytes, 0, bytes.Length, 0);

                socket.Close();

                Consola.Imprimir("Mensaje enviado. A la IP " + ip);
            }
            catch (Exception e)
            {
                Consola.Imprimir("No se pudo enviar el mensaje.");
                Consola.Imprimir(e.ToString());
            }
        }

    }
}
