
namespace NomiCamp
{
    partial class formAdministraEmpleado
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.PictureBox();
			this.txtNoEmpleado = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.cbPuesto = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.PictureBox();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(241)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnRegresar);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 35);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(132, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Administrar Empleado";
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
			// txtNoEmpleado
			// 
			this.txtNoEmpleado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoEmpleado.Location = new System.Drawing.Point(145, 76);
			this.txtNoEmpleado.Name = "txtNoEmpleado";
			this.txtNoEmpleado.Size = new System.Drawing.Size(148, 31);
			this.txtNoEmpleado.TabIndex = 1;
			this.txtNoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoEmpleado_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(122, 142);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(198, 31);
			this.txtNombre.TabIndex = 2;
			// 
			// txtSalario
			// 
			this.txtSalario.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalario.Location = new System.Drawing.Point(144, 280);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(148, 31);
			this.txtSalario.TabIndex = 4;
			this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
			// 
			// cbPuesto
			// 
			this.cbPuesto.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPuesto.FormattingEnabled = true;
			this.cbPuesto.Items.AddRange(new object[] {
            "Pizca",
            "Trailero",
            "Otra cosa "});
			this.cbPuesto.Location = new System.Drawing.Point(144, 201);
			this.cbPuesto.Name = "cbPuesto";
			this.cbPuesto.Size = new System.Drawing.Size(148, 31);
			this.cbPuesto.TabIndex = 3;
			this.cbPuesto.Text = "Puesto";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(140, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "No. Empleado";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(118, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nombre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(141, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Salario p/ Día";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::NomiCamp.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(299, 76);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(24, 31);
			this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnBuscar.TabIndex = 8;
			this.btnBuscar.TabStop = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnRemover
			// 
			this.btnRemover.BackColor = System.Drawing.Color.Red;
			this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemover.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Location = new System.Drawing.Point(12, 397);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(98, 32);
			this.btnRemover.TabIndex = 30;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Lime;
			this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(155, 395);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(118, 34);
			this.btnGuardar.TabIndex = 29;
			this.btnGuardar.Text = "Guardar Cambios";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 432);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(291, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "*En caso de querer eliminar al empleado seleccione remover";
			// 
			// formAdministraEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 450);
			this.ControlBox = false;
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbPuesto);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtNoEmpleado);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formAdministraEmpleado";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrar Empleado";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnBuscar;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label5;
	}
}

