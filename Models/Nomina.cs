using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Models
{
	class Nomina 
	{
		public string IdNomina { get; set; }
		public Empleado Empleado { get; set; }
		public Rancho Rancho { get; set; }
		public Actividad Actividad { get; set; }
		public float Cantidad { get; set; }
		public string Fecha { get; set; }
		public int Asistencia { get; set; }
		public float Extras { get; set; }

		public bool Insert()
		{
			string query = $"insert into nominas values ('{IdNomina}','{Empleado.NoEmpleado}','{Rancho.Codigo}','{Actividad.Codigo}','{Fecha}',{Asistencia})";
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

		public static Nomina Select(string idNomina)
		{

			string query = $"select * from nominas where id_nomina= {idNomina}";
			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				var reader = cmd.ExecuteReader();

				var res = new Nomina();
				while (reader.Read())
				{
					res.IdNomina = Convert.ToString(reader["no_empleado"]);
					res.Empleado = Empleado.Select(Convert.ToString(reader["no_empleado"]));
					res.Rancho = Rancho.Select(Convert.ToString(reader["codigo_rancho"]));
					res.Actividad = Actividad.Select(Convert.ToString(reader["id_actividad"]));
					res.Cantidad = float.Parse(Convert.ToString(reader["cantidad_laboradas"]));
					res.Fecha = Convert.ToString(reader["fecha"]);
					res.Asistencia = int.Parse(Convert.ToString(reader["asistencia"]));
					res.Extras = float.Parse(Convert.ToString(reader["extras"]));
				}
				reader.Close();
				return res;
			}
			catch (Exception e)
			{
				return null;
			}
			
		}
		public static List<Nomina> GetNominas(string fecha)
		{
			List<Nomina> lista = new List<Nomina>();
			string query = $"select * from nominas where fecha={fecha}";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			//readrer = ["id_info_empleado":"1234","no_empleado":222,3242saa,saas,2,44/55/66,1]
			while (reader.Read())
			{
				lista.Add(new Nomina
				{
					IdNomina = Convert.ToString(reader["id_nomina"]), 
					Empleado=Empleado.Select(Convert.ToString(reader["no_empleado"])),
					
				});
			}
			reader.Close();
			return lista;
		}

	}
}
