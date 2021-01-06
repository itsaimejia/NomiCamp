using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Models
{
	class Rancho
	{
		public string Codigo { get; set; }
		public float Hectareas { get; set; }
		public int TipoVarietal { get; set; }
		public int TablaVarietal { get; set; }
		public string IdSupervisor { get; set; }

		public bool Insert()
		{

			string query = $"insert into ranchos values ('{Codigo}',{Hectareas},{TipoVarietal},{TablaVarietal},'{IdSupervisor}')";
			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}



		public static List<Rancho> GetRanchos()
		{

			List<Rancho> lista = new List<Rancho>();
			string query = "select * from ranchos";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Rancho
				{
					Codigo = Convert.ToString(reader["codigo_rancho"]),
					Hectareas = float.Parse(Convert.ToString(reader["hectareas"])),
					TipoVarietal = int.Parse(Convert.ToString(reader["tipo_varietal"])),
					TablaVarietal = int.Parse(Convert.ToString(reader["tabla_varietal"])),
					IdSupervisor=Convert.ToString(reader["id_supervisor"])
				});
			}
			reader.Close();
			return lista;
		}

	}
}
