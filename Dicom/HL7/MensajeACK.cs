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
                try
                {
                    string encabezado = "MSH" + Convert.ToString(MSH["Field Separator"]);
                    string MSA = "";

                    for (int i = 2; i < DefinicionSegmento.MSH.Count; i++)
                    {
                        if (MSH.ContainsKey(DefinicionSegmento.MSH[i]) && i < MSH.Count - 1 && i != 3 && i != 4 && i != 5 && i != 6 && i != 9)
                        {
                            encabezado += MSH[DefinicionSegmento.MSH[i]] + Convert.ToString(MSH["Field Separator"]);
                        }
                        else if (i == DefinicionSegmento.MSH.Count - 1)
                        {
                            if (MSH.ContainsKey(DefinicionSegmento.MSH[i]))
                            {
                                encabezado += MSH[DefinicionSegmento.MSH[i]];
                            }
                            else
                            {
                                encabezado += "";
                            }

                        }
                        else if (i == 3)
                        {
                            string sendingApplication = "";
                            string sendingFacility = "";
                            string receivingApplication = "";
                            string receivingFacility = "";

                            if (MSH.ContainsKey(DefinicionSegmento.MSH[3]))
                            {
                                receivingApplication = MSH[DefinicionSegmento.MSH[3]].ToString();
                            }
                            if (MSH.ContainsKey(DefinicionSegmento.MSH[4]))
                            {
                                receivingFacility = MSH[DefinicionSegmento.MSH[4]].ToString();
                            }
                            if (MSH.ContainsKey(DefinicionSegmento.MSH[5]))
                            {
                                sendingApplication = MSH[DefinicionSegmento.MSH[5]].ToString();
                            }
                            if (MSH.ContainsKey(DefinicionSegmento.MSH[6]))
                            {
                                sendingFacility = MSH[DefinicionSegmento.MSH[6]].ToString();
                            }

                            encabezado += sendingApplication + Convert.ToString(MSH["Field Separator"]) + sendingFacility + Convert.ToString(MSH["Field Separator"]) + receivingApplication + Convert.ToString(MSH["Field Separator"]) + receivingFacility + Convert.ToString(MSH["Field Separator"]);
                        }
                        else if (i == 9)
                        {
                            string[] tipoMensajeCompleto = MSH[DefinicionSegmento.MSH[i]].ToString().Split('^');
                            string tipoMensaje = "";

                            if (tipoMensajeCompleto.Length >= 1)
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
                } catch(Exception e)
                {
                    Consola.Imprimir("Faltan campos en el MSH");
                }
            }
            else
            {
                Consola.Imprimir("Ocurrió un error al crear el mensaje ACK");
            }

            return "";
        }
    }
}
