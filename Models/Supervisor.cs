using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Models
{
	class Supervisor
	{
		public string IdSupervisor { get; set; }
		public string NoEmpleado { get; set; }

		public static List<Supervisor> GetSupervisores()
		{
			List<Supervisor> lista = new List<Supervisor>();
			string query = "select * from supervisores";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Supervisor
				{
					IdSupervisor = Convert.ToString(reader["id_supervisor"])
				});
			}
			reader.Close();
			return lista;
		}
	}
}
