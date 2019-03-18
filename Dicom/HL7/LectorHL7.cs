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
        private bool valido;

        public LectorHL7()
        {
            lista = new List<Hashtable>();
            valido = true;
        }

        public List<Hashtable> LeerMensaje(string mensaje)
        {
            DividirEnSegmentos(mensaje);

            return lista;
        }

        private void DividirEnSegmentos(string mensaje)
        {
            string[] segmentos = mensaje.Split('\r');

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
                Consola.Imprimir("No reconocido el segmento " + campos[0]);
                valido = false;
            }
        }

        private void AsociarCampos(Hashtable definicionSegmento, string[] campos)
        {
            Hashtable tabla = new Hashtable();

            if (campos.Length <= definicionSegmento.Count)
            {
                Consola.Imprimir("-----" + campos[0] + "-----");
                tabla.Add("Segment Name", campos[0]);

                for (int i = 1; i < campos.Length; i++)
                {
                    if (campos[i] != "")
                    {
                        Consola.Imprimir(definicionSegmento[i] + ": " + campos[i]);
                        tabla.Add(definicionSegmento[i], campos[i]);
                    }
                }

                lista.Add(tabla);
                Console.WriteLine("----------------------------------------------------------------------");
            }
            else
            {
                Consola.Imprimir("La definición de " + definicionSegmento[0] + " no concuerda con la cantidad de campos del mensaje");
                Consola.Imprimir(campos.Length + "-" + definicionSegmento.Count);
                valido = false;
            }
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

        public bool EsValido()
        {
            return valido;
        }

    }
}
