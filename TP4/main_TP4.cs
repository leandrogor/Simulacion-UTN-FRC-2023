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

        public void mostrarFilaInicio(int iteracion, double reloj, double rndFutbol, double proximaLlegadaFutbol, double rndBasket, double proximaLlegadaBasket, double rndHandBa, double proximaLlegadaHandBall, string estadoInicialCancha, List<IDisciplina> colaInicial)
        {
            mostrarColumnasInicio(iteracion, "Inicio", reloj, 0);
            dgv_cola.Rows[0].Cells["RND1"].Value = rndFutbol;
            dgv_cola.Rows[0].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol;
            dgv_cola.Rows[0].Cells["RND2"].Value = rndHandBa;
            dgv_cola.Rows[0].Cells["ProxLlegadaH"].Value = proximaLlegadaBasket;
            dgv_cola.Rows[0].Cells["RND3"].Value = rndBasket;
            dgv_cola.Rows[0].Cells["ProxLlegadaB"].Value = proximaLlegadaHandBall;

            dgv_cola.Rows[0].Cells["EstadoCola"].Value = estadoInicialCancha;

            mostrarCola(colaInicial);

        }

        private void mostrarColumnasInicio(int iteracion, string evento, double reloj, int fila)
        {
            dgv_cola.Rows[fila].Cells["Numero"].Value = iteracion;
            dgv_cola.Rows[fila].Cells["NombreEvento"].Value = evento;
            dgv_cola.Rows[fila].Cells["Reloj"].Value = reloj;
        }

        private void mostrarCola(List<IDisciplina> cola)
        {
            if (cola == null || cola.Count == 0) return;

        }
        public void agregarFilaDeIteracion(int filaAMostrar, int iteracion, double reloj, object evento, double rndFutbol, double proximaLlegadaFutbol, double rndBasket, 
            double proximaLlegadaBasket, double rndHandBa, double proximaLlegadaHandBall, double rndFinJuego, double proximoFinJuego)
        {
            mostrarColumnasInicio(iteracion, evento.ToString(), reloj, filaAMostrar);
            if (filaAMostrar == 1) filaPrimeraIteracion(rndFutbol, rndHandBa, rndBasket, rndFinJuego); //para mostrar los rnd que generaron cada una de las llegadas y el fin juego
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol;
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaH"].Value = proximaLlegadaBasket;
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaB"].Value = proximaLlegadaHandBall;

            if (evento.Equals(""))

                dgv_cola.Rows[filaAMostrar].Cells[""];

            dgv_cola.Rows[1].Cells["ProxFinJuego"].Value = proximoFinJuego;


        }

        private void filaPrimeraIteracion(double rndFutbol, double rndHandBa, double rndBasket, double rndFinJuego)
        {
            dgv_cola.Rows[1].Cells["RND1"].Value = rndFutbol;
            dgv_cola.Rows[1].Cells["RND2"].Value = rndHandBa;
            dgv_cola.Rows[1].Cells["RND3"].Value = rndBasket;
            dgv_cola.Rows[1].Cells["RND4"].Value = rndFinJuego;
        }

        public void agregarFila()
        {

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
                },
                this);

            gestor.iniciar((double)horasSimular.Value, (double)horaInicioMostrar.Value, (int)eventosAMostrar.Value);
        }

    }
}
