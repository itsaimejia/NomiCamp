using NomiCamp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomiCamp
{
	public partial class Canvas : Form
	{
		public Canvas()
		{
			InitializeComponent();
		}

		private void Canvas_Load(object sender, EventArgs e)
		{
			this.Location = new Point(0, 0); 
			this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
			panelMenu.Size = new Size(200, this.Size.Height);
			panelPrincipal.Size = new Size(this.Size.Width - 195,this.Size.Height - 35);
			panel1.Size = new Size(this.Size.Width - 195, 40);
			btnCerrar.Location = new Point(panel1.Size.Width-43, 2);
			btnMinimizar.Location = new Point(panel1.Size.Width - 86, 2);
			linkAdministrar.Location = new Point(12, panelMenu.Size.Height - 35);

			Form frm = panelPrincipal.Controls.OfType<Form>().Where(o => o.Name.Contains("formEmpleados")).FirstOrDefault();
			if (frm == null)
			{
				panelPrincipal.Controls.Clear();
				var form = Application.OpenForms.OfType<formEmpleados>().FirstOrDefault();
				var reg = form ?? new formEmpleados(panelPrincipal.Width, panelPrincipal.Height);
				FillCanvas(reg);
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnPanelEmpleados_Click(object sender, EventArgs e)
		{
			Form frm = panelPrincipal.Controls.OfType<Form>().Where(o => o.Name.Contains("formEmpleados")).FirstOrDefault();
			if (frm == null)
			{
				panelPrincipal.Controls.Clear();
				var form = Application.OpenForms.OfType<formEmpleados>().FirstOrDefault();
				var reg = form ?? new formEmpleados(panelPrincipal.Width, panelPrincipal.Height);
				FillCanvas(reg);
			}
			
		}

		private void FillCanvas(Form fh)
		{
			if (panelPrincipal.Controls.Count > 0)
				panelPrincipal.Controls.RemoveAt(0);
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			panelPrincipal.Controls.Add(fh);
			panelPrincipal.Tag = fh;
			fh.Show();
		}

		private void btnPanelRanchos_Click(object sender, EventArgs e)
		{
			Form frm = panelPrincipal.Controls.OfType<Form>().Where(o => o.Name.Contains("formRanchos")).FirstOrDefault();
			if (frm == null)
			{
				panelPrincipal.Controls.Clear();
				var form = Application.OpenForms.OfType<formRanchos>().FirstOrDefault();
				var reg = form ?? new formRanchos(panelPrincipal.Width, panelPrincipal.Height);
				FillCanvas(reg);
			}
		}

		private void btnNominas_Click(object sender, EventArgs e)
		{
			Form frm = panelPrincipal.Controls.OfType<Form>().Where(o => o.Name.Contains("formNominas")).FirstOrDefault();
			if (frm == null)
			{
				panelPrincipal.Controls.Clear();
				var form = Application.OpenForms.OfType<formNominas>().FirstOrDefault();
				var reg = form ?? new formNominas(panelPrincipal.Width, panelPrincipal.Height);
				FillCanvas(reg);
			}
		}
	}
}
