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
    public partial class mainTP5 : Form
    {
        public mainTP5()
        {
            InitializeComponent();
        }

        private void btnConsigna_Click(object sender, EventArgs e)
        {
            consignaTP5 ventana = new consignaTP5();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            solucionTP5 ventana = new solucionTP5();
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
