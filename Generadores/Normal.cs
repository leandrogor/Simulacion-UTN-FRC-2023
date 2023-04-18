using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SIM_TP2.Util.NormalUtil;
using SIM_TP2.Histogramas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIM_TP2.Generadores
{
    public partial class Normal : Form
    {
        private double[] limitesInferiores;
        private double[] limitesSuperiores;
        private int[] frecuencias;
        public Normal()
        {
            InitializeComponent();
            boxIntervalos.SelectedIndex = 0;
            comboMetodo.SelectedIndex = 0;
        }

        public List<double> NormalSerie(int n, double media, double desv, NormalDistributionCalculator calculator)
        {
            List<double> lista = new List<double>();
            for(int i = 0; i<n; i++)
            {
                double numeroGenerado = calculator.CalcularNumero(media, desv);
                lista.Add(Math.Round(numeroGenerado, 4));
            }
            return lista;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvNormal.Rows.Clear();

            // Se llama a la funcion para validar los campos
            if (validar() == false) { return; }

            int n = int.Parse(txtCantidad.Text);  // tamaño de muestra
            int cantidadIntervalos = int.Parse(boxIntervalos.Text); // cantidad de intervalos

            double media = Convert.ToDouble(txtA.Text); // media
            double desvi = Convert.ToDouble(txtB.Text); // desviación

            //Calculo de la serie de números aleatorios con distribución normal
            //Se implementa un patrón strategy para calcular los valores con los distintos métodos.
            NormalDistributionCalculator metodoSeleccionado = (NormalDistributionCalculator)comboMetodo.SelectedItem;
            List<double> serie = NormalSerie(n, media, desvi, metodoSeleccionado);

            //Obtención de valores máximos y mínimos para cálculo de intervalos.
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
            double[] frecuenciasEsperadas = new double[cantidadIntervalos];
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                //Marca de clase del intervalo.
                double marcaDeClase = (limitesSuperiores[i] + limitesInferiores[i])/2;

                //La frecuencia esperada se calculó obteniendo primero el valor de la función de densidad
                //en la marca de clase y después se multiplicó por la amplitud para obtener la probabilidad.
                //Por último se multiplica por la cantidad de observaciones para obtener la frecuencia esperada.
                //Esta forma es una aproximada ya que no se encontró una fórmula de la función de acumulación de la distribución normal.
                frecuenciasEsperadas[i] = funcionDistribucionNormal(marcaDeClase, media, desvi) * amplitud * n;
            }

            // Generación de los valores aleatorios y cálculo de las frecuencias observadas
            int[] frecuenciasObservadas = new int[cantidadIntervalos];
            int numeroDeFila = 0;
            foreach (double valor in serie)
            {
                // Actualización de frecuencia observada para el intervalo correspondiente
                for (int j = 0; j < cantidadIntervalos; j++)
                {
                    if (valor >= limitesInferiores[j] && valor < limitesSuperiores[j])
                    {
                        frecuenciasObservadas[j]++;
                        break;
                    }
                }
                dgvNormal.Rows.Add(++numeroDeFila, valor.ToString());
            }



            // Creación de la tabla de resultados
            DataTable tablaResultados = new DataTable();
            tablaResultados.Columns.Add("Numero");
            tablaResultados.Columns.Add("Límite Inferior");
            tablaResultados.Columns.Add("Límite Superior");
            tablaResultados.Columns.Add("Frecuencia Observada");
            tablaResultados.Columns.Add("Frecuencia Esperada");

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataRow fila = tablaResultados.NewRow();
                fila["Numero"] = i + 1;
                fila["Límite Inferior"] = limitesInferiores[i].ToString("0.0000");
                fila["Límite Superior"] = limitesSuperiores[i].ToString("0.0000");
                fila["Frecuencia Observada"] = frecuenciasObservadas[i];
                fila["Frecuencia Esperada"] = frecuenciasEsperadas[i].ToString("0.0000");
                tablaResultados.Rows.Add(fila);
            }

            this.limitesInferiores = limitesInferiores;
            this.limitesSuperiores = limitesSuperiores;
            this.frecuencias = frecuenciasObservadas;

            // Mostrar la tabla de resultados en un DataGridView
            dgvFrecuencias.DataSource = tablaResultados;

            dgvFrecuencias.Visible = true;
            btnGraficar.Enabled = true;
            btnGraficar.Focus();
        }

        private double funcionDistribucionNormal(double x, double media, double desvi)
        {
            double exponente = - (x - media) * (x - media) / (2 * desvi * desvi);
            double multiplicador = 1 / (desvi * Math.Sqrt(2 * Math.PI));
            return multiplicador * Math.Exp(exponente);
        }

        private void btnGraficarClick(object sender, EventArgs e)
        {
            HistoNormal ventana = new HistoNormal();
            ventana.Show();
            ventana.CrearHisto(dgvFrecuencias);
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }
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

            if (comboMetodo.SelectedIndex == -1)
            {
                string text = "Defina que metodo desea utilizar";
                MessageBox.Show(text);
                return false;
            }


            return true;
        }
        private void select_all(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            control.Select(0, control.Text.Length);
        }

        private void boxIntervalos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                boxIntervalos.DroppedDown = true;
                e.IsInputKey = true;
            }
        }

        private void comboMetodo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                comboMetodo.DroppedDown = true;
                e.IsInputKey = true;
            }
        }
    }

    
}
