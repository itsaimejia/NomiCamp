namespace NomiCamp
{
	partial class formAdministrarRanchos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTablaVarietal = new System.Windows.Forms.TextBox();
            this.txtHectareas = new System.Windows.Forms.TextBox();
            this.txtCodigoRancho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoVarietal = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tabla varietal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hectareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo Rancho";
            // 
            // txtTablaVarietal
            // 
            this.txtTablaVarietal.Enabled = false;
            this.txtTablaVarietal.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaVarietal.Location = new System.Drawing.Point(234, 206);
            this.txtTablaVarietal.Name = "txtTablaVarietal";
            this.txtTablaVarietal.Size = new System.Drawing.Size(114, 31);
            this.txtTablaVarietal.TabIndex = 4;
            // 
            // txtHectareas
            // 
            this.txtHectareas.Enabled = false;
            this.txtHectareas.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHectareas.Location = new System.Drawing.Point(144, 143);
            this.txtHectareas.Name = "txtHectareas";
            this.txtHectareas.Size = new System.Drawing.Size(148, 31);
            this.txtHectareas.TabIndex = 2;
            // 
            // txtCodigoRancho
            // 
            this.txtCodigoRancho.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRancho.Location = new System.Drawing.Point(145, 78);
            this.txtCodigoRancho.Name = "txtCodigoRancho";
            this.txtCodigoRancho.Size = new System.Drawing.Size(148, 31);
            this.txtCodigoRancho.TabIndex = 1;
            this.txtCodigoRancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoRancho_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 35);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Rancho";
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
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::NomiCamp.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(299, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 31);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupervisor.Enabled = false;
            this.cbSupervisor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Location = new System.Drawing.Point(125, 280);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(207, 31);
            this.cbSupervisor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo varietal";
            // 
            // txtTipoVarietal
            // 
            this.txtTipoVarietal.Enabled = false;
            this.txtTipoVarietal.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVarietal.Location = new System.Drawing.Point(103, 206);
            this.txtTipoVarietal.Name = "txtTipoVarietal";
            this.txtTipoVarietal.Size = new System.Drawing.Size(109, 31);
            this.txtTipoVarietal.TabIndex = 3;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(11, 396);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 32);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(154, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "*En caso de querer eliminar al empleado seleccione remover";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Seleccionar supervisor";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(353, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 34);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // formAdministrarRanchos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoVarietal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSupervisor);
            this.Controls.Add(this.txtTablaVarietal);
            this.Controls.Add(this.txtHectareas);
            this.Controls.Add(this.txtCodigoRancho);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdministrarRanchos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAdministrarRanchos";
            this.Load += new System.EventHandler(this.formAdministrarRanchos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox btnBuscar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTablaVarietal;
		private System.Windows.Forms.TextBox txtHectareas;
		private System.Windows.Forms.TextBox txtCodigoRancho;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox btnRegresar;
		private System.Windows.Forms.ComboBox cbSupervisor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTipoVarietal;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnLimpiar;
	}
}