using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP2.Generadores;
using SIM_TP2.TP4.Entidades;

namespace SIM_TP2.TP4
{
    public partial class main_TP4 : Form
    {
        public main_TP4()
        {
            InitializeComponent();
        }

        private void main_TP4_Load(object sender, EventArgs e)
        {

        }

        private void dgv_cola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            gestor.iniciar(10, 1, 0, 0.167, 
                new List<List<double>>
                {
                    new List<double> { 10 },
                    new List<double> { 1, 2 },
                    new List<double> { 1, 2 },
                }, 
                new List<List<double>>
                {
                    new List<double> { 1, 2 },
                    new List<double> { 1, 2 },
                    new List<double> { 1, 2 },
                }
                );
        }

        //Utilizar los generadores anteriores para los RND  de las llegadas 
    }
}
