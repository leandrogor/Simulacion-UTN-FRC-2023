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
            chrUniforme.ChartAreas[0].AxisX.IntervalAutoMode = (System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode)1;
            chrUniforme.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrUniforme.Series[0].IsValueShownAsLabel = true;


            chrUniforme.Series[0]["PointWitdh"] = "0,5";
            for (int i = 0; i < dgvFrecuencias.Rows.Count; i++)
            {
                var valor = dgvFrecuencias.Rows[i].Cells[0].Value;
                var fre_abs = dgvFrecuencias.Rows[i].Cells[3].Value;
                chrUniforme.Series[0].Points.AddXY(valor, fre_abs);
            }

        }
    }
}
