using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NomiCamp.Models
{
	public class Empleado
	{
		public string NoEmpleado { get; set; }
		public string Nombre { get; set; }
		public string Puesto { get; set; }
		public float SalarioXDia { get; set; }


		public Empleado()
		{

		}

		public bool Insert()
		{
			string query = $"insert into empleados values ('{NoEmpleado}','{Nombre}','{Puesto}',{SalarioXDia})";
			try
			{
				var cmd = new MySqlCommand(query,Conexion.get());
				cmd.ExecuteNonQuery();
				return true;
			}catch(Exception e)
			{
				return false;
			}
		}

		public static Empleado Select(string noEmpleado)
		{
			string query = $"select * from empleados where no_empleado= {noEmpleado}";
			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				var reader = cmd.ExecuteReader();

				var res = new Empleado();
				while (reader.Read())
				{
					res.NoEmpleado = Convert.ToString(reader["no_empleado"]);
					res.Nombre = Convert.ToString(reader["nombre"]);
					res.Puesto = Convert.ToString(reader["puesto"]);
					res.SalarioXDia = float.Parse(Convert.ToString(reader["salario_diario"]));
				}
				reader.Close();
				return res;
			}
			catch(Exception e)
			{
				return null;
			}
		}


		public bool Delete()
		{
			string query = $"delete from empleados where no_empleado='{NoEmpleado}'";
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

		public bool Update()
		{
			string query = $"update empleados set nombre='{Nombre}', puesto='{Puesto}', salario_diario={SalarioXDia} where no_empleado='{NoEmpleado}'";
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
		public static List<Empleado> GetEmpleados()
		{ 

			List<Empleado> lista = new List<Empleado>();
			string query = "select * from empleados where not puesto = 'supervisor'";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Empleado
				{
					NoEmpleado = Convert.ToString(reader["no_empleado"]),
					Nombre = Convert.ToString(reader["nombre"]),
					Puesto = Convert.ToString(reader["puesto"]),
					SalarioXDia=float.Parse(Convert.ToString(reader["salario_diario"]))
				});
			}
			reader.Close();
			return lista;
		}

	}
}
