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
        private string mensaje;

        public ProcesadorMensaje(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public void Empezar()
        {
            LectorHL7 lector = new LectorHL7();

            List<Hashtable> lista = lector.LeerMensaje(mensaje);

            if (lector.EsValido())
                ProcesarTipoMensaje(lista);
            else
                Consola.Imprimir("El mensaje no es válido");
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
                    Consola.Imprimir("Insertando paciente");
                    PacienteControl.Insertar(segmento);
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
        
    }
}
