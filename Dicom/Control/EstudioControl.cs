using Dicom.Entidades;
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
                string SQL = "INSERT INTO estudio(codigo_paciente,codigo_modalidad,cancelado,fecha_inicio,fecha_fin) VALUES('" + estudio.CodigoPaciente + "','" + estudio.CodigoModalidad + "'," + estudio.Cancelado + ",'" + estudio.FechaInicio.ToString("s") + "','" + estudio.FechaFin.ToString("s") + "')";

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
            string SQL = "SELECT * FROM estudio";

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
            string SQL = @"SELECT paciente.nombres as 'Nombres',paciente.apellido_paterno as 'Apellido paterno',paciente.apellido_materno as 'Apellido materno',paciente.genero as 'Género',estudio.fecha_inicio as 'Fecha inicio',estudio.fecha_fin as 'Fecha fin',modalidad.nombre as 'Estudio' FROM paciente 
                           INNER JOIN estudio ON paciente.codigo_paciente = estudio.codigo_paciente 
                           INNER JOIN modalidad ON estudio.codigo_modalidad = modalidad.codigo_modalidad 
                            WHERE CAST(fecha_inicio AS DATE) = CAST('"+ fecha +"' AS DATE)";

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

    }
}