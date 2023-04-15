using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP2.Histogramas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIM_TP2.Generadores
{
    public partial class Uniforme : Form
    {
        public Uniforme()
        {
            InitializeComponent();
            boxIntervalos.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvUniforme.Rows.Clear();
            dgvFrecuencias.Rows.Clear();

            // Si no cargó cantidad de intervalos, le asignamos el valor 10.
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "10";
            }

            int n = int.Parse(txtCantidad.Text);  // tamaño de muestra
            int cantidadIntervalos = int.Parse(boxIntervalos.Text); // cantidad de intervalos

            double min = Convert.ToDouble(txtA.Text); // límite inferior
            double max = Convert.ToDouble(txtB.Text); // límite superior

            // Si los cargó al revés, los damos vuelta
            if (min > max)
            {
                double temp = min; min = max; max = temp;
                txtA.Text = min.ToString();
                txtB.Text = max.ToString();
            }

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
                double valor = Math.Round(rnd.NextDouble() * (max - min) + min, 4);

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
                dgvUniforme.Rows.Add((i+1).ToString(), valor.ToString());
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

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            HistoUniforme ventana = new HistoUniforme();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
