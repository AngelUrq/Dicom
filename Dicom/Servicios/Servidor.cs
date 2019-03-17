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

        private void ConvertirMensaje(string mensaje)
        {
            LectorHL7 lector = new LectorHL7();

            List<Hashtable> lista = lector.LeerMensaje(mensaje);

            if (lector.EsValido())
                ProcesarTipoMensaje(lista);
            else
                Consola.Imprimir("El mensaje no es válido");
        }

        private void ProcesarTipoMensaje(List<Hashtable> lista)
        {
            string tipoMensaje = BuscarTipoMensaje(lista);

            switch (tipoMensaje)
            {
                case "ADT^A01":
                    ProcesarAdmision(lista);
                    break;
                default:
                    Consola.Imprimir("No se acepta este tipo de mensaje");
                    break;
            }
        }

        private void ProcesarAdmision(List<Hashtable> lista)
        {
            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("PID"))
                {
                    Consola.Imprimir("Insertando paciente");
                    PacienteControl.Insertar(segmento);
                    break;
                }
            }
        }

        private string BuscarTipoMensaje(List<Hashtable> lista)
        {
            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("MSH"))
                {
                    return (string) segmento["Message Type"];
                }
            }

            return "";
        }
        
    }
}
