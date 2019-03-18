using Dicom.Entidades;
using Dicom.Excepciones;
using Dicom.HL7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
	class PacienteControl
	{

		public static void Insertar(Hashtable lista)
		{
            if (!VerificarPacienteExistente(lista))
            {
                Paciente paciente = new Paciente();
                string[] nombres = lista["Patient Name"].ToString().Split('^');
                string resultado = DateTime.ParseExact(lista["Date / Time of Birth"].ToString(), "yyyyMMdd",
                    CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");

                DateTime pDate = Convert.ToDateTime(resultado);
                string fecha = pDate.ToString("yyyy-MM-dd hh:mm:ss");

                string sql = "INSERT INTO paciente VALUES ('" + lista["Patient ID (Internal ID)"] + "','" + nombres[1] + "','" + nombres[0] + "','" + "" + "','" + lista["Sex"] + "','" + lista["Patient Address"].ToString().Replace("^", " ") + "' ,'" + fecha + "',' " + "','" + lista["Phone Number – Home"] + "')";
                Conexion.Ejecutar(sql);
            }
            else
            {
                throw new PacienteExistenteExcepcion();
            }
		}

        public static bool VerificarPacienteExistente(Hashtable PID_LECTURA)
        {
            string codigoInterno = (((string)PID_LECTURA[DefinicionSegmento.PID[3]]).Split('^'))[0];

            int codigoPaciente =  Convert.ToInt32(codigoInterno);
            string sql = "SELECT * FROM paciente WHERE codigo_paciente = " + codigoPaciente;

            try
            {
                DataTable paciente = Conexion.Seleccionar(sql);
                return (paciente.Rows.Count == 1) ? true : false;
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Ha ocurrido un error en la conexión.", "¡Error!");
                return false;
            }

        }

        public static Paciente BuscarPaciente(int codigoPaciente)
        {
            string sql = "SELECT * FROM paciente WHERE codigo_paciente = " + codigoPaciente;

            try
            {
                DataTable paciente = Conexion.Seleccionar(sql);
                Paciente datos_paciente = new Paciente(codigoPaciente, paciente.Rows[0][1].ToString(), paciente.Rows[0][2].ToString(), paciente.Rows[0][3].ToString(), paciente.Rows[0][4].ToString(), paciente.Rows[0][5].ToString(), Convert.ToDateTime(paciente.Rows[0][6].ToString()), paciente.Rows[0][7].ToString(), paciente.Rows[0][8].ToString());
                return datos_paciente;
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Ha ocurrido un error en la conexión.", "¡Error!");
                return null;
            }

        }
	}
}
