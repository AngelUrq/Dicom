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
        private bool leido;
        private Fichero fichero;

        public FrmPrincipal()
        {
            InitializeComponent();
            fichero = new Fichero();
            leido = false;
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            string mensaje = fichero.Leer(@"C:\Users\Adriana Orellana\source\repos\Dicom\Dicom\HL7-ORM.txt");
            txtMensaje.Text = mensaje;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            string rutaArchivo = "";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = archivo.FileName;
                string mensaje = fichero.Leer(rutaArchivo);
                txtMensaje.Text = mensaje;
            }
        }

        private void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            if (!leido)
            {
                LectorHL7 lector = new LectorHL7();
                List<Hashtable> lista = lector.LeerMensaje(txtMensaje.Text);
                string mensaje = MensajeACK.GenerarMensaje("AA", lista[0]);
                MessageBox.Show("¡Admisión exitosa!", "Importante");
                  
                leido = true;
            }
            else
            {
                MessageBox.Show("El mensaje HL7 ya fue leido", "Advertencia");
            }
        }

        private void btnPacienteSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgvAgendamiento.SelectedRows.Count == 1)
            {
                FrmPaciente frmPaciente = new FrmPaciente();
                frmPaciente.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar solamente una fila.","¡Error!");
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
    }
}
