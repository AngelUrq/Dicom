using Dicom.Control;
using Dicom.Entidades;
using Dicom.HL7;
using Dicom.Servicios;
using Dicom.WorklistSCP;
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
        public FrmPrincipal()
        {
            InitializeComponent();
            IniciarServidor();
            IniciarWorklist();
        }

        public void IniciarServidor()
        {
            Servidor servidor = new Servidor();
            servidor.Iniciar();
        }

        public void IniciarWorklist()
        {
            Worklist worklist = new Worklist(8005, "QRSCP");
        }

        private void btnPacienteSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgvAgendamiento.SelectedRows.Count == 1)
            {
                FrmPaciente frmPaciente = new FrmPaciente();
                PacienteControl pacienteControl = new PacienteControl();
                try
                {
                    int codigoPaciente = (int)dgvAgendamiento.SelectedCells[0].Value;
                    string fechaEstudio = monthCalendar1.SelectionRange.Start.ToString("s");
                    
                    Paciente paciente = PacienteControl.BuscarPaciente(codigoPaciente);
                    Estudio estudio = new Estudio(Convert.ToInt32(dgvAgendamiento.SelectedCells[7].Value), dgvAgendamiento.SelectedCells[6].Value.ToString(), dgvAgendamiento.SelectedCells[10].Value.ToString(), dgvAgendamiento.SelectedCells[11].Value.ToString(), Convert.ToDateTime(dgvAgendamiento.SelectedCells[8].Value));
                    Modalidad modalidad = new Modalidad(dgvAgendamiento.SelectedCells[5].Value.ToString());

                    frmPaciente.RellenarDatos(paciente, estudio, modalidad);
                    frmPaciente.Show();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Debe seleccionar un paciente.","¡Error!");
                    Consola.Imprimir(error.Message);
                }
               
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
                frmModalidad.CambiarCodigoModalidad((int)dgvModalidades.SelectedCells[0].Value);
                frmModalidad.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar solamente una fila.", "Error");
            }
        }

        public void InsertarPaciente()
        {
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

            if (!PacienteControl.VerificarPacienteExistente(PID))
            {
                PacienteControl.Insertar(PID);
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
