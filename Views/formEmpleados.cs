using NomiCamp.Excel;
using NomiCamp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomiCamp.Views
{
	public partial class formEmpleados : Form
	{
		private List<Empleado> listaEmpleados = new List<Empleado>();
		public formEmpleados(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formEmpleados_Load(object sender, EventArgs e)
		{

			dgvInfoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvInfoEmpleados.Size = new Size(this.Width - 40, this.Height - 200);
			dgvInfoEmpleados.Location = new Point(20, 150);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			btnAdminEmpleados.Location = new Point(this.Width - 170, 50);
			label1.Location = new Point(this.Width - 240, 95);
			btnActualizar.Location = new Point(20, this.Size.Height - 40);
			listaEmpleados = Empleado.GetEmpleados();
			ActualizarTabla();

		}
		public void ActualizarTabla()
		{
			dgvInfoEmpleados.Rows.Clear();
			dgvInfoEmpleados.Refresh();

			ArrayList row;
			foreach (var emp in listaEmpleados)
			{
				row = new ArrayList();
				row.Add(emp.NoEmpleado);
				row.Add(emp.Nombre);
				row.Add(emp.Puesto);
				row.Add(emp.SalarioXDia);
				dgvInfoEmpleados.Rows.Add(row.ToArray());
			}
		}
		

		private void btnAdminEmpleados_Click(object sender, EventArgs e)
		{
			var fr = new formAdministraEmpleado();
			fr.Show();
			
		}

		private void btnReporteExcel_Click(object sender, EventArgs e)
		{
			ExcelGenerador excel = new ExcelGenerador();
			excel.Nombre = DateTime.Today.ToString("dd/MM/yyyy").Replace("/",string.Empty) + "Empleados";
			excel.ReporteEmpleados(listaEmpleados);
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ActualizarTabla();
		}
	}
}
