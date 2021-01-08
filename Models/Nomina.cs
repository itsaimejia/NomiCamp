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
		public string CodigoRancho { get; set; }
		public string CodigoActividad { get; set; }
		public float Cantidad { get; set; }
		public string Fecha { get; set; }
		public int Asistencia { get; set; }
		public float Extras { get; set; }

		public bool Insert()
		{
			string query = $"insert into nominas values ('{IdNomina}','{Empleado.NoEmpleado}','{CodigoRancho}','{CodigoActividad}','{Fecha}',{Asistencia})";
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
					res.IdNomina = Convert.ToString(reader["id_nomina"]);
					//res.NoEmpleado = Convert.ToString(reader["no_empleado"]);
					res.CodigoRancho = Convert.ToString(reader["codigo_rancho"]);
					res.CodigoActividad = Convert.ToString(reader["id_actividad"]);
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
		public static List<Nomina> GetNominas()
		{
			List<Nomina> lista = new List<Nomina>();
			string query = $"SELECT empleados.no_empleado, empleados.nombre, empleados.puesto, nominas.id_nomina" +
				$"FROM nominas " +
				$"INNER JOIN empleados " +
				$"ON nominas.no_empleado = empleados.no_empleado";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Nomina
				{
					IdNomina = Convert.ToString(reader["id_nomina"]),
					Empleado = new Empleado
					{
						NoEmpleado=Convert.ToString(reader["no_empleado"]),
						Nombre=Convert.ToString(reader["nombre"]),
						Puesto=Convert.ToString(reader["puesto"])
					}

				});
			}
			reader.Close();
			return lista;
		}

	}
}
