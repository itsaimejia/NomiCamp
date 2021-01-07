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
	public class EmpleadoDispo: Empleado
	{
		public string Fecha { get; set; }
		public int Disponible { get; set; }


		public EmpleadoDispo()
		{

		}

		public void Insert()
		{
			if (Consultar() != 1)
			{
				string query = $"insert into emp_disponibles values ('{Fecha}','{NoEmpleado}',{Disponible})";
				try
				{
					var cmd = new MySqlCommand(query, Conexion.get());
					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
				}
			}
		}


		public int Consultar()
		{
			string query = $"select * from emp_disponibles where no_empleado='{NoEmpleado}'";

			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				return cmd.ExecuteNonQuery();
			}catch(Exception e)
			{
				return 0;
			}
		}

		

		
		public static List<EmpleadoDispo> GetEmpleados()
		{ 

			List<EmpleadoDispo> lista = new List<EmpleadoDispo>();
			string query = "select * from empleados where not puesto= 'supervisor'";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				var ed = new EmpleadoDispo()
				{
					Fecha = DateTime.Today.ToString("dd/MM/yyyy"),
					NoEmpleado = Convert.ToString(reader["no_empleado"]),
					Nombre = Convert.ToString(reader["nombre"]),
					Puesto=Convert.ToString(reader["puesto"]),
					Disponible = 1
				};
				ed.Insert();
				lista.Add(ed);
			}
			reader.Close();

			return lista;
		}

	}
}
