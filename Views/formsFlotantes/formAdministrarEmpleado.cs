using NomiCamp.Models;
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
    public partial class formAdministraEmpleado : Form
    {
		private bool editar = false;
        public formAdministraEmpleado()
        {
            InitializeComponent();
		
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public void Consultar()
		{
			var empleado = Empleado.Select(txtNoEmpleado.Text);
			if (empleado.NoEmpleado != null)
			{
				ControlesEditables();

				txtNombre.Text = empleado.Nombre;
				cbPuesto.Text = empleado.Puesto;
				txtSalario.Text = empleado.SalarioXDia.ToString();
				btnGuardar.Text = "Actualizar";
				editar = true;
			}
			else
			{
				ControlesEditables();
				txtSalario.Text = string.Empty;
			}
		}

		private void ControlesEditables()
		{
			txtNombre.Enabled = true;
			txtSalario.Enabled = true;
			cbPuesto.Enabled = true;
			btnGuardar.Enabled = true;
			btnRemover.Enabled = true;
		}
		private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				Consultar();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Consultar();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (editar)
			{
				var existente = new Empleado()
				{
					NoEmpleado = txtNoEmpleado.Text.Trim(),
					Nombre = txtNombre.Text.Trim(),
					Puesto = cbPuesto.Text,
					SalarioXDia = float.Parse(txtSalario.Text.Trim())

				};

				if (existente.Update())
				{
					MessageBox.Show("Actualizado");
					Limpiar();
					editar = false;
				}
				else
				{
					MessageBox.Show("Ocurrio un error");
				}
			}
			else
			{
				if (string.IsNullOrEmpty(txtNoEmpleado.Text))
				{
					MessageBox.Show("Ingresa el numero de empleado");
					txtNoEmpleado.Focus();
				}
				if (string.IsNullOrEmpty(txtNombre.Text))
				{
					MessageBox.Show("Ingresa el nombre");
					txtNombre.Focus();
				}

				if (cbPuesto.SelectedIndex.Equals(-1))
				{
					MessageBox.Show("Selecciona un puesto");
					cbPuesto.Focus();
				}
				if (string.IsNullOrEmpty(txtSalario.Text))
				{
					MessageBox.Show("Ingresa el salario");
					txtSalario.Focus();
				}
				else
				{

					var nuevo = new Empleado()
					{
						NoEmpleado = txtNoEmpleado.Text.Trim(),
						Nombre = txtNombre.Text.Trim(),
						Puesto = cbPuesto.Text,
						SalarioXDia = float.Parse(txtSalario.Text.Trim())

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

		private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46) && (e.KeyChar != (char)Keys.Enter))
			{
				txtSalario.Text = string.Empty;
				e.Handled = true;
				return;
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar();
			editar = false;
		}

		private void Limpiar()
		{
			txtNoEmpleado.Text = string.Empty;
			txtNombre.Text = string.Empty;
			cbPuesto.SelectedIndex = -1;
			txtSalario.Text = string.Empty;
			btnGuardar.Text = "Guardar";
		}
	}
}
