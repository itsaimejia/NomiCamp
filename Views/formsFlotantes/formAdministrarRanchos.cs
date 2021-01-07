using NomiCamp.Models;
using System;
using System.Windows.Forms;

namespace NomiCamp
{
	public partial class formAdministrarRanchos : Form
	{
		private bool editar = false;
		public formAdministrarRanchos()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            if (editar)
            {
				var existente = new Rancho
				{
					Codigo = txtCodigoRancho.Text,
					Hectareas = float.Parse(txtHectareas.Text),
					TipoVarietal = int.Parse(txtTipoVarietal.Text),
					TablaVarietal = int.Parse(txtTablaVarietal.Text),
					IdSupervisor = cbSupervisor.Text
				};

				if (existente.Update())
				{
					MessageBox.Show("Insertado");
					Limpiar();
				}
				else
				{
					MessageBox.Show("Ocurrio un error");
				}
			}
            else
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
						Limpiar();
					}
					else
					{
						MessageBox.Show("Ocurrio un error");
					}
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
			Limpiar();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Consultar();
		}

		private void Consultar()
        {
			var rancho = Rancho.Select(txtCodigoRancho.Text);
			if (rancho.Codigo != null)
			{
				btnGuardar.Text = "Actualizar";
				editar = true;
				ControlesEditables();
				txtHectareas.Text = rancho.Hectareas.ToString();
				txtTipoVarietal.Text = rancho.TipoVarietal.ToString();
				txtTablaVarietal.Text = rancho.TablaVarietal.ToString();
				cbSupervisor.Text = rancho.IdSupervisor;
            }
            else
            {
				ControlesEditables();

            }
        }

		private void ControlesEditables()
        {
			btnGuardar.Enabled = true;
			btnRemover.Enabled = true;
			txtHectareas.Enabled = true;
			txtCodigoRancho.Enabled = true;
			txtTablaVarietal.Enabled = true;
			txtTipoVarietal.Enabled = true;
			cbSupervisor.Enabled = true;	
        }
		private void Limpiar()
		{
			txtCodigoRancho.Text = string.Empty;
			txtHectareas.Text = string.Empty;
			txtTablaVarietal.Text = string.Empty;
			txtTipoVarietal.Text = string.Empty;
			cbSupervisor.SelectedIndex = -1;
			btnGuardar.Text = "Guardar";
		}

        private void txtCodigoRancho_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == (char)Keys.Enter)
			{
				Consultar();
			}
		}
    }
}
