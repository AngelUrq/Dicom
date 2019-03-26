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
		/// <summary>
        /// Seleccionar en la base de datos
        /// </summary>
        /// <param name="sql">Consulta</param>
        /// <returns></returns>
		public static DataTable Seleccionar(string sql)
		{
            Consola.Imprimir("Ejecutando consulta: " + sql);
            DataTable dataTable = new DataTable();
			MySqlConnection connection;
			string connectionString = "SERVER= localhost; DATABASE=db_agendamiento; UID= root ;PASSWORD=  ; Convert Zero Datetime=True";
			connection = new MySqlConnection(connectionString);
			connection.Open();

			MySqlCommand cmd = new MySqlCommand(sql, connection);
			MySqlDataReader rdr = cmd.ExecuteReader();
			dataTable.Load(rdr);
			connection.Close();
			return dataTable;
		}

		/// <summary>
        /// Ejecutar en la base de datos
        /// </summary>
        /// <param name="sql">Consulta</param>
		public static void Ejecutar(string sql)
		{
            Consola.Imprimir("Ejecutando consulta: " + sql);
            DataTable dataTable = new DataTable();
			MySqlConnection connection;
			string connectionString = "SERVER= localhost; DATABASE=db_agendamiento; UID= root ;PASSWORD=  ; Convert Zero Datetime=True";
			connection = new MySqlConnection(connectionString);
			connection.Open();

			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.ExecuteNonQuery();


			connection.Close();
			
		}
	}
}
