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
        public static string GenerarMensaje(string tipoACK, Hashtable MSH) {
            if (MSH != null)
            {
                string encabezado = "MSH" + Convert.ToString(MSH["Field Separator"]);
                string MSA = "";

                for (int i = 2; i < DefinicionSegmento.MSH.Count; i++)
                {
                    if (MSH[DefinicionSegmento.MSH[i]] != null && i < MSH.Count - 1)
                    {
                        encabezado += MSH[DefinicionSegmento.MSH[i]] + Convert.ToString(MSH["Field Separator"]);
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
                        encabezado += Convert.ToString(MSH["Field Separator"]);
                    }
                }

                MSA += "MSA" + Convert.ToString(MSH["Field Separator"]) + tipoACK + Convert.ToString(MSH["Field Separator"]) + MSH[DefinicionSegmento.MSH[10]];

                return encabezado + "\n" + MSA;
            }
            else
            {
                Consola.Imprimir("Ocurrió un error al crear el mensaje ACK");
            }

            return "";
        }
    }
}
