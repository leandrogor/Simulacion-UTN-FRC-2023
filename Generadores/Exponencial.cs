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
<<<<<<< HEAD
            
=======
            dgvExponencial.Rows.Clear();

            if (int.Parse(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de valores a generar");
                return;
            }
            if (boxIntervalos.SelectedIndex == -1)
            {
                string text = "Seleccione un intervalo";
                MessageBox.Show(text);
                return;
            }

            if (cbxParam.SelectedIndex == -1)
            {
                string text = "Defina que parametro desea utilizar";
                MessageBox.Show(text);
                return;
            }


            int cantidadIntervalos = int.Parse(boxIntervalos.Text); // cantidad de intervalos
            List<double> exponentialNumbersList = negativeExponentialSerie(cantidadIntervalos, lambdaOrMeanValidation((double)txtParam.Value));
            double correction = 0.0001;
            double maxx = exponentialNumbersList.Max<double>() + correction; // Limite inferior
            double minx = exponentialNumbersList.Min<double>() - correction; // Limite superior

            double longintervalos = (maxx - minx) / cantidadIntervalos;


            double[] limInf = new double[cantidadIntervalos];
            double[] limSup = new double[cantidadIntervalos];
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                limInf[i] = minx + i * longintervalos;
                limSup[i] = limInf[i] + longintervalos;
            }

            // Se calculan las frecuencias observadas
            int[] frecObs = new int[cantidadIntervalos];

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                double val = exponentialNumbersList[i];

                for (int j = 0; j < cantidadIntervalos; j++)
                {
                    if (val >= limInf[j] && val < limSup[j])
                    {
                        frecObs[j]++;
                        break;
                    }
                }

            }
            // Se definen los headers de la tabla
            DataTable tablefrecs = new DataTable();
            tablefrecs.Columns.Add("Límite Inferior");
            tablefrecs.Columns.Add("Límite Superior");
            tablefrecs.Columns.Add("Frecuencia Observada");
            tablefrecs.Columns.Add("Frecuencia Esperada");


            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataRow fila = tablefrecs.NewRow();
                fila["Límite Inferior"] = limInf[i].ToString("0.0000");
                fila["Límite Superior"] = limSup[i].ToString("0.0000");
                fila["Frecuencia Observada"] = frecObs[i];
                tablefrecs.Rows.Add(fila);
            }
            dgvFrecuencias.DataSource = tablefrecs;
            dgvFrecuencias.Visible = true;
            btnGraficar.Enabled = true;
            btnGraficar.Focus();


>>>>>>> 34995c1 (Exponencial con fe)
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
<<<<<<< HEAD
            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                double lambda = (1 / param);
                return (-1 / lambda) * Math.Log(1 - pseudo);
=======
            return (-1 / (double)txtParam.Value) * Math.Log(1 - pseudo);
        }

        private double lambdaOrMeanValidation(double param)
        {
            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                return (1 / param);
>>>>>>> 34995c1 (Exponencial con fe)
            }
            return (-1 / (double) txtParam.Value) * Math.Log(1 - pseudo);
        }
    }
}
