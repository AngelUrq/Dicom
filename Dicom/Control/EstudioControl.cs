using Dicom.Entidades;
using Dicom.Herramientas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
    class EstudioControl
    {

        public static void Insertar(Estudio estudio)
        {

            if (VerificarHorario(estudio))
            {
                string SQL = "INSERT INTO estudio(codigo_paciente,codigo_modalidad,numero_acceso,medico_referencia,medico_ejercicio,cancelado,admitido,fecha_inicio,fecha_fin) VALUES('" + estudio.CodigoPaciente + "','" + GeneradorIdentificadores.GenerarAccessionNumber() + "','" + estudio.NumeroDeAcceso + "','" + estudio.MedicoDeReferencia + "','" + estudio.MedicoDeEjercicio + "'," + estudio.Cancelado + "," + estudio.Admitido + ",'" + estudio.FechaInicio.ToString("s") + "','" + estudio.FechaFin.ToString("s") + "')";

                try
                {
                    Conexion.Ejecutar(SQL);
                }
                catch (Exception e)
                {
                    Consola.Imprimir(e.ToString());
                    MessageBox.Show("Error al insertar en la base de datos");
                }
            }
        }

        public static bool VerificarHorario(Estudio estudio)
        {
            return true;
        }

        public static DataTable BuscarEstudios()
        {
            string SQL = "SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', modalidad.nombre AS 'MODALIDAD', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO',estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM paciente INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad WHERE estudio.admitido = '0' AND estudio.cancelado = '0'";

            try
            {
                DataTable consulta = Conexion.Seleccionar(SQL);
                return consulta;
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Error al consultar en la base de datos");
            }

            return null;
        }

        public static DataTable BuscarEstudiosEnFecha(string fecha)
        {
            string SQL = @"SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', modalidad.nombre AS 'MODALIDAD', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO',estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM paciente 
                           INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente 
                           INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad 
                           WHERE CAST(fecha_inicio AS DATE) = CAST('" + fecha + "' AS DATE) AND estudio.admitido = '1'";

            try
            {
                DataTable consulta = Conexion.Seleccionar(SQL);
                return consulta;
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Error al consultar en la base de datos", "Error");
            }

            return null;
        }

        public static DataTable BuscarEstudiosPorModalidad(int codigo)
        {
            string fecha = DateTime.Now.ToString("s");
            string sql = @"
                SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', modalidad.nombre AS 'MODALIDAD', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO',estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM estudio
                INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad
                INNER JOIN paciente on estudio.codigo_paciente = paciente.codigo_paciente            
                WHERE estudio.codigo_modalidad = " + codigo + " AND estudio.admitido = '1' AND CAST(estudio.fecha_inicio AS DATE) = CAST('" + fecha + "' AS DATE)";

            try
            {
                return Conexion.Seleccionar(sql);
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Ha ocurrido un error con la conexión.");
                return null;
            }
        }
        
		public static void BorrarAgendamiento(string codigoEstudio)
		{
			string sql = "UPDATE estudio SET cancelado = '1' where codigo_estudio=" + codigoEstudio;
			try
			{
				Conexion.Ejecutar(sql);
				Consola.Imprimir("Se cancelo correctamente.");
			}
			catch(Exception e)
			{
				Consola.Imprimir("Error al cancelar.");
			}

		}

        public static DataTable SeleccionarEstudiosPorFechaYModalidad(int codigoModalidad, string fechaSeleccionada)
        {
            DataTable datos = new DataTable();

            string sql = @"SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', modalidad.nombre AS 'MODALIDAD', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO',estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM " +
                "paciente INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente" +
                " INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad" +
                " WHERE estudio.codigo_modalidad = " + codigoModalidad + " AND CAST(fecha_inicio AS DATE) = CAST('" + fechaSeleccionada + "'AS DATE)" + " AND estudio.admitido = '1'";
            try
            {
                datos = Conexion.Seleccionar(sql);
                return datos;

            }
            catch (Exception e)
            {
                Consola.Imprimir(e.Message);
                return null;
            }
        }

        public static void AdmitirPaciente(string codigoEstudio)
        {
            string sql = "UPDATE estudio SET admitido = '1' where codigo_estudio=" + codigoEstudio;
            try
            {
                Conexion.Ejecutar(sql);
                Consola.Imprimir("Se admitio el estudio correctamente.");
            }
            catch (Exception e)
            {
                Consola.Imprimir("Error al cancelar.");
            }
        }

    }
}