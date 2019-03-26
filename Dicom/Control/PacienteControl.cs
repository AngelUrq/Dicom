using Dicom.Entidades;
using Dicom.Excepciones;
using Dicom.Herramientas;
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
        /// <summary>
        /// Inserta un paciente en la base de datos
        /// </summary>
        /// <param name="lista">Datos del paciente</param>
		public static void Insertar(Hashtable lista)
		{
            if (!VerificarPacienteExistente(lista))
            {
                Paciente paciente = new Paciente();
                string[] nombres = lista["Patient Name"].ToString().Split('^');

                string resultado = "";
                string fecha = "";
                string paciente_id = "";
                string genero = "";
                string direccion = "";
                string telefono = "";

                if (lista.ContainsKey("Date/Time Of Birth"))
                {
                    resultado = DateTime.ParseExact(lista["Date/Time Of Birth"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
                    DateTime pDate = Convert.ToDateTime(resultado);
                    fecha = pDate.ToString("yyyy-MM-dd hh:mm:ss");
                }

                if (lista.ContainsKey("Patient ID"))
                    paciente_id = (string) lista["Patient ID"];
                else
                    paciente_id = GeneradorIdentificadores.GenerarAccessionNumber();

                if (lista.ContainsKey("Administrative Sex"))
                    genero = (string) lista["Administrative Sex"];

                if (lista.ContainsKey("Patient Address"))
                    direccion = (string) lista["Patient Address"];

                if (lista.ContainsKey("Phone Number – Home"))
                    telefono = (string) lista["Phone Number – Home"];

                string sql = "INSERT INTO paciente VALUES ('" + paciente_id + "','" + nombres[1] + "','" + nombres[0] + "','" + "" + "','" + genero + "','" + direccion.Replace("^", " ") + "' ,'" + fecha + "',' " + "','" + telefono + "')";
                Conexion.Ejecutar(sql);
            }
            else
            {
                throw new PacienteExistenteExcepcion();
            }
		}

        /// <summary>
        /// Verifica si el paciente existe
        /// </summary>
        /// <param name="PID_LECTURA">Datos del paciente</param>
        /// <returns>Verdadero o falso</returns>
        public static bool VerificarPacienteExistente(Hashtable PID_LECTURA)
        {
            string codigoPaciente = (((string)PID_LECTURA[DefinicionSegmento.PID[2]]).Split('^'))[0];
            
            string sql = "SELECT * FROM paciente WHERE codigo_paciente = '" + codigoPaciente + "'";

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

        /// <summary>
        /// Busca el paciente según su código
        /// </summary>
        /// <param name="codigoPaciente">Código de paciente</param>
        /// <returns></returns>
        public static Paciente BuscarPaciente(string codigoPaciente)
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
