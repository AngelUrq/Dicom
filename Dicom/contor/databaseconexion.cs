using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Dicom.Control
{
    public partial class databaseconexion : Form
	{
		public databaseconexion()
		{
			InitializeComponent();
		}

		private void databaseconexion_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable DTable = new DataTable();
			Conexion c = new Conexion();
			DTable = c.Select("Select * from paciente");
			BindingSource SBind = new BindingSource();
			SBind.DataSource = DTable;
			
			sqlview.AutoGenerateColumns = false;
			sqlview.DataSource = DTable;

			sqlview.DataSource = SBind;
			sqlview.Refresh();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
