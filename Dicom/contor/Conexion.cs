using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom.Control
{
	class Conexion
	{
		
		
		//metodo para buscar en la base de datos 
		public DataTable Seleccionar(string sql)
		{
			Console.WriteLine("Connecting to MySQL...");
			DataTable dataTable = new DataTable();
			MySqlConnection connection;
			string connectionString = "SERVER= localhost; DATABASE=db_agendamiento; UID= root ;PASSWORD=  ;";
			connection = new MySqlConnection(connectionString);
			connection.Open();
											
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			MySqlDataReader rdr = cmd.ExecuteReader();									
			dataTable.Load(rdr);
			connection.Close();
			return dataTable;	
									
		}
		//método para ejecutar una order sql en la base de datos
		public void Ejecutar(string sql)
		{
			Console.WriteLine("Connecting to MySQL...");
			DataTable dataTable = new DataTable();
			MySqlConnection connection;
			string connectionString = "SERVER= localhost; DATABASE=db_agendamiento; UID= root ;PASSWORD=  ;";
			connection = new MySqlConnection(connectionString);
			connection.Open();
			
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.ExecuteNonQuery();		
			

			connection.Close();
			Console.WriteLine("Done.");
		}
	}
}
