using Dicom.Control;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.HL7
{
    class ProcesadorMensaje
    {
        private LectorHL7 lector;

        private Hashtable MSH;

        private readonly string mensaje;

        private bool listo;
        
        public ProcesadorMensaje(string mensaje)
        {
            lector = new LectorHL7();

            this.mensaje = mensaje;
            listo = false;
        }

        public void Empezar()
        {
            List<Hashtable> lista = lector.LeerMensaje(mensaje);

            BuscarMSH(lista);

            if (lector.EsValido())
                ProcesarTipoMensaje(lista);
            else
                Consola.Imprimir("El mensaje no es válido");
        }

        public void BuscarMSH(List<Hashtable> lista)
        {
            foreach (Hashtable segmento in lista)
            {
                if(segmento["Segment Name"].Equals("MSH"))
                {
                    MSH = segmento;
                    break;
                }
            }
        }

        private void ProcesarTipoMensaje(List<Hashtable> lista)
        {
            string tipoMensaje = BuscarTipoMensaje(lista);

            switch (tipoMensaje)
            {
                case "ADT^A01":
                    ProcesarAdmision(lista);
                    break;
                default:
                    Consola.Imprimir("No se acepta este tipo de mensaje");
                    break;
            }
        }

        private void ProcesarAdmision(List<Hashtable> lista)
        {
            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("PID"))
                {
                    Consola.Imprimir("Insertando paciente...");

                    try
                    {
                        PacienteControl.Insertar(segmento);
                        Consola.Imprimir("Paciente insertado.");

                        listo = true;
                    }
                    catch (Exception e)
                    {
                        Consola.Imprimir(e.ToString());
                    }
                    
                    break;
                }
            }
        }

        private string BuscarTipoMensaje(List<Hashtable> lista)
        {
            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("MSH"))
                {
                    return (string)segmento["Message Type"];
                }
            }

            return "";
        }
        
        public string ObtenerTipoMensajeRespuesta()
        {
            if (!lector.EsValido())
            {
                return "AE";
            }
            else
            {
                if (listo)
                    return "AA";
                else
                    return "AR";
            }
        }

        public Hashtable ObtenerMSH()
        {
            return MSH;
        }

    }
}
