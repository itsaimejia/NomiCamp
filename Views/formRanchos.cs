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
			dvInfoRanchos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dvInfoRanchos.Size = new Size(this.Width - 40, this.Height - 200);
			dvInfoRanchos.Location = new Point(20, 150);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			btnAdminRanchos.Location = new Point(this.Width - 170, 50);
			label1.Location = new Point(this.Width - 220, 95);
			btnActualizar.Location = new Point(20, this.Size.Height - 40);
		}

		private void btnAdminRanchos_Click(object sender, EventArgs e)
		{
			formAdministrarRanchos fr = new formAdministrarRanchos();
			fr.Show();
		}
	}
}
