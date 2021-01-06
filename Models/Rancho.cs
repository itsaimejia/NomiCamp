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

			string query = $"insert into empleados values ('{Codigo}',{Hectareas},{TipoVarietal},{TablaVarietal},'{IdSupervisor}')";
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

	}
}
