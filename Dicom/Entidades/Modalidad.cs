using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Entidades
{
    public class Modalidad
    {
        public int CodigoModalidad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Modalidad(){ }
        public Modalidad(int codigoModalidad, string nombre, string descripcion)
        {
            CodigoModalidad = codigoModalidad;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public Modalidad(string nombre)
        {
            Nombre = nombre;
        }
    }
}
