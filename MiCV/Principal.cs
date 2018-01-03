using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCV
{
	public partial class Principal : Form
	{
		
		
		public Principal()
		{
			InitializeComponent();
			Datos.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			//Datos.TabStop = false;
			Datos.FlatStyle = FlatStyle.Flat;
			Datos.FlatAppearance.BorderSize = 0;

			//Formacion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			Formacion.FlatAppearance.BorderColor = Color.Red;
			Formacion.TabStop = false;
			Formacion.FlatStyle = FlatStyle.Flat;
			Formacion.FlatAppearance.BorderSize = 0;

			Conocimientos.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			Conocimientos.TabStop = false;
			Conocimientos.FlatStyle = FlatStyle.Flat;
			Conocimientos.FlatAppearance.BorderSize = 0;
		}

		
		private void Datos_Click(object sender, EventArgs e)
		{
			DatosPersonales dp = new DatosPersonales();
			this.Hide();
			dp.ShowDialog();
			this.Close();
		}

		private void Conocimientos_Click(object sender, EventArgs e)
		{
			this.Hide();
			Conocimientos co = new Conocimientos();
			co.ShowDialog();
			this.Close();
		}

		private void Formacion_Click(object sender, EventArgs e)
		{
			this.Hide();
			Formacion fo = new Formacion();
			fo.ShowDialog();
			this.Close();
		}

	
	}
}
