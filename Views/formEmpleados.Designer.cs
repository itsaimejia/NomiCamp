namespace NomiCamp.Views
{
	partial class formEmpleados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dvInfoEmpleados = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReporteExcel = new System.Windows.Forms.Button();
			this.btnAdminEmpleados = new System.Windows.Forms.PictureBox();
			this.NoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dvInfoEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdminEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// dvInfoEmpleados
			// 
			this.dvInfoEmpleados.AllowUserToAddRows = false;
			this.dvInfoEmpleados.AllowUserToDeleteRows = false;
			this.dvInfoEmpleados.AllowUserToResizeColumns = false;
			this.dvInfoEmpleados.AllowUserToResizeRows = false;
			this.dvInfoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvInfoEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoEmpleado,
            this.Nombre,
            this.Puesto,
            this.Salario});
			this.dvInfoEmpleados.GridColor = System.Drawing.Color.White;
			this.dvInfoEmpleados.Location = new System.Drawing.Point(12, 162);
			this.dvInfoEmpleados.Name = "dvInfoEmpleados";
			this.dvInfoEmpleados.Size = new System.Drawing.Size(1081, 476);
			this.dvInfoEmpleados.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(946, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Administrar empleados";
			// 
			// btnReporteExcel
			// 
			this.btnReporteExcel.BackColor = System.Drawing.Color.Lime;
			this.btnReporteExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteExcel.ForeColor = System.Drawing.Color.Black;
			this.btnReporteExcel.Location = new System.Drawing.Point(966, 644);
			this.btnReporteExcel.Name = "btnReporteExcel";
			this.btnReporteExcel.Size = new System.Drawing.Size(126, 32);
			this.btnReporteExcel.TabIndex = 3;
			this.btnReporteExcel.Text = "Generar Excel";
			this.btnReporteExcel.UseVisualStyleBackColor = false;
			// 
			// btnAdminEmpleados
			// 
			this.btnAdminEmpleados.Image = global::NomiCamp.Properties.Resources.administracion;
			this.btnAdminEmpleados.Location = new System.Drawing.Point(996, 12);
			this.btnAdminEmpleados.Name = "btnAdminEmpleados";
			this.btnAdminEmpleados.Size = new System.Drawing.Size(44, 42);
			this.btnAdminEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnAdminEmpleados.TabIndex = 1;
			this.btnAdminEmpleados.TabStop = false;
			this.btnAdminEmpleados.Click += new System.EventHandler(this.btnAdminEmpleados_Click);
			// 
			// NoEmpleado
			// 
			this.NoEmpleado.HeaderText = "No Empleado";
			this.NoEmpleado.Name = "NoEmpleado";
			this.NoEmpleado.ReadOnly = true;
			this.NoEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			this.Puesto.ReadOnly = true;
			this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Salario
			// 
			this.Salario.HeaderText = "Salario";
			this.Salario.Name = "Salario";
			this.Salario.ReadOnly = true;
			this.Salario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// formEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 688);
			this.ControlBox = false;
			this.Controls.Add(this.btnReporteExcel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdminEmpleados);
			this.Controls.Add(this.dvInfoEmpleados);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formEmpleados";
			this.Text = "formEmpleados";
			this.Load += new System.EventHandler(this.formEmpleados_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvInfoEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdminEmpleados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dvInfoEmpleados;
		private System.Windows.Forms.PictureBox btnAdminEmpleados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReporteExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
	}
}