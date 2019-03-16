using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.HL7
{
    class LectorHL7
    {

        public static void LeerMensaje(string mensaje)
        {
            DividirEnSegmentos(mensaje);
        }

        private static void DividirEnSegmentos(string mensaje)
        {
            string[] segmentos = mensaje.Split('\n');

            foreach (string segmento in segmentos)
            {
                DividirEnCampos(segmento);
            }
        }

        private static void DividirEnCampos(string segmento)
        {
            string[] campos = segmento.Split('|');

            Hashtable definicionSegmento = BuscarSegmento(campos[0]);

            if (definicionSegmento != null)
                AsociarCampos(definicionSegmento, campos);
            else
                MessageBox.Show("Mensaje HL7 no reconocido");
        }

        private static void AsociarCampos(Hashtable definicionSegmento, string[] campos)
        {
            for (int i = 1; i < campos.Length; i++)
            {
                Consola.Imprimir(definicionSegmento[i] + " : " + campos[i]);
            }

            Console.WriteLine("----------------------------------------------------------------------");
        }

        private static Hashtable BuscarSegmento(string nombreSegmento)
        {
            foreach (Hashtable definicionSegmento in DefinicionSegmento.listaSegmentos)
            {
                if (definicionSegmento[0].Equals(nombreSegmento))
                    return definicionSegmento;
            }

            return null;
        }

    }
}
