using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;

namespace NomiCamp.Models
{
	public class Empleado
	{
		public string NoEmpleado { get; set; }
		public string Nombre { get; set; }
		public string Puesto { get; set; }
		public float SalarioXDia { get; set; }


		string constr = Connection.ConnectionString;
		public Empleado()
		{

		}

		public int Insert()
		{


			try
			{
				using (MySqlConnection con = new MySqlConnection(constr))
				{
					string script = string.Format($"INSERT INTO informacion_empleados values(" +
						$"'{NoEmpleado}','{Nombre}','{Puesto}',{SalarioXDia})");
					using (MySqlCommand cmd = new MySqlCommand(script, con))
					{
						con.Open();
						return cmd.ExecuteNonQuery();
					}
				}
			} catch(Exception e)
			{
				Console.WriteLine(e.Message);
				return 0;
			}
		}


	}
}
