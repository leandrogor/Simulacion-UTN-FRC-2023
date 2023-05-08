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
    public partial class presentaciontp3 : Form
    {
        public presentaciontp3()
        {
            InitializeComponent();
        }

        private void btnTP3_Click(object sender, EventArgs e)
        {
            main_tp3 ventana = new main_tp3();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void consigna_Click(object sender, EventArgs e)
        {
            consigna ventana = new consigna();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }
    }
}
