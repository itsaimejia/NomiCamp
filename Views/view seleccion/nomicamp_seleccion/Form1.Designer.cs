﻿namespace nomicamp_seleccion
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.btnCargarLista = new System.Windows.Forms.Button();
			this.dgvSelEmpleados = new System.Windows.Forms.DataGridView();
			this.NoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNoEmpleado = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.PictureBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.lblTitulo);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.btnMinimizar);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1259, 50);
			this.panel1.TabIndex = 2;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(550, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(106, 25);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Selección";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = global::nomicamp_seleccion.Properties.Resources.error_1_;
			this.btnCerrar.Location = new System.Drawing.Point(1223, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(23, 31);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Image = global::nomicamp_seleccion.Properties.Resources.window_minimize_icon_144028;
			this.btnMinimizar.Location = new System.Drawing.Point(1190, 12);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(27, 20);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 1;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// btnCargarLista
			// 
			this.btnCargarLista.BackColor = System.Drawing.Color.Lime;
			this.btnCargarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCargarLista.ForeColor = System.Drawing.Color.Black;
			this.btnCargarLista.Location = new System.Drawing.Point(529, 588);
			this.btnCargarLista.Name = "btnCargarLista";
			this.btnCargarLista.Size = new System.Drawing.Size(126, 32);
			this.btnCargarLista.TabIndex = 5;
			this.btnCargarLista.Text = "Cargar lista";
			this.btnCargarLista.UseVisualStyleBackColor = false;
			this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
			// 
			// dgvSelEmpleados
			// 
			this.dgvSelEmpleados.AllowUserToAddRows = false;
			this.dgvSelEmpleados.AllowUserToDeleteRows = false;
			this.dgvSelEmpleados.AllowUserToResizeColumns = false;
			this.dgvSelEmpleados.AllowUserToResizeRows = false;
			this.dgvSelEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSelEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoEmpleado,
            this.Nombre,
            this.Puesto,
            this.Seleccionar});
			this.dgvSelEmpleados.Location = new System.Drawing.Point(85, 116);
			this.dgvSelEmpleados.Name = "dgvSelEmpleados";
			this.dgvSelEmpleados.Size = new System.Drawing.Size(1081, 466);
			this.dgvSelEmpleados.TabIndex = 4;
			// 
			// NoEmpleado
			// 
			this.NoEmpleado.HeaderText = "No Empleado";
			this.NoEmpleado.Name = "NoEmpleado";
			this.NoEmpleado.ReadOnly = true;
			this.NoEmpleado.Width = 260;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 259;
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			this.Puesto.ReadOnly = true;
			this.Puesto.Width = 260;
			// 
			// Seleccionar
			// 
			this.Seleccionar.HeaderText = "Seleccionar";
			this.Seleccionar.Name = "Seleccionar";
			this.Seleccionar.ToolTipText = "Seleccionar empleado";
			this.Seleccionar.Width = 259;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(81, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "No. Empleado";
			// 
			// txtNoEmpleado
			// 
			this.txtNoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoEmpleado.Location = new System.Drawing.Point(86, 79);
			this.txtNoEmpleado.Name = "txtNoEmpleado";
			this.txtNoEmpleado.Size = new System.Drawing.Size(148, 26);
			this.txtNoEmpleado.TabIndex = 9;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::nomicamp_seleccion.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(240, 79);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(22, 26);
			this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.TabStop = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(86, 594);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(74, 26);
			this.btnActualizar.TabIndex = 14;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1257, 632);
			this.ControlBox = false;
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNoEmpleado);
			this.Controls.Add(this.btnCargarLista);
			this.Controls.Add(this.dgvSelEmpleados);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "NomiCamp - Selección";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnCargarLista;
		private System.Windows.Forms.DataGridView dgvSelEmpleados;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoEmpleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
		private System.Windows.Forms.PictureBox btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNoEmpleado;
		private System.Windows.Forms.Button btnActualizar;
	}
}

