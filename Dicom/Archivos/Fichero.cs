using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dicom
{
    class Fichero
    {
        public string Leer(string nombreArchivo)
        {
            string mensaje = "";

            StreamReader leer = new StreamReader(nombreArchivo);
            mensaje = leer.ReadToEnd();

            return mensaje;
        }
    }
}
