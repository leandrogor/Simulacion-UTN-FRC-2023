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
            dgvExponencial.Rows.Clear();
            List<double> exponentialNumbersList = negativeExponentialSerie((int)txtCantidad.Value, lambdaOrMeanValidation((double)txtParam.Value));

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
                dgvExponencial.Rows.Add((i + 1).ToString(), num.ToString());

            }
            return lista;
        }

        private double negativeExponentialGenerator(double pseudo, double param)
        {
            return (-1 / (double) txtParam.Value) * Math.Log(1 - pseudo);
        }

        private double lambdaOrMeanValidation(double param)
        {
            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                return (1 / param);
            }

            return param;
        }
    }
}
