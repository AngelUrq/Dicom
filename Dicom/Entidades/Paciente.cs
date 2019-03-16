using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Entidades
{
	class Paciente
	{


		public int Codigo_Paciente { get; set; }
		public string Nombres { get; set; }
		public string Apellido_Paterno { get; set; }
		public string Apellido_Materno { get; set; }
		public string Genero { get; set; }
		public string Direccion { get; set; }
		public DateTime Fecha_Nacimiento { get; set; }
		public string Codigo_Pais { get; set; }
		public string Telefono { get; set; }

		public Paciente(int codigo_Paciente, string nombres, string apellido_Paterno, string apellido_Materno, string genero, string direccion, DateTime fecha_Nacimiento, string codigo_Pais, string telefono)
		{
			Codigo_Paciente = codigo_Paciente;
			Nombres = nombres;
			Apellido_Paterno = apellido_Paterno;
			Apellido_Materno = apellido_Materno;
			Genero = genero;
			Direccion = direccion;
			Fecha_Nacimiento = fecha_Nacimiento;
			Codigo_Pais = codigo_Pais;
			Telefono = telefono;
		}
		public Paciente()
		{

		}
	}
}
