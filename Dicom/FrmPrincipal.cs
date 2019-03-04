using Dicom.HL7;
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
    public partial class FrmPrincipal : Form
    {
        private Fichero fichero;

        public FrmPrincipal()
        {
            InitializeComponent();
            fichero = new Fichero();
            
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
            LectorHL7.LeerMensaje(txtMensaje.Text);
            MessageBox.Show("¡Admisión exitosa!", "Importante");
        }
    }
}
