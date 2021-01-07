using NomiCamp.Excel;
using System;
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
			dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvReportes.Size = new Size(this.Width - 40, this.Height - 100);
			dgvReportes.Location = new Point(20, 50);

			dgvReportes.DataSource = Archivo.GetArchivos();
		}
	}
}
