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

namespace SIM_TP2.Histogramas
{
    public partial class HistoUniforme : Form
    {
        public HistoUniforme()
        {
            InitializeComponent();
        }

        public void crearHisto(DataGridView dgvFrecuencias)
        {
            chrUniforme.Series[0].Points.Clear();
            chrUniforme.Visible = true;
            chrUniforme.ChartAreas[0].AxisY.Title = "Frecuencia Observada";
            chrUniforme.ChartAreas[0].AxisY.Minimum = 0;

            // Establecer el tipo de gráfico en Column
            chrUniforme.Series[0].ChartType = SeriesChartType.Column;

            // Ajustar el ancho de las columnas
            chrUniforme.Series[0]["PointWidth"] = "1";

            // Ajustar el desplazamiento del intervalo
            chrUniforme.ChartAreas[0].AxisX.IntervalOffset = 0.5;

            // Establecer IsXValueIndexed en true
            chrUniforme.Series[0].IsXValueIndexed = true;

            // Ocultar las líneas de la cuadrícula vertical
            chrUniforme.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chrUniforme.Series[0].IsValueShownAsLabel = true;

            chrUniforme.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            for (int i = 0; i < dgvFrecuencias.Rows.Count; i++)
            {
                var limiteInferior = Convert.ToDouble(dgvFrecuencias.Rows[i].Cells[1].Value);
                var limiteSuperior = Convert.ToDouble(dgvFrecuencias.Rows[i].Cells[2].Value);
                var frecuenciaObservada = Convert.ToDouble(dgvFrecuencias.Rows[i].Cells[3].Value);

                string xValue = $"[{limiteInferior.ToString("0.00")}, {limiteSuperior.ToString("0.00")})";

                chrUniforme.Series[0].Points.AddXY(xValue, frecuenciaObservada);
            }
        }
    }
}
