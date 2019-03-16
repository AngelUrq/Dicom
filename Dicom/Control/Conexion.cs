using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Control
{
	class Conexion
	{
		//metodo para buscar en la base de datos 
		public static DataTable Seleccionar(string sql)
		{
			
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
		public static void Ejecutar(string sql)
		{
			
			DataTable dataTable = new DataTable();
			MySqlConnection connection;
			string connectionString = "SERVER= localhost; DATABASE=db_agendamiento; UID= root ;PASSWORD=  ;";
			connection = new MySqlConnection(connectionString);
			connection.Open();

			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.ExecuteNonQuery();


			connection.Close();
			
		}
	}
}
