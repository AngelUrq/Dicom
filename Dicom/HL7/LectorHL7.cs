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

        private char separadorSegmento;

        public LectorHL7()
        {
            lista = new List<Hashtable>();
            valido = true;
        }

        public List<Hashtable> LeerMensaje(string mensaje)
        {
            DividirEnSegmentos(mensaje);

            ComprobarVersion();

            return lista;
        }
        
        private void DividirEnSegmentos(string mensaje)
        {
            string[] segmentos = mensaje.Split('\r');

            if (segmentos.Length > 0)
            {
                DividirEnCamposMSH(segmentos[0]);

                segmentos = QuitarPrimerElemento(segmentos);

                foreach (string segmento in segmentos)
                {
                    DividirEnCampos(segmento);
                }
            }
            else
            {
                Consola.Imprimir("El mensaje no tiene ningún segmento.");
                valido = false;
            }
        }

        private string[] QuitarPrimerElemento(string[] segmentos)
        {
            string[] nuevoSegmentos = new string[segmentos.Length - 1];

            for(int i = 0; i < nuevoSegmentos.Length; i++)
                nuevoSegmentos[i] = segmentos[i + 1];

            return nuevoSegmentos;
        }

        private void DividirEnCamposMSH(string segmento)
        {
            separadorSegmento = segmento[3];

            string[] campos = segmento.Split(separadorSegmento);

            string[] camposConElSeparador = new string[campos.Length + 1];

            camposConElSeparador[0] = campos[0];
            camposConElSeparador[1] = Convert.ToString(separadorSegmento);

            for (int i = 2; i < camposConElSeparador.Length; i++)
                camposConElSeparador[i] = campos[i-1];

            ElegirSegmento(camposConElSeparador);
        }

        private void DividirEnCampos(string segmento)
        {
            string[] campos = segmento.Split(separadorSegmento);

            ElegirSegmento(campos);
        }

        private void ElegirSegmento(string[] campos)
        {
            Hashtable definicionSegmento = BuscarSegmento(campos[0]);

            if (definicionSegmento != null)
            {
                if (campos.Length > 0)
                    AsociarCampos(definicionSegmento, campos);
            }
            else
            {
                Consola.Imprimir("No reconocido el segmento " + campos[0]);
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

        private void ComprobarVersion()
        {
            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("MSH"))
                {
                    string version = (string)segmento["Version ID"];

                    if (version != null)
                    {
                        Regex regex = new Regex(@"2.4");
                        Match match = regex.Match(version);

                        if (match.Success)
                        {
                            Consola.Imprimir("Versión correcta.");
                        }
                        else
                        {
                            Consola.Imprimir("La versión de HL7 no se acepta. Asegúrate de que el mensaje esté en 2.X");

                            valido = false;
                        }
                    }
                    else
                    {
                        Consola.Imprimir("El mensaje debe tener todos los campos requeridos.");
                        valido = false;
                    }
                }
            }
        }
        
        public bool EsValido()
        {
            return valido;
        }

    }
}
