using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Utils
{
    public partial class Integrantes : Form
    {
        public Integrantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_tp2 ventana = new main_tp2();
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
