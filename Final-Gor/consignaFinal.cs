using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Final_Gor
{
    public partial class consignaFinal : Form
    {
        public consignaFinal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\Assets\\consignaFinal.jpg");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
