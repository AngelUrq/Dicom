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
        public FrmPaciente()
        {
            InitializeComponent();
        }

        public void RellenarDatos(Paciente paciente)
        {
            txtNombres.Text = paciente.Nombres;
            txtApellidoPaterno.Text = paciente.Apellido_Paterno;
            txtApellidoMaterno.Text = paciente.Apellido_Materno;
            txtGenero.Text = paciente.Genero;
            dateTimePicker1.Text = paciente.Fecha_Nacimiento.ToShortDateString();
            txtCodigoPais.Text = paciente.Codigo_Pais;
            txtTelefono.Text = paciente.Telefono;
            txtDireccion.Text = paciente.Direccion;
            
        }
    }
}
