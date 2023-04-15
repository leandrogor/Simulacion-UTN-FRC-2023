using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP2.Util.NormalUtil;

namespace SIM_TP2.Generadores
{
    public partial class Normal : Form
    {
        public Normal()
        {
            InitializeComponent();
            
        }

        public List<double> NormalSerie(int n, double media, double desv, NormalDistributionCalculator calculator)
        {
            List<double> lista = new List<double>();
            for(int i = 0; i<n; i++)
            {
                double numeroGenerado = calculator.CalcularNumero(media, desv);
                lista.Add(numeroGenerado);
            }
            return lista;
        }

        private void Normal_Load(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void txtA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvNormal.Rows.Clear();
            dgvFrecuencias.Rows.Clear();

            // Si no cargó cantidad de intervalos, le asignamos el valor 10.
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "10";
            }

            int n = int.Parse(txtCantidad.Text);  // tamaño de muestra
            int cantidadIntervalos = int.Parse(boxIntervalos.Text); // cantidad de intervalos

            double media = Convert.ToDouble(txtA.Text); // límite inferior
            double desvi = Convert.ToDouble(txtB.Text); // límite superior
            NormalDistributionCalculator metodoSeleccionado = (NormalDistributionCalculator)comboMetodo.SelectedItem;
            List<double> serie = NormalSerie(n, media, desvi, metodoSeleccionado);
            double max = serie.Max();
            double min = serie.Min();

            // Creación de los límites inferiores y superiores de los intervalos
            double amplitud = (max - min) / cantidadIntervalos;
            double[] limitesInferiores = new double[cantidadIntervalos];
            double[] limitesSuperiores = new double[cantidadIntervalos];
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                limitesInferiores[i] = min + i * amplitud;
                limitesSuperiores[i] = limitesInferiores[i] + amplitud;
            }

            // Cálculo de las frecuencias esperadas
            double frecuenciaEsperada = n / cantidadIntervalos;
            double[] frecuenciasEsperadas = new double[cantidadIntervalos];
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                frecuenciasEsperadas[i] = frecuenciaEsperada;
            }

            // Generación de los valores aleatorios y cálculo de las frecuencias observadas
            int[] frecuenciasObservadas = new int[cantidadIntervalos];
            // List<double> lista = new List<double>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                // Generación del valor aleatorio
                double valor = serie[i];

                // Actualización de frecuencia observada para el intervalo correspondiente
                for (int j = 0; j < cantidadIntervalos; j++)
                {
                    if (valor >= limitesInferiores[j] && valor < limitesSuperiores[j])
                    {
                        frecuenciasObservadas[j]++;
                        break;
                    }
                }

                // lista.Add(valor);
                dgvNormal.Rows.Add((i + 1).ToString(), valor.ToString());
            }



            // Creación de la tabla de resultados
            DataTable tablaResultados = new DataTable();
            tablaResultados.Columns.Add("Límite Inferior");
            tablaResultados.Columns.Add("Límite Superior");
            tablaResultados.Columns.Add("Frecuencia Observada");
            tablaResultados.Columns.Add("Frecuencia Esperada");

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataRow fila = tablaResultados.NewRow();
                fila["Límite Inferior"] = limitesInferiores[i].ToString("0.0000");
                fila["Límite Superior"] = limitesSuperiores[i].ToString("0.0000");
                fila["Frecuencia Observada"] = frecuenciasObservadas[i];
                fila["Frecuencia Esperada"] = frecuenciasEsperadas[i].ToString("0.0000");
                tablaResultados.Rows.Add(fila);
            }

            // Mostrar la tabla de resultados en un DataGridView
            dgvFrecuencias.DataSource = tablaResultados;

            dgvFrecuencias.Visible = true;
            btnGraficar.Enabled = true;
            btnGraficar.Focus();
        }

    }

    
}
