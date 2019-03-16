using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Entidades
{
    class Estudio
    {

        public int CodigoEstudio { get; set; }
        public int CodigoPaciente { get; set; }
        public int CodigoModalidad { get; set; }

        public bool Cancelado { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Estudio(int codigoEstudio, int codigoPaciente, int codigoModalidad, bool cancelado, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoEstudio = codigoEstudio;
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            Cancelado = cancelado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Estudio(int codigoPaciente, int codigoModalidad, bool cancelado, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            Cancelado = cancelado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

    }
}