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
    public partial class Exponencial : Form
    {
        public Exponencial()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
        }

        public List<double> negativeExponentialSerie(int n, double param)
        {
            List<double> lista = new List<double>();
            var Random = new Random();
            for (int i = 0; i < n; i++)
            {
                double psedef = Random.NextDouble();
                double num = negativeExponentialGenerator(psedef, param);
                lista.Add(num);

            }
            return lista;
        }

        private double negativeExponentialGenerator(double pseudo, double param)
        {
            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                double lambda = (1 / param);
                return (-1 / lambda) * Math.Log(1 - pseudo);
            }
            return (-1 / (double) txtParam.Value) * Math.Log(1 - pseudo);
        }
    }
}
