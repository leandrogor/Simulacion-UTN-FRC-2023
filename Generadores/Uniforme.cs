using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Generadores
{
    public partial class Uniforme : Form
    {
        public Uniforme()
        {
            InitializeComponent();
            boxIntervalos.SelectedIndex = 0;
            txtA.Value= 0;
            txtB.Value = 1;
            txtCantidad.Value = 10;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text is null)
            {
                txtCantidad.Text = "10";
            }

            double min = Convert.ToDouble(txtA.Text); // límite inferior
            double max = Convert.ToDouble(txtB.Text); // límite superior
            int n = int.Parse(txtCantidad.Text);  // tamaño de muestra

            if (min>max)
            {
                double temp = min; min = max; max = temp;
                txtA.Text = min.ToString();
                txtB.Text = max.ToString();
            }

            List<double> lista = new List<double>();
            dgvUniforme.Rows.Clear();

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                double valor = Math.Round(rnd.NextDouble() * (max - min) + min, 4);

                lista.Add(valor);
                dgvUniforme.Rows.Add((i+1).ToString(), valor.ToString());
            }
        }
    }
}
