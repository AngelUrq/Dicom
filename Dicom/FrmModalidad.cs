using Dicom.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom
{
    public partial class FrmModalidad : Form
    {
        private int codigoModalidad;

        public FrmModalidad()
        {
            InitializeComponent();
        }

        public void CambiarCodigoModalidad(int codigoModalidad)
        {
            this.codigoModalidad = codigoModalidad;
            MostrarAgenda();
        }

        private void MostrarAgenda()
        {
            dgvAgendamiento.DataSource = EstudioControl.BuscarEstudiosPorModalidad(codigoModalidad);
        }

        private void btnListarSolicitudes_Click(object sender, EventArgs e)
        {
            dgvAgendamiento.DataSource = EstudioControl.BuscarEstudiosPorModalidad(codigoModalidad);
        }

        private void btnSeleccionarFechaModalidad_Click(object sender, EventArgs e)
        {
            dgvAgendamiento.DataSource = EstudioControl.SeleccionarEstudiosPorFechaYModalidad(codigoModalidad, monthCalendar1.SelectionRange.Start.ToString("s"));
        }
    }
}
