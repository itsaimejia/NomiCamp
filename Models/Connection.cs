using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Models
{
	class Connection
	{
		private static string connectionString = "Server=127.0.0.1;Database=nomicamp; Uid=root;Pwd=;";

		public static string ConnectionString
		{
			get { return connectionString; }
		}
	}
}
