﻿namespace NomiCamp.Views
{
	partial class formNominas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvNominas = new System.Windows.Forms.DataGridView();
			this.btnReporteExcel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.IdNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Administrar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.NominaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNominas
			// 
			this.dgvNominas.AllowUserToAddRows = false;
			this.dgvNominas.AllowUserToDeleteRows = false;
			this.dgvNominas.AllowUserToResizeColumns = false;
			this.dgvNominas.AllowUserToResizeRows = false;
			this.dgvNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNominas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNomina,
            this.NoEmpleado,
            this.Nombre,
            this.Puesto,
            this.Administrar,
            this.NominaDia});
			this.dgvNominas.Location = new System.Drawing.Point(59, 103);
			this.dgvNominas.Name = "dgvNominas";
			this.dgvNominas.Size = new System.Drawing.Size(631, 224);
			this.dgvNominas.TabIndex = 0;
			this.dgvNominas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNominas_CellContentClick);
			// 
			// btnReporteExcel
			// 
			this.btnReporteExcel.BackColor = System.Drawing.Color.Lime;
			this.btnReporteExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteExcel.ForeColor = System.Drawing.Color.Black;
			this.btnReporteExcel.Location = new System.Drawing.Point(820, 522);
			this.btnReporteExcel.Name = "btnReporteExcel";
			this.btnReporteExcel.Size = new System.Drawing.Size(126, 32);
			this.btnReporteExcel.TabIndex = 4;
			this.btnReporteExcel.Text = "Generar Excel";
			this.btnReporteExcel.UseVisualStyleBackColor = false;
			this.btnReporteExcel.Click += new System.EventHandler(this.btnReporteExcel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Fecha:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(75, 13);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(61, 13);
			this.lblFecha.TabIndex = 6;
			this.lblFecha.Text = "20-10-2020";
			// 
			// IdNomina
			// 
			this.IdNomina.HeaderText = "Id Nomina";
			this.IdNomina.Name = "IdNomina";
			this.IdNomina.ReadOnly = true;
			this.IdNomina.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.IdNomina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// NoEmpleado
			// 
			this.NoEmpleado.HeaderText = "No Empleado";
			this.NoEmpleado.Name = "NoEmpleado";
			this.NoEmpleado.ReadOnly = true;
			this.NoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NoEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			this.Puesto.ReadOnly = true;
			this.Puesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Administrar
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.NullValue = "Administrar";
			this.Administrar.DefaultCellStyle = dataGridViewCellStyle7;
			this.Administrar.HeaderText = "Administrar";
			this.Administrar.Name = "Administrar";
			this.Administrar.ReadOnly = true;
			this.Administrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Administrar.UseColumnTextForButtonValue = true;
			// 
			// NominaDia
			// 
			this.NominaDia.HeaderText = "Nomina por día";
			this.NominaDia.Name = "NominaDia";
			this.NominaDia.ReadOnly = true;
			this.NominaDia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(12, 528);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(74, 26);
			this.btnActualizar.TabIndex = 7;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// formNominas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 566);
			this.ControlBox = false;
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReporteExcel);
			this.Controls.Add(this.dgvNominas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formNominas";
			this.Text = "formNominas";
			this.Load += new System.EventHandler(this.formNominas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvNominas;
		private System.Windows.Forms.Button btnReporteExcel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdNomina;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewButtonColumn Administrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn NominaDia;
		private System.Windows.Forms.Button btnActualizar;
	}
}