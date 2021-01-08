using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Excel
{
	class Archivos
	{
		public string Nombre { get; set; }

		public static List<Archivos> GetArchivos()
		{
           string[] files = System.IO.Directory.GetFiles(@"C:\Archivos Excel\");
           var lista = new List<Archivos>();
            foreach (string item in files)
            {
                lista.Add(new Archivos()
                {
                    Nombre = item
                });
            }

            return lista;
        }
	}
}
