using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Excepciones
{
    class PacienteExistenteExcepcion : Exception
    {

        public PacienteExistenteExcepcion() : base("El paciente ya existe en la base de datos.")
        {
        }

    }
}
