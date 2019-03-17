using System;
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
            ThreadStart delegado = new ThreadStart(EjecutarHilo);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        public void EjecutarHilo()
        {
            string ip = "192.168.0.11";
            int puerto = 52000;
            int conexionesMaximas = 10;

            Consola.Imprimir("Iniciando servidor...\n\tIP: " + ip + "\n\tPuerto: " + puerto + "\n\tNúmero de conexiones máximo: " + conexionesMaximas);
 
            while (true)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(ip), puerto);

                socket.Bind(direccion);
                socket.Listen(conexionesMaximas);

                Socket escuchar = socket.Accept();

                byte[] bytes = new byte[255];

                int a = escuchar.Receive(bytes, 0, bytes.Length, 0);

                Array.Resize(ref bytes, a);
                
                string mensaje = Encoding.UTF8.GetString(bytes);
                Console.WriteLine("Mensaje recibido: " + mensaje);

                escuchar.Close();
                socket.Close();
            }
        }

    }
}
