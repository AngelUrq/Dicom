using Dicom.Entidades;
using Dicom.HL7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
	class PacienteControl
	{
		
		//insertar un paciente a la tabla Paciente
		public void Insertar()
		{
			Paciente paciente = new Paciente();
		}

        public bool VerificarPacienteExistente(Hashtable PID_LECTURA)
        {
            int codigoPaciente =  Convert.ToInt32(PID_LECTURA[DefinicionSegmento.PID[3]]);
            string sql = "SELECT * FROM paciente WHERE codigo_paciente = " + codigoPaciente;

            try
            {
                DataTable paciente = Conexion.Seleccionar(sql);
                return (paciente.Rows.Count == 1) ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la conexión.", "¡Error!");
                return false;
            }

        }
	}
}
