using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.HL7
{
    class LectorHL7
    {
        private static readonly Hashtable MSH = new Hashtable
        {
            { 0, "MSH" },
            { 1, "Field Separator" },
            { 2, "Encoding Characters"},
            { 3, "Sending Application"},
            { 4, "Sending Facility"},
            { 5, "Receiving Application"},
            { 6, "Receiving Facility"},
            { 7, "Date / Time of Message"},
            { 8, "Security"},
            { 9, "Message Type"},
            { 10, "Message Control ID"},
            { 11, "Processing ID"},
            { 12, "Version ID"},
            { 13, "Sequence Number" },
            { 14, "Continuation Pointer"},
            { 15, "Accept Acknowledgement Type"},
            { 16, "Application Acknowledgement Type"},
            { 17, "Country Code"},
            { 18, "Character Set" },
            { 19, "Principal Language of Message" }
        };

        private static readonly List<Hashtable> listaSegmentos = new List<Hashtable>
        {
            MSH
        };

        public static void LeerMensaje(string mensaje)
        {
            DividirEnSegmentos(mensaje);
        }

        private static void DividirEnSegmentos(string mensaje)
        {
            string[] segmentos = mensaje.Split('#');

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
            {
                AsociarCampos(definicionSegmento, campos);
            }
        }

        private static void AsociarCampos(Hashtable definicionSegmento, string[] campos)
        {
            for (int i = 1; i < campos.Length; i++)
            {
                Consola.Imprimir(definicionSegmento[i] + ":" + campos[i]);
            }
        }

        private static Hashtable BuscarSegmento(string nombreSegmento)
        {
            foreach (Hashtable definicionSegmento in listaSegmentos)
            {
                if (definicionSegmento[0].Equals(nombreSegmento))
                    return definicionSegmento;
            }

            return null;
        }

    }
}
