namespace NomiCamp.Views
{
	partial class formReportes
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
			this.dgvReportes = new System.Windows.Forms.DataGridView();
			this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReportes
			// 
			this.dgvReportes.AllowUserToAddRows = false;
			this.dgvReportes.AllowUserToDeleteRows = false;
			this.dgvReportes.AllowUserToResizeColumns = false;
			this.dgvReportes.AllowUserToResizeRows = false;
			this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo});
			this.dgvReportes.Location = new System.Drawing.Point(180, 123);
			this.dgvReportes.Name = "dgvReportes";
			this.dgvReportes.Size = new System.Drawing.Size(240, 150);
			this.dgvReportes.TabIndex = 0;
			this.dgvReportes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellContentDoubleClick);
			// 
			// Archivo
			// 
			this.Archivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Archivo.HeaderText = "Archivo";
			this.Archivo.Name = "Archivo";
			this.Archivo.ReadOnly = true;
			this.Archivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Archivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Archivo.ToolTipText = "Doble click para abrir el archivo";
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(12, 412);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(74, 26);
			this.btnActualizar.TabIndex = 5;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// formReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.dgvReportes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formReportes";
			this.Text = "formReportes";
			this.Load += new System.EventHandler(this.formReportes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReportes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
		private System.Windows.Forms.Button btnActualizar;
	}
}