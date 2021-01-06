using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NomiCamp.Models
{
	class Conexion
	{ 
		private static string cadena= "datasource=127.0.0.1;port=3306;username=root;password=;database=nomicamp;"; 
		public static MySqlConnection get()
		{
			var cn = new MySqlConnection(cadena);
			cn.Open();
			return cn;
		}



	}
}
