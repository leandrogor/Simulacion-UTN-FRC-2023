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
        public GrillaIntegracionNumerica()
        {
            InitializeComponent();
        }

        public void mostrarGrilla(List<List<double>> euler)
        {
            for(int i = 0; i<euler.Count; i++)
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
