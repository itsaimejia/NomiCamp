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
			((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReportes
			// 
			this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReportes.Location = new System.Drawing.Point(180, 123);
			this.dgvReportes.Name = "dgvReportes";
			this.dgvReportes.Size = new System.Drawing.Size(240, 150);
			this.dgvReportes.TabIndex = 0;
			// 
			// formReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
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
	}
}