using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Histogramas
{
    public partial class HistoExponencial : Form
    {
        public HistoExponencial()
        {
            InitializeComponent();
        }

        private void HistoExponencial_Load(object sender, EventArgs e)
        {

        }

        public void crearHisto(DataGridView dgvFrecuencias)
        {
            chrHistograma.Series[0].Points.Clear();
            chrHistograma.Visible = true;
            chrHistograma.ChartAreas[0].AxisY.Title = "Frecuencia Observada";
            chrHistograma.ChartAreas[0].AxisY.Minimum = 0;
            chrHistograma.ChartAreas[0].AxisX.IntervalAutoMode = (System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode)1;
            chrHistograma.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chrHistograma.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chrHistograma.ChartAreas[0].AxisY.IsMarginVisible = false;
            chrHistograma.Series[0].IsValueShownAsLabel = true;
            

            //chrHistograma.Series[0]["PointWitdh"] = "0,5";
            for (int i = 0; i < dgvFrecuencias.Rows.Count; i++)
            {

                var valor = dgvFrecuencias.Rows[i].Cells[0].Value;
                var fre_abs = dgvFrecuencias.Rows[i].Cells[3].Value;
                chrHistograma.Series[0].Points.AddXY(valor, fre_abs);

            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
