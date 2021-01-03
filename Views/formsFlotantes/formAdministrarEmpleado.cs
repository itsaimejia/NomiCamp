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
            MessageBox.Show(txtNoEmpleado.Text);
		}

		private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
                consultar();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			consultar();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
		

		}
	}
}
