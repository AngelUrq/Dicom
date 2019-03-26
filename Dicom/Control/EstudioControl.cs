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
        /// <summary>
        /// Insertar un estudio
        /// </summary>
        /// <param name="estudio">Datos del estudio</param>
        public static void Insertar(Estudio estudio)
        {

            if (VerificarHorario(estudio))
            {
                string SQL = "INSERT INTO estudio(codigo_paciente,codigo_modalidad,numero_acceso,medico_referencia,medico_ejercicio,cancelado,admitido,fecha_inicio,fecha_fin) VALUES('" + estudio.CodigoPaciente + "','" + estudio.CodigoModalidad + "','" + estudio.NumeroDeAcceso + "','" + estudio.MedicoDeReferencia + "','" + estudio.MedicoDeEjercicio + "'," + estudio.Cancelado + "," + estudio.Admitido + ",'" + estudio.FechaInicio.ToString("s") + "','" + estudio.FechaFin.ToString("s") + "')";

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

        /// <summary>
        /// Verificar si el horario está disponible
        /// </summary>
        /// <param name="estudio">Datos del estudio</param>
        /// <returns></returns>
        public static bool VerificarHorario(Estudio estudio)
        {
            string SQL = "SELECT * FROM estudio WHERE ((estudio.fecha_inicio BETWEEN '" + estudio.FechaInicio.ToString("s") + "' AND '" + estudio.FechaFin.ToString("s") + "') OR (estudio.fecha_fin BETWEEN '" + estudio.FechaInicio.ToString("s") + "' AND '" + estudio.FechaFin.ToString("s") + "')) AND estudio.codigo_modalidad = " + estudio.CodigoModalidad;

            try
            {
                DataTable consulta = Conexion.Seleccionar(SQL);

                if (consulta.Rows.Count == 0)
                {
                    Consola.Imprimir("El horario es aceptado.");
                    return true;
                }
            }
            catch (Exception e)
            {
                Consola.Imprimir(e.ToString());
                MessageBox.Show("Error al consultar en la base de datos");
            }

            Consola.Imprimir("El horario no fue aceptado.");
            return false;
        }

        /// <summary>
        /// Buscar estudios
        /// </summary>
        /// <returns>Tabla resultado de la consulta</returns>
        public static DataTable BuscarEstudios()
        {
            string SQL = "SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', paciente.fecha_nacimiento as 'FECHA DE NACIMIENTO', modalidad.nombre AS 'MODALIDAD', modalidad.descripcion AS 'DESCRIPCION', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO', estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM paciente INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad WHERE estudio.admitido = '0' AND estudio.cancelado = '0'";

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

        /// <summary>
        /// Buscar estudios en una fecha determinada
        /// </summary>
        /// <param name="fecha">Fecha</param>
        /// <param name="admitido">Si el paciente está admitido</param>
        /// <param name="cancelado">Si el paciente ha sido cancelado</param>
        /// <returns></returns>
        public static DataTable BuscarEstudiosEnFecha(string fecha, int admitido, int cancelado)
        {
            string SQL = @"SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', paciente.fecha_nacimiento as 'FECHA DE NACIMIENTO', modalidad.nombre AS 'MODALIDAD', modalidad.descripcion AS 'DESCRIPCION', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO', estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM paciente 
                           INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente 
                           INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad 
                           WHERE CAST(fecha_inicio AS DATE) = CAST('" + fecha + "' AS DATE) AND estudio.admitido = '"+ admitido +"' AND estudio.cancelado = '" + cancelado + "'";

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

        /// <summary>
        /// Buscar estudios asignados a una modalidad
        /// </summary>
        /// <param name="codigo">Código de la modalidad</param>
        /// <returns></returns>
        public static DataTable BuscarEstudiosPorModalidad(int codigo)
        {
            string fecha = DateTime.Now.ToString("s");
            string sql = @"
                SELECT paciente.codigo_paciente as 'CODIGO PACIENTE', paciente.nombres AS 'NOMBRES',paciente.apellido_paterno AS 'APELLIDO PATERNO',paciente.apellido_materno AS 'APELLIDO MATERNO', paciente.genero as 'GENERO', paciente.fecha_nacimiento as 'FECHA DE NACIMIENTO', modalidad.nombre AS 'MODALIDAD', modalidad.descripcion AS 'DESCRIPCION', estudio.numero_acceso AS 'ACCESSION NUMBER', estudio.codigo_estudio AS 'CODIGO ESTUDIO', estudio.fecha_inicio AS 'FECHA INICIO',estudio.fecha_fin AS 'FECHA FIN', estudio.medico_referencia AS 'MEDICO DE REFERENCIA', estudio.medico_ejercicio AS 'MEDICO DE EJERCICIO', estudio.admitido AS 'ADMITIDO',estudio.cancelado AS 'CANCELADO' FROM estudio
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
        
        /// <summary>
        /// Actualiza el agendamiento a cancelado
        /// </summary>
        /// <param name="codigoEstudio">Código del estudio</param>
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

        /// <summary>
        /// Seleccionar estudios para una fecha y una modalidad determinada
        /// </summary>
        /// <param name="codigoModalidad">Código de la modalidad</param>
        /// <param name="fechaSeleccionada">Fecha seleccionada</param>
        /// <returns></returns>
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

        /// <summary>
        /// Actualiza el estudio del paciente a admitido
        /// </summary>
        /// <param name="codigoEstudio">Código del estudio</param>
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