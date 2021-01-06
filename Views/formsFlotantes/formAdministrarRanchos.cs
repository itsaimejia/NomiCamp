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
            if (string.IsNullOrEmpty(txtCodigoRancho.Text)) 
			{
				MessageBox.Show("Ingresa el codigo de rancho");
				txtCodigoRancho.Focus();
			}
			else
			if (string.IsNullOrEmpty(txtHectareas.Text)) 
			{
				MessageBox.Show("Ingresa las hectareas");
				txtHectareas.Focus();
			}
			else
            if (string.IsNullOrEmpty(txtTablaVarietal.Text))
            {
				MessageBox.Show("Ingresa tabla varietal");
				txtTablaVarietal.Focus();
            }
			else
            if (string.IsNullOrEmpty(txtTipoVarietal.Text))
            {
				MessageBox.Show("Ingresa tipo varietal");
				txtTipoVarietal.Focus();
            }
			else
			if (cbSupervisor.SelectedIndex.Equals(-1))
            {
				MessageBox.Show("Selecciona un supervisor");
				cbSupervisor.Focus();
			}
			else
			{
				var nuevo = new Rancho
				{
					Codigo = txtCodigoRancho.Text,
					Hectareas = float.Parse(txtHectareas.Text),
					TipoVarietal = int.Parse(txtTipoVarietal.Text),
					TablaVarietal = int.Parse(txtTablaVarietal.Text),
					IdSupervisor = cbSupervisor.Text
				};

				if (nuevo.Insert())
				{
					MessageBox.Show("Insertado");
				}
				else
				{
					MessageBox.Show("Ocurrio un error");
				}
			}
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

		private void btnLimpiar_Click(object sender, EventArgs e)
		{

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

		}
	}
}
