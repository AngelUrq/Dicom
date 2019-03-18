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
    public partial class FrmPaciente : Form
    {
        private int codigo_modalidad;

        public FrmPaciente()
        {
            InitializeComponent();
            codigo_modalidad = 0;
        }

        public void RellenarDatos(Paciente paciente, Estudio estudio, Modalidad modalidad)
        {
            txtNombres.Text = paciente.Nombres;
            txtApellidoPaterno.Text = paciente.Apellido_Paterno;
            txtApellidoMaterno.Text = paciente.Apellido_Materno;
            txtGenero.Text = paciente.Genero;
            dateTimePicker1.Text = paciente.Fecha_Nacimiento.ToShortDateString();
            txtCodigoPais.Text = paciente.Codigo_Pais;
            txtTelefono.Text = paciente.Telefono;
            txtDireccion.Text = paciente.Direccion;
            txtEstudio.Text = modalidad.Nombre;
            dateTimePicker2.Text = estudio.FechaInicio.ToShortDateString();
            codigo_modalidad = estudio.CodigoEstudio;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstudioControl.BorrarAgendamiento(codigo_modalidad.ToString());
            Close();
        }

        private void btnAdmitir_Click(object sender, EventArgs e)
        {
            EstudioControl.AdmitirPaciente(codigo_modalidad.ToString());
            Close();
        }
    }
}
