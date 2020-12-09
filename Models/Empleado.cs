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
					using (MySqlCommand cmd = new MySqlCommand("insert_empleado", con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@_no_control", NoEmpleado.ToUpper().Trim());
						cmd.Parameters.AddWithValue("@_nombre", Nombre.ToUpper().Trim());
						cmd.Parameters.AddWithValue("@_puesto", Puesto.ToUpper().Trim());
						cmd.Parameters.AddWithValue("@_salario_diario", SalarioXDia);

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
