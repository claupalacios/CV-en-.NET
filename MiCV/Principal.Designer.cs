namespace MiCV
{
	partial class Principal
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
			this.Conocimientos = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Datos = new System.Windows.Forms.Button();
			this.Formacion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Conocimientos
			// 
			this.Conocimientos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Conocimientos.BackColor = System.Drawing.Color.Transparent;
			this.Conocimientos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Conocimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Conocimientos.Location = new System.Drawing.Point(100, 361);
			this.Conocimientos.Name = "Conocimientos";
			this.Conocimientos.Size = new System.Drawing.Size(255, 80);
			this.Conocimientos.TabIndex = 13;
			this.Conocimientos.Text = "Conocimientos";
			this.Conocimientos.UseVisualStyleBackColor = false;
			this.Conocimientos.Click += new System.EventHandler(this.Conocimientos_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(70, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(331, 46);
			this.label3.TabIndex = 12;
			this.label3.Text = "Curriculum Vitae";
			// 
			// Datos
			// 
			this.Datos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Datos.BackColor = System.Drawing.Color.Transparent;
			this.Datos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Datos.FlatAppearance.BorderSize = 0;
			this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Datos.ForeColor = System.Drawing.Color.Black;
			this.Datos.Location = new System.Drawing.Point(100, 111);
			this.Datos.Name = "Datos";
			this.Datos.Size = new System.Drawing.Size(255, 80);
			this.Datos.TabIndex = 11;
			this.Datos.Text = "Datos";
			this.Datos.UseVisualStyleBackColor = false;
			this.Datos.Click += new System.EventHandler(this.Datos_Click);
			// 
			// Formacion
			// 
			this.Formacion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Formacion.BackColor = System.Drawing.Color.Transparent;
			this.Formacion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Formacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Formacion.Location = new System.Drawing.Point(100, 228);
			this.Formacion.Name = "Formacion";
			this.Formacion.Size = new System.Drawing.Size(255, 80);
			this.Formacion.TabIndex = 10;
			this.Formacion.Text = "Formación Académica";
			this.Formacion.UseVisualStyleBackColor = false;
			this.Formacion.Click += new System.EventHandler(this.Formacion_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(484, 462);
			this.Controls.Add(this.Conocimientos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Datos);
			this.Controls.Add(this.Formacion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Principal";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Conocimientos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Datos;
		private System.Windows.Forms.Button Formacion;
	}
}

