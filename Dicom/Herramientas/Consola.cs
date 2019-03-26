using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom
{
    class Consola
    {
        /// <summary>
        /// Imprime mensajes por consola
        /// </summary>
        /// <param name="mensaje">Mensaje</param>
        public static void Imprimir(string mensaje)
        {
            Console.WriteLine("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "]: " + mensaje);
        }

    }
}
