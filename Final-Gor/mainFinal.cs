using SIM_TP2.TP5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Final_Gor
{
    public partial class mainFinal : Form
    {
        public mainFinal()
        {
            InitializeComponent();
        }

        private void btnConsigna_Click(object sender, EventArgs e)
        {
            consignaFinal ventana = new consignaFinal();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            solucionFinal ventana = new solucionFinal();
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
