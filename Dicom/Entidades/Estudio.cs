using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Entidades
{
    public class Estudio
    {

        public int CodigoEstudio { get; set; }
        public int CodigoPaciente { get; set; }
        public int CodigoModalidad { get; set; }

        public bool Cancelado { get; set; }
        public bool Admitido { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Estudio(int codigoEstudio, int codigoPaciente, int codigoModalidad, bool cancelado, bool admitido, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoEstudio = codigoEstudio;
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            Cancelado = cancelado;
            Admitido = admitido;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Estudio(int codigoPaciente, int codigoModalidad, bool cancelado, bool admitido, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            Cancelado = cancelado;
            Admitido = admitido;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Estudio(int codigo, DateTime fechaInicio)
        {
            CodigoEstudio = codigo;
            FechaInicio = fechaInicio;
        }

    }
}