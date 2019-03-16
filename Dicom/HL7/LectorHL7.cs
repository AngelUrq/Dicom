using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.HL7
{
    class LectorHL7
    {
        private List<Hashtable> lista;

        public LectorHL7()
        {
            lista = new List<Hashtable>();
        }

        public List<Hashtable> LeerMensaje(string mensaje)
        {
            DividirEnSegmentos(mensaje);

            return lista;
        }

        private void DividirEnSegmentos(string mensaje)
        {
            string[] segmentos = mensaje.Split('\n');

            foreach (string segmento in segmentos)
            {
                DividirEnCampos(segmento);
            }
        }

        private void DividirEnCampos(string segmento)
        {
            string[] campos = segmento.Split('|');

            Hashtable definicionSegmento = BuscarSegmento(campos[0]);

            if (definicionSegmento != null)
            {
                if (campos.Length > 0)
                    AsociarCampos(definicionSegmento, campos);
            }
            else
            {
                MessageBox.Show("No reconocido el segmento " + campos[0]);
            }
        }

        private void AsociarCampos(Hashtable definicionSegmento, string[] campos)
        {
            Hashtable tabla = new Hashtable();

            Consola.Imprimir("-----" + campos[0] + "-----");
            tabla.Add("Segment Name", campos[0]);

            for (int i = 1; i < campos.Length; i++)
            {
                if (campos[i].ToString() != "" && campos[i].ToString() != "\r")
                {
                    Consola.Imprimir(definicionSegmento[i] + ": " + campos[i]);
                    tabla.Add(definicionSegmento[i], campos[i]);
                }
            }

            lista.Add(tabla);
            Console.WriteLine("----------------------------------------------------------------------");
        }

        private Hashtable BuscarSegmento(string nombreSegmento)
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
