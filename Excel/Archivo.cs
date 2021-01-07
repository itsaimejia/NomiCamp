using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiCamp.Excel
{
	class Archivo
	{
		public string Nombre { get; set; }

		public static List<Archivo> GetArchivos()
		{
           string[] files = System.IO.Directory.GetFiles(@"C:\Archivos Excel\");
           var lista = new List<Archivo>();
            foreach (string item in files)
            {
                lista.Add(new Archivo()
                {
                    Nombre = item
                });
            }

            return lista;
        }
	}
}
