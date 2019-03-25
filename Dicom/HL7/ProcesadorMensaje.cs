using Dicom.Control;
using Dicom.Entidades;
using Dicom.Herramientas;
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
            Consola.Imprimir("Mensaje separado correctamente.");
            string[] tipoMensajeCompleto = BuscarTipoMensaje(lista).Split('^');
            string tipoMensaje = "";

            if (tipoMensajeCompleto.Length >= 2)
                tipoMensaje = tipoMensajeCompleto[0] + "^" + tipoMensajeCompleto[1];

            switch (tipoMensaje)
            {
                case "ADT^A01":
                    ProcesarAdmision(lista);
                    break;
                case "ORM^O01":
                    ProcesarOrden(lista);
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
                    if (segmento.ContainsKey("Patient ID"))
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
                    else
                    {
                        Consola.Imprimir("Faltan campos obligatorios en el PID...");
                    }
                }
            }
        }

        private void ProcesarOrden(List<Hashtable> lista)
        {
            bool correcto = true;

            int codigo_paciente = -1;
            int codigo_modalidad = -1;
            string numero_acceso = GeneradorIdentificadores.GenerarAccessionNumber();
            string medico_referencia = "";
            string medico_ejercicio = "";
            bool admitido = false;
            bool cancelado = false;
            DateTime fecha_inicio = DateTime.Now;
            DateTime fecha_fin = DateTime.Now;

            foreach (Hashtable segmento in lista)
            {
                if (segmento["Segment Name"].Equals("PID"))
                {
                    bool pacienteCorrecto = VerificarPaciente(segmento);

                    if (pacienteCorrecto)
                        codigo_paciente = Convert.ToInt32((((string) segmento["Patient ID (Internal ID)"]).Split('^'))[0]);

                    correcto = correcto && pacienteCorrecto;
                }

                if (segmento["Segment Name"].Equals("OBR"))
                {
                    if (segmento.ContainsKey("Diagnostic Serv Sect ID"))
                    {
                        codigo_modalidad = ModalidadControl.BuscarModalidad((string) segmento["Diagnostic Serv Sect ID"]);

                        if (codigo_modalidad == -1)
                        {
                            Consola.Imprimir("No existe ese Diagnostic Serv Sect ID");
                            correcto = false;
                        }
                    }
                    else
                    {
                        Consola.Imprimir("El mensaje no tiene el Diagnostic Serv Sect ID");
                        correcto = false;
                    }

                    if (segmento.ContainsKey("Observation Date/Time") && segmento.ContainsKey("Observation End Date/Time"))
                    {
                        fecha_inicio = ConversorFechas.ConvertirFechaHL7((string)segmento["Observation Date/Time"]);
                        fecha_fin = ConversorFechas.ConvertirFechaHL7((string)segmento["Observation End Date/Time"]);
                    }
                    else
                    {
                        Consola.Imprimir("La orden debe tener hora inicio y hora fin");
                        correcto = false;
                    }
                }

                if (segmento["Segment Name"].Equals("PV1"))
                {
                    if (segmento.ContainsKey("Attending Doctor"))
                        medico_ejercicio = (string) segmento["Attending Doctor"];
                    if (segmento.ContainsKey("Referring Doctor"))
                        medico_referencia = (string)segmento["Referring Doctor"];
                }
            }

            if (correcto)
            {
                listo = true;

                Consola.Imprimir("Procesamiento de ORM exitoso");

                Estudio estudio = new Estudio(codigo_paciente,codigo_modalidad,numero_acceso,medico_referencia,medico_ejercicio,admitido,cancelado,fecha_inicio,fecha_fin);

                EstudioControl.Insertar(estudio);
            }
            else
            {
                listo = false;
                Consola.Imprimir("Procesamiento de ORM fallido");
            }
        }

        private bool VerificarPaciente(Hashtable pid)
        {
            if (pid.ContainsKey("Patient ID (Internal ID)"))
                return PacienteControl.VerificarPacienteExistente(pid);

            return false;
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
                return "AR";
            }
            else
            {
                if (listo)
                    return "AA";
                else
                    return "AE";
            }
        }

        public Hashtable ObtenerMSH()
        {
            return MSH;
        }

    }
}
