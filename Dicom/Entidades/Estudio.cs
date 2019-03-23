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

        public string NumeroDeAcceso { get; set; }
        public string MedicoDeReferencia { get; set; }
        public string MedicoDeEjercicio { get; set; }

        public bool Cancelado { get; set; }
        public bool Admitido { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Estudio(int codigoEstudio, int codigoPaciente, int codigoModalidad, string numeroAcceso, string medicoReferencia, string medicoEjercicio, bool cancelado, bool admitido, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoEstudio = codigoEstudio;
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            NumeroDeAcceso = numeroAcceso;
            MedicoDeReferencia = medicoReferencia;
            MedicoDeEjercicio = medicoEjercicio;
            Cancelado = cancelado;
            Admitido = admitido;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Estudio(int codigoPaciente, int codigoModalidad, string numeroAcceso, string medicoReferencia, string medicoEjercicio, bool cancelado, bool admitido, DateTime fechaInicio, DateTime fechaFin)
        {
            CodigoPaciente = codigoPaciente;
            CodigoModalidad = codigoModalidad;
            NumeroDeAcceso = numeroAcceso;
            MedicoDeReferencia = medicoReferencia;
            MedicoDeEjercicio = medicoEjercicio;
            Cancelado = cancelado;
            Admitido = admitido;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public Estudio(int codigo, string accessionNumber, string medicoReferencia, string medicoEjercicio, DateTime fechaInicio)
        {
            CodigoEstudio = codigo;
            NumeroDeAcceso = accessionNumber;
            MedicoDeReferencia = medicoReferencia;
            MedicoDeEjercicio = medicoEjercicio;
            FechaInicio = fechaInicio;
        }

    }
}