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

        public Cliente(string ip, int puerto)
        {
            this.ip = ip;
            this.puerto = puerto;
        }

        public void EnviarMensaje(string mensaje)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(ip),puerto);

            socket.Connect(direccion);

            Consola.Imprimir("Enviando mensaje...");
            Consola.Imprimir(mensaje);

            byte[] bytes = Encoding.Default.GetBytes(mensaje);

            socket.Send(bytes,0,bytes.Length,0);

            socket.Close();

            Consola.Imprimir("Mensaje enviado. A la IP " + ip);
        }

    }
}
