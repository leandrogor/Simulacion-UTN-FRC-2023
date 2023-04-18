using SIM_TP2.Histogramas;
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
            btnGraficar.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvExponencial.Rows.Clear();  
            
            // Se llama a la funcion para validar los campos
            if (validar() == false) { return; }

            int Muestra = int.Parse(txtCantidad.Text);
            int cantidadIntervalos = int.Parse(boxIntervalos.Text); // cantidad de intervalos
            List<double> exponentialNumbersList = negativeExponentialSerie(Muestra, lambdaOrMeanValidation((double)txtParam.Value));
            double correction = 0.0001;
            double maxx = exponentialNumbersList.Max<double>() + correction; // Limite inferior
            double minx = exponentialNumbersList.Min<double>(); // Limite superior

            double longintervalos = (maxx - minx) / cantidadIntervalos;


            double[] limInf = new double[cantidadIntervalos];
            double[] limSup = new double[cantidadIntervalos];

            double Lambda = lambdaOrMeanValidation((double)txtParam.Value);
            double[] frecEsp = new double[cantidadIntervalos];
            if (esMedia())
            {
                Lambda = (1 / Lambda);
            }
            // Se definen los intervalos y se cargan las frecuencias esperadas
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                limInf[i] = minx + i * longintervalos;
                limSup[i] = limInf[i] + longintervalos;
                frecEsp[i] = (1 - (Math.Exp(-Lambda * limSup[i])) - (1 - (Math.Exp(-Lambda * limInf[i])))) * Muestra;
            }

            // Se calculan las frecuencias observadas
            int[] frecObs = new int[cantidadIntervalos];

            for (int i = 0; i < Muestra; i++)
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
            tablefrecs.Columns.Add("Numero");
            tablefrecs.Columns.Add("Límite Inferior");
            tablefrecs.Columns.Add("Límite Superior");
            tablefrecs.Columns.Add("Frecuencia Observada");
            tablefrecs.Columns.Add("Frecuencia Esperada");
            

            // Se recorre tantas veces como intervalos y se cargan los valores por fila
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataRow fila = tablefrecs.NewRow();
                fila["Numero"] = i+1;
                fila["Límite Inferior"] = limInf[i].ToString("0.0000");
                fila["Límite Superior"] = limSup[i].ToString("0.0000");
                fila["Frecuencia Observada"] = frecObs[i];
                fila["Frecuencia Esperada"] = frecEsp[i];
                tablefrecs.Rows.Add(fila);
            }

            dgvFrecuencias.DataSource = tablefrecs;
            dgvFrecuencias.Visible = true;
            btnGraficar.Enabled = true;
            btnGraficar.Focus();
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
                dgvExponencial.Rows.Add((i+1).ToString(), (double)num);

            }

            return lista;
        }

        // Funcion validadora de campos
        private bool validar()
        {
            if (int.Parse(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de valores a generar");
                return false;
            }
            if (boxIntervalos.SelectedIndex == -1)
            {
                string text = "Seleccione un intervalo";
                MessageBox.Show(text);
                return false;
            }

            if (cbxParam.SelectedIndex == -1)
            {
                string text = "Defina que parametro desea utilizar";
                MessageBox.Show(text);
                return false;
            }

            return true;
        }

        private double negativeExponentialGenerator(double pseudo, double param)
        {

            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                double lambda = (1 / param);
                return (-1 / lambda) * Math.Log(1 - pseudo);

            }
            return (-1 / (double)txtParam.Value) * Math.Log(1 - pseudo);  
        }

        private bool esMedia()
        {
            if (cbxParam.SelectedItem.ToString() == "Media")
            {
                return true;
            }

            return false;
        }

        private double lambdaOrMeanValidation(double param)
        {
            if (esMedia())
            {
                return (1 / param);
            }
        return param;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            
            HistoExponencial ventana = new HistoExponencial();
            ventana.crearHisto(dgvFrecuencias);
            ventana.Show();  
            ventana.FormClosed += LogOut;
            Hide();
        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void Exponencial_Load(object sender, EventArgs e)
        {

        }
    } 
}

