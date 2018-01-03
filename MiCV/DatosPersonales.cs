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
	public partial class DatosPersonales : Form
	{
		public DatosPersonales()
		{
			InitializeComponent();
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

