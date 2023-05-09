using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIM_TP2.TP3
{
    public partial class consigna : Form
    {
        public consigna()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnTP3_Click(object sender, EventArgs e)
        {
            presentaciontp3 ventana = new presentaciontp3();
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
