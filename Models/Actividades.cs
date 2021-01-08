using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Models
{
	public class Actividades
	{
		public string Codigo { get; set; }
		public string Nombre { get; set; }
		public string Tipo { get; set; }

		public Actividades()
		{

		}
		public static Actividades Select(string codigo)
		{
			string query = $"select * from actividades where id_actividad= '{codigo}'";
			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				var reader = cmd.ExecuteReader();

				var res = new Actividades();
				while (reader.Read())
				{
					res.Codigo = Convert.ToString(reader["id_actividad"]);
					res.Nombre = Convert.ToString(reader["nombre"]);
					res.Tipo = Convert.ToString(reader["tipo"]);
				}
				reader.Close();
				return res;
			}
			catch (Exception e)
			{
				return null;
			}
		}
	}
}
