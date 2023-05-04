﻿using SIM_TP2.Generadores;
using SIM_TP2.TP3;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIM_TP2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnTP1_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1EnwSdqRv1e5qPhd1Rg8W9G3Qgj8OqPo5J1cwQzCiu6g/edit?usp=sharing");
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btnTP2_Click(object sender, EventArgs e)
        {
            main_tp2 ventana = new main_tp2();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void btnTP3_Click(object sender, EventArgs e)
        {
            main_tp3 ventana = new main_tp3();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }
    }
}
