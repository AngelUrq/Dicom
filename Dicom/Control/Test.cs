using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
	public partial class Test : Form
	{
		public Test()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			DataTable DTable = new DataTable();
			Conexion conexion = new Conexion();
			//DTable = conexion.Seleccionar("Select * from paciente");
			BindingSource SBind = new BindingSource();
			SBind.DataSource = DTable;

			sqlview.AutoGenerateColumns = false;
			sqlview.DataSource = DTable;

			sqlview.DataSource = SBind;
			sqlview.Refresh();

		}
	}
}
