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

namespace nomicamp_seleccion
{
	public partial class Form1 : Form
	{
		List<EmpleadoDispo> listaEmpleados = new List<EmpleadoDispo>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
			this.Location = new Point(0, 0);
			panel1.Size = new Size(this.Size.Width+3, 40);
			btnCerrar.Location = new Point(panel1.Size.Width - 43, 2);
			btnMinimizar.Location = new Point(panel1.Size.Width - 86, 2);
			this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
			lblTitulo.Location = new Point(panel1.Size.Width / 2 - 50, 10);
			btnCargarLista.Location = new Point(this.Size.Width / 2 - 63, this.Size.Height - 40);

			dgvSelEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSelEmpleados.Size = new Size(this.Width - 40, this.Height - 200);
			dgvSelEmpleados.Location = new Point(20, 120);

			label2.Location = new Point(20, 50);
			txtNoEmpleado.Location = new Point(20, 80);
			btnBuscar.Location = new Point(175, 80);

			listaEmpleados = EmpleadoDispo.LlenarLista();
			ActualizarTabla();

		}
		public void ActualizarTabla()
		{
			dgvSelEmpleados.Rows.Clear();
			dgvSelEmpleados.Refresh();

			ArrayList row;
			foreach (var emp in listaEmpleados)
			{
				row = new ArrayList();
				row.Add(emp.NoEmpleado);
				row.Add(emp.Nombre);
				row.Add(emp.Puesto);
				dgvSelEmpleados.Rows.Add(row.ToArray());
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnCargarLista_Click(object sender, EventArgs e)
		{

		}
	}
}
