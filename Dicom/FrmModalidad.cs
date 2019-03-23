using Dicom.Control;
using Dicom.Entidades;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
                Paciente paciente = new Paciente(1,"Angel", "Zenteno", "Urquidi", "Masculino", "JKFSAFJKASBF", DateTime.Today, "SDAS", "1521");
                Modalidad modalidad = new Modalidad(2,"Tomografo", "");
                Estudio estudio = new Estudio(2, 3, true, true, DateTime.Now, DateTime.Now);

                //GeneradorArchivoDicom.GenerarArchivo("prueba.dcm",paciente, modalidad, estudio);
            
        }
    }
}
