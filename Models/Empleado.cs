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


		public Empleado()
		{

		}


	}
}
