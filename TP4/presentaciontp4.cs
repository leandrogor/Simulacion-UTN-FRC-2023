using System;
using System.Windows.Forms;

namespace SIM_TP2.TP4
{
    public partial class presentaciontp4 : Form
    {
        public presentaciontp4()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            consignatp4 ventana = new consignatp4();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            main_TP4 ventana = new main_TP4();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

    }
}
