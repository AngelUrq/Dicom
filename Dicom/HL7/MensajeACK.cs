using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dicom.HL7
{
    class MensajeACK
    {
        public MensajeACK() { }

        public static string GenerarMensaje(string tipoACK, Hashtable MSH) {

            string encabezado = "MSH|";
            string MSA = "";

            for (int i = 1; i < DefinicionSegmento.MSH.Count; i++)
            {
                if (MSH[DefinicionSegmento.MSH[i]] != null && i < MSH.Count - 1)
                {
                    encabezado += MSH[DefinicionSegmento.MSH[i]] + "|";
                }
                else if (i == MSH.Count - 1)
                {
                    if (MSH[DefinicionSegmento.MSH[i]] != null)
                    {
                        encabezado += MSH[DefinicionSegmento.MSH[i]];
                    }
                    else
                    {
                        encabezado += "";
                    }
                    
                }
                else
                {
                    encabezado += "|";
                }
            }

            MSA += "MSA|" + tipoACK + "|" + MSH[DefinicionSegmento.MSH[10]];

            return encabezado + "\n" + MSA;
        }
    }
}
