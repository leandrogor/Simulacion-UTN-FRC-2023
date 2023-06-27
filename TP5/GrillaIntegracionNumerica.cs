using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.TP5
{
    public partial class GrillaIntegracionNumerica : Form
    {
        public GrillaIntegracionNumerica(List<List<double>> euler)
        {
            InitializeComponent();
            mostrarGrilla(euler);
            dgv_integracion_numerica.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int totalWidth = dgv_integracion_numerica.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3;
            this.Width = totalWidth - 200;

            int totalHeight = dgv_integracion_numerica.ColumnHeadersHeight + dgv_integracion_numerica.Rows.Cast<DataGridViewRow>().Sum(row => row.Height);
            this.Height = totalHeight;
        }

        public void mostrarGrilla(List<List<double>> euler)
        {
            for (int i = 0; i<euler.Count; i++)
            {
                dgv_integracion_numerica.Rows.Add();
                for(int j = 0; j< euler[i].Count; j++)
                {
                    dgv_integracion_numerica.Rows[i].Cells[j].Value = euler[i][j]; 
                }
            }
        }
    }
}
