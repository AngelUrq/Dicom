using Dicom.Entidades;
using System;
using System.Collections.Generic;
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

    }
}