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
	public partial class formRanchos : Form
	{
		public formRanchos(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formRanchos_Load(object sender, EventArgs e)
		{
			dgvInfoRanchos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvInfoRanchos.Size = new Size(this.Width - 40, this.Height - 200);
			dgvInfoRanchos.Location = new Point(20, 150);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			btnAdminRanchos.Location = new Point(this.Width - 170, 50);
			label1.Location = new Point(this.Width - 220, 95);
			btnActualizar.Location = new Point(20, this.Size.Height - 40);
			ActualizarTabla();
		}

		private void btnAdminRanchos_Click(object sender, EventArgs e)
		{
			formAdministrarRanchos fr = new formAdministrarRanchos();
			fr.Show();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ActualizarTabla();
		}

		public void ActualizarTabla()
		{
			dgvInfoRanchos.Rows.Clear();
			dgvInfoRanchos.Refresh();

			ArrayList row;
			foreach (var r in Rancho.GetRanchos())
			{
				row = new ArrayList();
				row.Add(r.Codigo);
				row.Add(r.Hectareas);
				row.Add(r.TipoVarietal);
				row.Add(r.TablaVarietal);
				row.Add(r.IdSupervisor);
				dgvInfoRanchos.Rows.Add(row.ToArray());
			}
		}
	}
}
