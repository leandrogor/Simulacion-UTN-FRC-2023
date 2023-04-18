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
using SIM_TP2.Abst.Normal;

namespace SIM_TP2.Histogramas
{
    public partial class HistoNormal : Form
    {
        public HistoNormal()
        {
            InitializeComponent();
        }

        private void formLoad(object sender, EventArgs e)
        {
            int n = ChartDTO.frecuencias.Length;
            chartFreq.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartFreq.ChartAreas[0].AxisX.Interval = 1;


            for (int i = 0; i < n; i++)
            {
                string label = "[" + ChartDTO.limitesInferiores[i].ToString("N1") + "-" + ChartDTO.limitesSuperiores[i].ToString("N1") + ")";
                chartFreq.Series["Frecuencias"].Points.Add(ChartDTO.frecuencias[i]);
                chartFreq.Series["Frecuencias"].Points[i].AxisLabel = label;
                chartFreq.Series["Frecuencias"].Points[i].LegendText = label;
                chartFreq.Series["Frecuencias"].Points[i].Label = ChartDTO.frecuencias[i].ToString();

            }
        }

        private void chartFreq_Click(object sender, EventArgs e)
        {

        }
    }
}
