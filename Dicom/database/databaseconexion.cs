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
		    MySqlConnection connection;
		    string server;
		    string database;
	        string uid;
		    string password;
		    server = "localhost";
		    database = "db_agendamiento";
		    uid = "root";
		    password = "";
		    string connectionString;
		    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

		    connection = new MySqlConnection(connectionString);
            connection.Open();
		    MessageBox.Show("succes");

		}
	}
}
