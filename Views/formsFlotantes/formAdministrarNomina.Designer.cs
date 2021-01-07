namespace NomiCamp.Views.formsFlotantes
{
	partial class formAdministrarNomina
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNoEmpleado = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblPuesto = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblTipoV = new System.Windows.Forms.Label();
			this.lblTablaV = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(302, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Administrar Nomina";
			// 
			// btnRegresar
			// 
			this.btnRegresar.Image = global::NomiCamp.Properties.Resources.proximo;
			this.btnRegresar.Location = new System.Drawing.Point(3, 3);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(44, 29);
			this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnRegresar.TabIndex = 1;
			this.btnRegresar.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(241)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnRegresar);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 36);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.lblSalario);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblPuesto);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblNoEmpleado);
			this.groupBox1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 102);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informacion empleado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "No. Empleado";
			// 
			// lblNoEmpleado
			// 
			this.lblNoEmpleado.AutoSize = true;
			this.lblNoEmpleado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoEmpleado.Location = new System.Drawing.Point(23, 62);
			this.lblNoEmpleado.Name = "lblNoEmpleado";
			this.lblNoEmpleado.Size = new System.Drawing.Size(0, 23);
			this.lblNoEmpleado.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(180, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nombre";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(182, 62);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(0, 23);
			this.lblNombre.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(509, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Puesto";
			// 
			// lblPuesto
			// 
			this.lblPuesto.AutoSize = true;
			this.lblPuesto.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuesto.Location = new System.Drawing.Point(509, 62);
			this.lblPuesto.Name = "lblPuesto";
			this.lblPuesto.Size = new System.Drawing.Size(0, 23);
			this.lblPuesto.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(678, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Salario";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalario.Location = new System.Drawing.Point(680, 62);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.Size = new System.Drawing.Size(0, 23);
			this.lblSalario.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Controls.Add(this.lblTablaV);
			this.groupBox2.Controls.Add(this.lblTipoV);
			this.groupBox2.Controls.Add(this.lblFecha);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 175);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(776, 232);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información laborada";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(680, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 23);
			this.label5.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(509, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 23);
			this.label9.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(182, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(0, 23);
			this.label11.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(23, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(0, 23);
			this.label13.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 19);
			this.label3.TabIndex = 10;
			this.label3.Text = "Fecha:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(160, 39);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 19);
			this.label10.TabIndex = 12;
			this.label10.Text = "Tipo varietal:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(359, 39);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 19);
			this.label12.TabIndex = 13;
			this.label12.Text = "Tabla varietal:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(65, 39);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(0, 19);
			this.lblFecha.TabIndex = 14;
			// 
			// lblTipoV
			// 
			this.lblTipoV.AutoSize = true;
			this.lblTipoV.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoV.Location = new System.Drawing.Point(264, 39);
			this.lblTipoV.Name = "lblTipoV";
			this.lblTipoV.Size = new System.Drawing.Size(0, 19);
			this.lblTipoV.TabIndex = 15;
			// 
			// lblTablaV
			// 
			this.lblTablaV.AutoSize = true;
			this.lblTablaV.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTablaV.Location = new System.Drawing.Point(469, 39);
			this.lblTablaV.Name = "lblTablaV";
			this.lblTablaV.Size = new System.Drawing.Size(0, 19);
			this.lblTablaV.TabIndex = 16;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Tipo,
            this.Cantidad,
            this.Costo,
            this.CostoTotal});
			this.dataGridView1.Location = new System.Drawing.Point(10, 62);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Size = new System.Drawing.Size(760, 115);
			this.dataGridView1.TabIndex = 17;
			// 
			// Actividad
			// 
			this.Actividad.Frozen = true;
			this.Actividad.HeaderText = "Actividad";
			this.Actividad.Name = "Actividad";
			this.Actividad.ReadOnly = true;
			this.Actividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Tipo
			// 
			this.Tipo.Frozen = true;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Cantidad
			// 
			this.Cantidad.Frozen = true;
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Costo
			// 
			this.Costo.Frozen = true;
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CostoTotal
			// 
			this.CostoTotal.Frozen = true;
			this.CostoTotal.HeaderText = "Costo total";
			this.CostoTotal.Name = "CostoTotal";
			this.CostoTotal.ReadOnly = true;
			this.CostoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// formAdministrarNomina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formAdministrarNomina";
			this.Text = "formAdministrarNomina";
			((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox btnRegresar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNoEmpleado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblSalario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblPuesto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
		private System.Windows.Forms.Label lblTablaV;
		private System.Windows.Forms.Label lblTipoV;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
	}
}