using SIM_TP2.Generadores;
using SIM_TP2.Utils;
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

namespace SIM_TP2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            Uniforme ventana = new Uniforme();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            Exponencial ventana = new Exponencial();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Normal ventana = new Normal();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Integrantes ventana = new Integrantes();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }
    }
}
