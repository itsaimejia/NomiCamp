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
		public formReportes(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formReportes_Load(object sender, EventArgs e)
		{
			dgvReportes.Size = new Size(this.Width - 40, this.Height - 100);
			dgvReportes.Location = new Point(20, 50);
			ActualizarLista();
		}

		public void ActualizarLista()
		{
			dgvReportes.Rows.Clear();
			dgvReportes.Refresh();
			ArrayList row;
			foreach (var ar in Archivos.GetArchivos())
			{
				row = new ArrayList();
				row.Add(ar.Nombre);
				dgvReportes.Rows.Add(row.ToArray());
			}

		}

		private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvReportes.Columns[e.ColumnIndex].Name.Equals("Abrir"))
			{
				DataGridViewRow datos = dgvReportes.Rows[e.RowIndex];
				string path = datos.Cells["Archivo"].Value.ToString();
				Process.Start(path);
			}
		}
	}
}
