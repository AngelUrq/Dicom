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
                    if (MSH[DefinicionSegmento.MSH[i]] != null && i < MSH.Count - 1 && i != 2 && i != 3 && i != 4 && i != 5 && i != 9)
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
                    else if (i == 2)
                    {
                        encabezado += MSH[DefinicionSegmento.MSH[i + 2]] + Convert.ToString(MSH["Field Separator"]) + MSH[DefinicionSegmento.MSH[i + 3]] + Convert.ToString(MSH["Field Separator"]) + MSH[DefinicionSegmento.MSH[i]] + Convert.ToString(MSH["Field Separator"]) + MSH[DefinicionSegmento.MSH[i + 1]] + Convert.ToString(MSH["Field Separator"]);
                    }
                    else if (i == 9)
                    {
                        string[] tipoMensajeCompleto = MSH[DefinicionSegmento.MSH[i]].ToString().Split('^');
                        string tipoMensaje = "";

                        if (tipoMensajeCompleto.Length >= 2)
                            tipoMensaje = "ACK^" + tipoMensajeCompleto[1];

                        encabezado += tipoMensaje + Convert.ToString(MSH["Field Separator"]);
                    }
                    else
                    {
                        encabezado += Convert.ToString(MSH["Field Separator"]);
                    }
                }

                MSA += "MSA" + Convert.ToString(MSH["Field Separator"]) + tipoACK + Convert.ToString(MSH["Field Separator"]) + MSH[DefinicionSegmento.MSH[10]];

                return encabezado + "\r" + MSA;
            }
            else
            {
                Consola.Imprimir("Ocurrió un error al crear el mensaje ACK");
            }

            return "";
        }
    }
}
