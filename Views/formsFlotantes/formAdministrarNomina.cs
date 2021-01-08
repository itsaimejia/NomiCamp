using NomiCamp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomiCamp.Views.formsFlotantes
{
	public partial class formAdministrarNomina : Form
	{
		public string idNomina { get; set; }
		private Nomina nomina;
		private Actividades actividad;
		private Empleado empleado;
		public formAdministrarNomina()
		{
			InitializeComponent();
		}

		private void formAdministrarNomina_Load(object sender, EventArgs e)
		{
			nomina = Nomina.Select(idNomina);
			actividad = Actividades.Select("AAA123");
			empleado = Empleado.Select("100");

			LlenarElementos();
			LlenarLista();
		}

		private void LlenarElementos()
		{
			lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
			lblNoEmpleado.Text = empleado.NoEmpleado;
			lblNombre.Text = empleado.Nombre;
			lblPuesto.Text = empleado.Puesto;
			lblSalario.Text = empleado.SalarioXDia.ToString();
		}

		private void LlenarLista()
		{
			ArrayList row = new ArrayList();
			row.Add(actividad.Nombre);
			row.Add(actividad.Tipo);
			row.Add("100");

			dgvInformacion.Rows.Add(row.ToArray());
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvInformacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow datos = dgvInformacion.Rows[e.RowIndex];
			float costo = float.Parse(datos.Cells["Costo"].Value.ToString());
			float total = float.Parse(datos.Cells["Cantidad"].Value.ToString());
			float finalTotal= costo * total;
			datos.Cells["CostoTotal"].Value = finalTotal.ToString();
			lblTotal.Text = finalTotal.ToString();
		}
	}
}
