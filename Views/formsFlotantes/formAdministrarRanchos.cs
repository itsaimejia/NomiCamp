using NomiCamp.Models;
using System;
using System.Windows.Forms;

namespace NomiCamp
{
	public partial class formAdministrarRanchos : Form
	{
		public formAdministrarRanchos()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{

		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void formAdministrarRanchos_Load(object sender, EventArgs e)
		{
			foreach (var s in Supervisor.GetSupervisores())
			{
				cbSupervisor.Items.Add(s.IdSupervisor);
			}
		}
	}
}
