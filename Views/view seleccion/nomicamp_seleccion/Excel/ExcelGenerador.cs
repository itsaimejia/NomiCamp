using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomiCamp.Models;
using SpreadsheetLight;

namespace NomiCamp.Excel
{
	class ExcelGenerador
	{
		public string Nombre { get; set; }
		public ExcelGenerador()
		{
			string ruta = @"C:\Archivos Excel";
			if (!Directory.Exists(ruta))
			{
				DirectoryInfo di = Directory.CreateDirectory(ruta);
			}
		}
		public void ReporteEmpleados(List<Empleado> list)
		{
			string path = $"{@"C:\Archivos Excel\"}{Nombre}.xlsx";

			SLDocument doc = new SLDocument();

			DataTable dt = new DataTable();

			dt.Columns.Add("No Empleado", typeof(string));
			dt.Columns.Add("Nombre", typeof(string));
			dt.Columns.Add("Puesto", typeof(string));
			dt.Columns.Add("Salario", typeof(float));

			foreach (var l in list)
			{
				dt.Rows.Add(l.NoEmpleado, l.Nombre, l.Puesto, l.SalarioXDia);
			}

			doc.ImportDataTable(1, 1, dt, true);

			doc.SaveAs(path);
			Process.Start(path);

		}

	}
}
