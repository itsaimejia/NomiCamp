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
	public partial class formEmpleados : Form
	{

		public formEmpleados(int ancho, int alto)
		{
			InitializeComponent();
			this.Width = ancho;
			this.Height = alto;
		}

		private void formEmpleados_Load(object sender, EventArgs e)
		{
			
			dvInfoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dvInfoEmpleados.Size = new Size(this.Width - 40, this.Height - 200);
			dvInfoEmpleados.Location = new Point(20, 150);
			btnReporteExcel.Location = new Point(this.Width - 140, this.Size.Height - 40);
			btnAdminEmpleados.Location = new Point(this.Width - 170, 50);
			label1.Location = new Point(this.Width - 220, 95);
		}

		private void btnAdminEmpleados_Click(object sender, EventArgs e)
		{
			formAdministraEmpleado fr = new formAdministraEmpleado();
			fr.Show();
		}
	}
}
