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
			if (!Existe())
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


		public bool Existe()
		{
			bool e = false;
			string aux = "";
			string query = $"select * from emp_disponibles where fecha='{Fecha}' and no_empleado='{NoEmpleado}'";

			try
			{
				var cmd = new MySqlCommand(query, Conexion.get());
				var reader= cmd.ExecuteReader();

				var res = new Empleado();
				while (reader.Read())
				{
					aux = Convert.ToString(reader["no_empleado"]);
				}
				e = (aux == string.Empty) ? false : true;
				reader.Close();

			}
			catch(Exception )
			{
				
			}
			return e;
		}

		

		
		public void LlenarTabla()
		{ 

			
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
			}
			reader.Close();
		}

		public static List<EmpleadoDispo> LlenarLista()
		{
			List<EmpleadoDispo> lista = new List<EmpleadoDispo>();
			string query = "select empleados.no_empleado, empleados.nombre, empleados.puesto " +
				"from empleados, emp_disponibles " +
				$"where not empleados.puesto='supervisor' and emp_disponibles.disponible = {1}";
			var cmd = new MySqlCommand(query, Conexion.get());
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				var ed = new EmpleadoDispo()
				{
					NoEmpleado = Convert.ToString(reader["no_empleado"]),
					Nombre = Convert.ToString(reader["nombre"]),
					Puesto = Convert.ToString(reader["puesto"]),
				};
				if (!lista.Exists(x => x.NoEmpleado == ed.NoEmpleado))
					lista.Add(ed);

			}
			reader.Close();

			return lista;
		}
	}
}
