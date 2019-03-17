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
            const string sql = "SELECT * FROM modalidad";
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

    }
}
