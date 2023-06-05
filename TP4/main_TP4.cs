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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor(

                (double)tiempoLimpiezaCancha.Value / 60,

                new List<List<double>>
                {
                    new List<double> { (double)expNegFutbol.Value },
                    new List<double> { (double)minLlegHand.Value, (double)maxLlegHand.Value },
                    new List<double> { (double)minLlegBasc.Value, (double)maxLlegBasc.Value },
                },

                new List<List<double>>
                {
                    new List<double> { (double)minOcFut.Value / 60, (double)maxOcFut.Value / 60 },
                    new List<double> { (double)minOcHand.Value / 60, (double)maxOcFut.Value / 60 },
                    new List<double> { (double)minOcBasc.Value / 60, (double)maxOcBas.Value / 60 },
                });

            gestor.iniciar((double)horasSimular.Value, (double)horaInicioMostrar.Value, (int)eventosAMostrar.Value);
        }

    }
}
