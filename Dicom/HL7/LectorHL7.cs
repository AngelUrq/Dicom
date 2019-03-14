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

        private static readonly Hashtable EVN = new Hashtable
        {
            { 0, "EVN" },
            { 1, "Event Type Code" },
            { 2, "Recorded Date/Time" },
            { 3, "Date/Time Planned Event" },
            { 4, "Event Reason Code" },
            { 5, "Operator ID" },
            { 6, "Event Occurred" },
        };

        private static readonly Hashtable PID = new Hashtable
        {
            { 0, "PID" },
            { 1, "Set ID-Patient ID" },
            { 2, "Patient ID (External ID)"},
            { 3, "Patient ID (Internal ID)"},
            { 4, "Alternate Patient ID-PID"},
            { 5, "Patient Name"},
            { 6, "Mother's Maiden Name"},
            { 7, "Date / Time of Birth"},
            { 8, "Sex"},
            { 9, "Patient Alias"},
            { 10, "Race"},
            { 11, "Patient Address" },
            { 12, "Country Code" },
            { 13, "Phone Number – Home" },
            { 14, "Phone Number – Business" },
            { 15, "Primary Language" },
            { 16, "Marital Status" },
            { 17, "Religion" },
            { 18, "Patient Account Number" },
            { 19, "SSN Number – Patient" },
            { 20, "Driver's License Number-Patient"},
            { 21, "Mother's Identifier"},
            { 22, "Ethnic Group"},
            { 23, "Birth Place"},
            { 24, "Multiple Birth Indicator"},
            { 25, "Birth Order"},
            { 26, "Citizenship"},
            { 27, "Veterans Military Status"},
            { 28, "Nationality"},
            { 29, "Patient Death Date and Time"},
            { 30, "Patient Death Indicator"},
        };

        private static readonly List<Hashtable> listaSegmentos = new List<Hashtable>
        {
            MSH,
            EVN,
            PID
        };

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
              //Consola.Imprimir(definicionSegmento[i] + ":" + campos[i]);
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
