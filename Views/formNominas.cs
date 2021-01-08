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
	public partial class formNominas : Form
	{
		private List<Nomina> listNominas = new List<Nomina>();

		public formNominas(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formNominas_Load(object sender, EventArgs e)
		{
			dgvNominas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvNominas.Size = new Size(this.Width - 40, this.Height - 100);
			dgvNominas.Location = new Point(20, 50);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

			listNominas = Nomina.GetNominas(lblFecha.Text);
			ActualizarTabla();
		}

		public void ActualizarTabla()
		{
			dgvNominas.Rows.Clear();
			dgvNominas.Refresh();

			ArrayList row;
			foreach (var n in listNominas)
			{
				row = new ArrayList();
				row.Add(n.IdNomina);
				row.Add(n.Empleado.NoEmpleado);
				row.Add(n.Empleado.Nombre);
				row.Add(n.Empleado.Puesto);
				dgvNominas.Rows.Add(row.ToArray());
			}
		}

		private void btnReporteExcel_Click(object sender, EventArgs e)
		{

		}

		private void dvNominas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
