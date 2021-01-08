using NomiCamp.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomiCamp.Views
{
	public partial class formReportes : Form
	{
		List<Archivos> listaArchivos = new List<Archivos>();
		public formReportes(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
			listaArchivos = Archivos.GetArchivos();
		}

		private void formReportes_Load(object sender, EventArgs e)
		{
			dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvReportes.Size = new Size(this.Width - 40, this.Height - 100);
			dgvReportes.Location = new Point(20, 50);
			btnActualizar.Location = new Point(20, this.Size.Height - 40);
			listaArchivos = Archivos.GetArchivos();
			ActualizarLista();
		}

		public void ActualizarLista()
		{
			dgvReportes.Rows.Clear();
			dgvReportes.Refresh();
			ArrayList row;
			foreach (var ar in listaArchivos)
			{
				row = new ArrayList();
				row.Add(ar.Nombre);
				dgvReportes.Rows.Add(row.ToArray());
			}

		}


		private void btnActualizar_Click(object sender, EventArgs e)
		{
			listaArchivos = Archivos.GetArchivos();
			ActualizarLista();
		}

		private void dgvReportes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow datos = dgvReportes.Rows[e.RowIndex];
			string path = datos.Cells["Archivo"].Value.ToString();
			Process.Start(path);

		}
	}
}
