using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SIM_TP2.Abst.Uniforme;

namespace SIM_TP2.Histogramas
{
    public partial class HistoUniforme : Form
    {
        public HistoUniforme()
        {
            InitializeComponent();
        }

        private void HistoUniforme_Load(object sender, EventArgs e)
        {
            // Obtén el número de intervalos y los límites inferiores y superiores de los intervalos de la distribución uniforme
            int n = ChartDTO.frecuencias.Length;

            // Configura las propiedades del eje X del gráfico
            chartFreqUnif.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartFreqUnif.ChartAreas[0].AxisX.Interval = 1;

            // Genera los puntos del histograma
            for (int i = 0; i < n; i++)
            {
                // Calcula el rango del intervalo
                string label = "[" + ChartDTO.limitesInferiores[i].ToString("N1") + "-" + ChartDTO.limitesSuperiores[i].ToString("N1") + ")";

                // Agrega el punto al gráfico
                chartFreqUnif.Series["Frecuencias"].Points.Add(ChartDTO.frecuencias[i]);
                // Establece la etiqueta del eje X del punto
                chartFreqUnif.Series["Frecuencias"].Points[i].AxisLabel = label;
                // Establece el texto de leyenda del punto
                chartFreqUnif.Series["Frecuencias"].Points[i].LegendText = label;
                // Establece la etiqueta del punto
                chartFreqUnif.Series["Frecuencias"].Points[i].Label = ChartDTO.frecuencias[i].ToString();
            }
        }
    }
}

