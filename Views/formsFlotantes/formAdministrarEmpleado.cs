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
		
        public formAdministraEmpleado()
        {
            InitializeComponent();
		
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		

        public void consultar()
		{
           
		}

		private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
               
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txtNoEmpleado.Text))
			{
				MessageBox.Show("Ingresa el numero de empleado");
				txtNoEmpleado.Focus();
			}
			else
			if (string.IsNullOrEmpty(txtNombre.Text))
			{
				MessageBox.Show("Ingresa el nombre");
				txtNombre.Focus();
			}
			else
			if (cbPuesto.SelectedIndex.Equals(-1))
            {
				MessageBox.Show("Selecciona un puesto");
				cbPuesto.Focus();
            }
			else
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
					txtNoEmpleado.Text = string.Empty;
					txtNombre.Text = string.Empty;
					cbPuesto.Text = string.Empty;
					txtSalario.Text = string.Empty;
					
                }
                else
                {
					MessageBox.Show("Ocurrio un error");
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
			else
			if (e.KeyChar == (char)Keys.Enter)
			{
				
			}
		}
	}
}
