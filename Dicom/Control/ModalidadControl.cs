using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
    class ModalidadControl
    {
        public static DataTable Listar()
        {
            const string sql = "SELECT modalidad.codigo_modalidad AS 'CODIGO MODALIDAD', modalidad.nombre AS 'NOMBRE DE LA MODALIDAD', modalidad.descripcion AS 'DESCRIPCION' FROM modalidad";
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

        public static int BuscarModalidad(string descripcion)
        {
            DataTable codigo_modalidad = new DataTable();
            string sql = "SELECT codigo_modalidad FROM modalidad WHERE descripcion = '" + descripcion + "'";

            try
            {
                codigo_modalidad = Conexion.Seleccionar(sql);

                if (codigo_modalidad.Rows.Count > 0)
                {
                    int codigo = Convert.ToInt32(codigo_modalidad.Rows[0][0]);
                    return codigo;
                }
                else
                {
                    Consola.Imprimir("No existe descripción de la modalidad en la base de datos");
                    return -1;
                }

            }
            catch (Exception e)
            {
                Consola.Imprimir("Ha ocurrido una excepción " + e.Message);
                return -1;
            }
        }
    }
}
