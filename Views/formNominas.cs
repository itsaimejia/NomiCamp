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
	public partial class formNominas : Form
	{

		public formNominas(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formNominas_Load(object sender, EventArgs e)
		{
			dvNominas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dvNominas.Size = new Size(this.Width - 40, this.Height - 100);
			dvNominas.Location = new Point(20, 50);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");



		}

		private void btnReporteExcel_Click(object sender, EventArgs e)
		{

		}
	}
}
