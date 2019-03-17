using Dicom.Control;
using Dicom.Entidades;
using Dicom.HL7;
using System;
using System.Collections;
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
    public partial class FrmPrincipal : Form
    {
        private Fichero fichero;

        public FrmPrincipal()
        {
            InitializeComponent();
            fichero = new Fichero();
        }

        private void btnPacienteSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgvAgendamiento.SelectedRows.Count == 1)
            {
                FrmPaciente frmPaciente = new FrmPaciente();
                PacienteControl pacienteControl = new PacienteControl();

                int codigoPaciente = (int) dgvAgendamiento.SelectedCells[1].Value;
                Paciente paciente = pacienteControl.BuscarPaciente(codigoPaciente);

                frmPaciente.RellenarDatos(paciente);
                frmPaciente.Show();

            }
            else
            {
                MessageBox.Show("Debe seleccionar solamente una fila.", "¡Error!");
            }
        }

        private void btnSeleccionarModalidad_Click(object sender, EventArgs e)
        {
            if (dgvModalidades.SelectedRows.Count == 1)
            {
                FrmModalidad frmModalidad = new FrmModalidad();
                frmModalidad.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar solamente una fila.", "Error");
            }
        }

        public void InsertarPaciente()
        {
            PacienteControl pacienteControl = new PacienteControl();

            LectorHL7 lector = new LectorHL7();
            List<Hashtable> lista = lector.LeerMensaje("");
            Hashtable PID = new Hashtable();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ContainsKey(DefinicionSegmento.PID[3]))
                {
                    PID = lista[i];
                    break;
                }
            }

            if (!pacienteControl.VerificarPacienteExistente(PID))
            {
                pacienteControl.Insertar(PID);
            }
            else
            {
                Consola.Imprimir(MensajeACK.GenerarMensaje("AR", lista[0]));
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DataTable modalidades = ModalidadControl.Listar();
            dgvModalidades.DataSource = modalidades;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = monthCalendar1.SelectionRange.Start.ToString("s");

            dgvAgendamiento.DataSource = EstudioControl.BuscarEstudiosEnFecha(fecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvAgendamiento.DataSource = EstudioControl.BuscarEstudios();
        }
    }
}
