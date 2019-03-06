using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dicom.database
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
			 SqlConnection connection;
		 string server;
		 string database;
	     string uid;
		 string password;
		server = "192.168.0.19";
			database = "database_dicom";
			uid = "admin";
			password = "admin";
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" +
			database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

			connection = new SqlConnection(connectionString);
			MessageBox.Show("succes");
		}
	}
}
