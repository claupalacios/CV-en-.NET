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
	public partial class Formacion : Form
	{
		public Formacion()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			label4.Text = "Tecnicatura Superior en Programación" + Environment.NewLine + "en Universidad Tecnológica Nacional de Haedo.";
		}

		private void Atras_Click(object sender, EventArgs e)
		{
			Principal pr = new Principal();
			this.Hide();
			pr.ShowDialog();
			this.Close();
		}
	}
}
