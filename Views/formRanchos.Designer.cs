namespace NomiCamp.Views
{
	partial class formRanchos
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
<<<<<<< Updated upstream
            this.dgvInfoRanchos = new System.Windows.Forms.DataGridView();
            this.CodigoRancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hectareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVarietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaVarietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporteExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminRanchos = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRanchos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminRanchos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoRanchos
            // 
            this.dgvInfoRanchos.AllowUserToAddRows = false;
            this.dgvInfoRanchos.AllowUserToDeleteRows = false;
            this.dgvInfoRanchos.AllowUserToResizeColumns = false;
            this.dgvInfoRanchos.AllowUserToResizeRows = false;
            this.dgvInfoRanchos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoRanchos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
=======
			this.dgvInfoRanchos = new System.Windows.Forms.DataGridView();
			this.CodigoRancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hectareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoVarietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TablaVarietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnReporteExcel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdminRanchos = new System.Windows.Forms.PictureBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInfoRanchos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdminRanchos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInfoRanchos
			// 
			this.dgvInfoRanchos.AllowUserToAddRows = false;
			this.dgvInfoRanchos.AllowUserToDeleteRows = false;
			this.dgvInfoRanchos.AllowUserToResizeColumns = false;
			this.dgvInfoRanchos.AllowUserToResizeRows = false;
			this.dgvInfoRanchos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInfoRanchos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
>>>>>>> Stashed changes
            this.CodigoRancho,
            this.Hectareas,
            this.TipoVarietal,
            this.TablaVarietal,
            this.Supervisor});
<<<<<<< Updated upstream
            this.dgvInfoRanchos.Location = new System.Drawing.Point(67, 188);
            this.dgvInfoRanchos.Name = "dgvInfoRanchos";
            this.dgvInfoRanchos.ReadOnly = true;
            this.dgvInfoRanchos.Size = new System.Drawing.Size(571, 191);
            this.dgvInfoRanchos.TabIndex = 0;
            // 
            // CodigoRancho
            // 
            this.CodigoRancho.HeaderText = "Código rancho";
            this.CodigoRancho.Name = "CodigoRancho";
            this.CodigoRancho.ReadOnly = true;
            this.CodigoRancho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hectareas
            // 
            this.Hectareas.HeaderText = "Hectareas";
            this.Hectareas.Name = "Hectareas";
            this.Hectareas.ReadOnly = true;
            this.Hectareas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoVarietal
            // 
            this.TipoVarietal.HeaderText = "Tipo varietal";
            this.TipoVarietal.Name = "TipoVarietal";
            this.TipoVarietal.ReadOnly = true;
            this.TipoVarietal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TablaVarietal
            // 
            this.TablaVarietal.HeaderText = "Tabla varietal";
            this.TablaVarietal.Name = "TablaVarietal";
            this.TablaVarietal.ReadOnly = true;
            this.TablaVarietal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Supervisor
            // 
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.ReadOnly = true;
            this.Supervisor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnReporteExcel
            // 
            this.btnReporteExcel.BackColor = System.Drawing.Color.Lime;
            this.btnReporteExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteExcel.ForeColor = System.Drawing.Color.Black;
            this.btnReporteExcel.Location = new System.Drawing.Point(863, 498);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(736, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrar ranchos";
            // 
            // btnAdminRanchos
            // 
            this.btnAdminRanchos.Image = global::NomiCamp.Properties.Resources.analytic_dashboard_home_manage_user_interface_icon_123286;
            this.btnAdminRanchos.Location = new System.Drawing.Point(775, 60);
            this.btnAdminRanchos.Name = "btnAdminRanchos";
            this.btnAdminRanchos.Size = new System.Drawing.Size(44, 42);
            this.btnAdminRanchos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdminRanchos.TabIndex = 5;
            this.btnAdminRanchos.TabStop = false;
            this.btnAdminRanchos.Click += new System.EventHandler(this.btnAdminRanchos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(12, 517);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(74, 26);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // formRanchos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 555);
            this.ControlBox = false;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminRanchos);
            this.Controls.Add(this.btnReporteExcel);
            this.Controls.Add(this.dgvInfoRanchos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRanchos";
            this.Text = "formRanchos";
            this.Load += new System.EventHandler(this.formRanchos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRanchos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminRanchos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
			this.dgvInfoRanchos.Location = new System.Drawing.Point(67, 188);
			this.dgvInfoRanchos.Name = "dgvInfoRanchos";
			this.dgvInfoRanchos.ReadOnly = true;
			this.dgvInfoRanchos.Size = new System.Drawing.Size(571, 191);
			this.dgvInfoRanchos.TabIndex = 0;
			// 
			// CodigoRancho
			// 
			this.CodigoRancho.HeaderText = "Código rancho";
			this.CodigoRancho.Name = "CodigoRancho";
			this.CodigoRancho.ReadOnly = true;
			this.CodigoRancho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Hectareas
			// 
			this.Hectareas.HeaderText = "Hectareas";
			this.Hectareas.Name = "Hectareas";
			this.Hectareas.ReadOnly = true;
			this.Hectareas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// TipoVarietal
			// 
			this.TipoVarietal.HeaderText = "Tipo varietal";
			this.TipoVarietal.Name = "TipoVarietal";
			this.TipoVarietal.ReadOnly = true;
			this.TipoVarietal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// TablaVarietal
			// 
			this.TablaVarietal.HeaderText = "Tabla varietal";
			this.TablaVarietal.Name = "TablaVarietal";
			this.TablaVarietal.ReadOnly = true;
			this.TablaVarietal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Supervisor
			// 
			this.Supervisor.HeaderText = "Supervisor";
			this.Supervisor.Name = "Supervisor";
			this.Supervisor.ReadOnly = true;
			this.Supervisor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// btnReporteExcel
			// 
			this.btnReporteExcel.BackColor = System.Drawing.Color.Lime;
			this.btnReporteExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteExcel.ForeColor = System.Drawing.Color.Black;
			this.btnReporteExcel.Location = new System.Drawing.Point(863, 498);
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
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(736, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Administrar ranchos";
			// 
			// btnAdminRanchos
			// 
			this.btnAdminRanchos.Image = global::NomiCamp.Properties.Resources.analytic_dashboard_home_manage_user_interface_icon_123286;
			this.btnAdminRanchos.Location = new System.Drawing.Point(775, 60);
			this.btnAdminRanchos.Name = "btnAdminRanchos";
			this.btnAdminRanchos.Size = new System.Drawing.Size(44, 42);
			this.btnAdminRanchos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnAdminRanchos.TabIndex = 5;
			this.btnAdminRanchos.TabStop = false;
			this.btnAdminRanchos.Click += new System.EventHandler(this.btnAdminRanchos_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(12, 517);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(74, 26);
			this.btnActualizar.TabIndex = 7;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// formRanchos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 555);
			this.ControlBox = false;
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdminRanchos);
			this.Controls.Add(this.btnReporteExcel);
			this.Controls.Add(this.dgvInfoRanchos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formRanchos";
			this.Text = "formRanchos";
			this.Load += new System.EventHandler(this.formRanchos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInfoRanchos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdminRanchos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
>>>>>>> Stashed changes

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInfoRanchos;
		private System.Windows.Forms.Button btnReporteExcel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox btnAdminRanchos;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRancho;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hectareas;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoVarietal;
		private System.Windows.Forms.DataGridViewTextBoxColumn TablaVarietal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
	}
}