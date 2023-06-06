using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP2.Generadores;
using SIM_TP2.TP3;
using SIM_TP2.TP4.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            mostrarColumnasInicio(-1, "Inicio", reloj, 0);
            dgv_cola.Rows[0].Cells["RND1"].Value = rndFutbol;
            dgv_cola.Rows[0].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol;
            dgv_cola.Rows[0].Cells["RND2"].Value = rndHandBa;
            dgv_cola.Rows[0].Cells["ProxLlegadaH"].Value = proximaLlegadaBasket;
            dgv_cola.Rows[0].Cells["RND3"].Value = rndBasket;
            dgv_cola.Rows[0].Cells["ProxLlegadaB"].Value = proximaLlegadaHandBall;

            dgv_cola.Rows[0].Cells["EstadoCola"].Value = estadoInicialCancha;
            dgv_cola.Rows[0].Cells["ColaFH"].Value = 0;
            dgv_cola.Rows[0].Cells["ColaB"].Value = 0;
            mostrarCola(colaInicial, 0);

        }

        private void mostrarColumnasInicio(int iteracion, string evento, double reloj, int fila)
        {
            dgv_cola.Rows[fila].Cells["Numero"].Value = iteracion+1;
            dgv_cola.Rows[fila].Cells["NombreEvento"].Value = evento;
            dgv_cola.Rows[fila].Cells["Reloj"].Value = reloj;
        }

        private void mostrarCola(List<IDisciplina> cola, int filaAMostrar)
        {
            if (cola == null || cola.Count == 0) return;
            for(int i = 1; i <= cola.Count; i++)
            {
                if (cola[i-1] == null || cola[i - 1].Estado == null) continue;
                dgv_cola.Rows[filaAMostrar].Cells["TipoCliente" + i.ToString()].Value = cola[i-1].Nombre();
                dgv_cola.Rows[filaAMostrar].Cells["EstadoCliente" + i.ToString()].Value = cola[i-1].Estado;
                dgv_cola.Rows[filaAMostrar].Cells["HoraLlegadaCliente" + i.ToString()].Value = cola[i-1].ProximaLlegada;
            }
        }
        public void agregarFilaDeIteracion(int filaAMostrar, int iteracion, double reloj, object evento, double rndFutbol, double proximaLlegadaFutbol, double rndBasket, 
            double proximaLlegadaBasket, double rndHandBa, double proximaLlegadaHandBall, double rndFinJuego, double proximoFinJuego, double finLimpieza, bool libre)
        {
            mostrarColumnasInicio(iteracion, evento.ToString(), reloj, filaAMostrar);
            

            //if (filaAMostrar == 1) filaPrimeraIteracion(rndFutbol, rndHandBa, rndBasket, rndFinJuego); //para mostrar los rnd que generaron cada una de las llegadas y el fin juego
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol;
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaH"].Value = proximaLlegadaHandBall;
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaB"].Value = proximaLlegadaBasket;

            dgv_cola.Rows[filaAMostrar].Cells["EstadoCola"].Value = libre ? "Libre" : "Ocupado";

            if (proximoFinJuego != Double.MaxValue)
            {
                dgv_cola.Rows[filaAMostrar].Cells["ProxFinJuego"].Value = proximoFinJuego;
                dgv_cola.Rows[filaAMostrar].Cells["RND4"].Value = rndFinJuego;
            }
            if (finLimpieza != Double.MaxValue) dgv_cola.Rows[filaAMostrar].Cells["FinLimpieza"].Value = finLimpieza;



            if(evento is IDisciplina)
            {
                IDisciplina disciplina = (IDisciplina)evento;
                string columnaRnd = "";
                if (disciplina is Futbol) columnaRnd = "RND1";
                else if (disciplina is HandBall) columnaRnd = "RND2";
                else columnaRnd = "RND3";
                dgv_cola.Rows[filaAMostrar].Cells[columnaRnd].Value = disciplina.RndUtilizado;
            }
            
            
        }
        public void agregarCola(int filaAMostrar, IDisciplina jugando, Queue<IDisciplina> colaFH, Queue<IDisciplina> colaB)
        {
            dgv_cola.Rows[filaAMostrar].Cells["ColaFH"].Value = colaFH.Count;
            dgv_cola.Rows[filaAMostrar].Cells["ColaB"].Value = colaB.Count;
            Queue<IDisciplina> colaFHcopy = new Queue<IDisciplina>(colaFH);
            Queue<IDisciplina> colaBcopy = new Queue<IDisciplina>(colaB);
            List<IDisciplina> disciplinas = new List<IDisciplina>();
            
            if(jugando is BasketBall)
            {
                colaFHcopy.Enqueue(jugando); 
                disciplinas = MergeQueues(colaFHcopy, colaBcopy);
            }
            else
            {
                disciplinas.Add(jugando);
                disciplinas.AddRange(MergeQueues(colaFHcopy, colaBcopy));
            }
            mostrarCola(disciplinas, filaAMostrar);
        }
        private List<T> MergeQueues<T>(Queue<T> queue1, Queue<T> queue2)
        {
            //sirve para juntar las dos colas
            Queue<T> mergedQueue = new Queue<T>(queue1);
            while (queue2.Count > 0)
            {
                mergedQueue.Enqueue(queue2.Dequeue());
            }

            return mergedQueue.ToList();
        }

        public void agregarEstadisticas(int filaAMostrar, int acGrupos, int acRetirados)
        {
            dgv_cola.Rows[filaAMostrar].Cells["AcLlegadaGrupos"].Value = acGrupos;
            dgv_cola.Rows[filaAMostrar].Cells["AcGruposRetirados"].Value = acRetirados;
        }

        private void filaPrimeraIteracion(double rndFutbol, double rndHandBa, double rndBasket, double rndFinJuego)
        {
            dgv_cola.Rows[1].Cells["RND1"].Value = rndFutbol;
            dgv_cola.Rows[1].Cells["RND2"].Value = rndHandBa;
            dgv_cola.Rows[1].Cells["RND3"].Value = rndBasket;
            dgv_cola.Rows[1].Cells["RND4"].Value = rndFinJuego;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            dgv_cola.Rows.Clear();
            for (int i = 0; i < (int)eventosAMostrar.Value + 1; i++) dgv_cola.Rows.Add();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {      
            Hide();
        }
    }
}
