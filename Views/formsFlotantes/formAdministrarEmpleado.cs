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
			var nuevo = new Empleado()
			{
				NoEmpleado = txtNoEmpleado.Text.Trim(),
				Nombre = txtNombre.Text.Trim(),
				Puesto = cbPuesto.Text,
				SalarioXDia = float.Parse(txtSalario.Text.Trim())

			};

			if (nuevo.Insert())
				MessageBox.Show("insertado");
			else
				MessageBox.Show("No insertado");

		}
	}
}
