using SIM_TP2.TP4.Entidades;
using SIM_TP2.TP5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SIM_TP2.TP5
{
    public partial class solucionTP5 : Form
    {
        bool mostrarRND4 = true;
        Gestor2 gestor;

        public solucionTP5()
        {
            InitializeComponent();
            dgv_cola.CellFormatting += dgv_cola_CellFormatting;
            dgv_final.CellFormatting += dgv_final_CellFormatting;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dgv_cola.Rows.Clear();
            dgv_final.Rows.Clear();

            // Agregar al dgv tantas filas como cantidad de eventos se piden para mostrar
            for (int i = 0; i < (int)eventosAMostrar.Value + 1; i++) dgv_cola.Rows.Add();
            dgv_final.Rows.Add();

            gestor = new Gestor2(

                (double)hEuler.Value,
                (double)dFutbol.Value,
                (double)dHandBall.Value,
                (double)dBasketBall.Value,

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void agregarFilaDeIteracion(int filaAMostrar, int iteracion, double reloj, object evento, double rndFutbol, double proximaLlegadaFutbol, double rndBasket,
            double proximaLlegadaBasket, double rndHandBa, double proximaLlegadaHandBall, double rndFinJuego, double proximoFinJuego, double finLimpieza, bool libre, double tiempoLimpieza)
        {
            if (evento is Limpieza)
            {
                mostrarRND4 = true;
            }
            mostrarColumnasInicio(iteracion, evento.ToString(), reloj, filaAMostrar);

            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol.ToString("0.00");
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaH"].Value = proximaLlegadaHandBall.ToString("0.00");
            dgv_cola.Rows[filaAMostrar].Cells["ProxLlegadaB"].Value = proximaLlegadaBasket.ToString("0.00");

            dgv_cola.Rows[filaAMostrar].Cells["EstadoCola"].Value = libre ? "Libre" : "Ocupado";

            if (proximoFinJuego != Double.MaxValue)
            {
                dgv_cola.Rows[filaAMostrar].Cells["ProxFinJuego"].Value = proximoFinJuego.ToString("0.00");
                if (mostrarRND4)
                {
                    dgv_cola.Rows[filaAMostrar].Cells["RND4"].Value = rndFinJuego.ToString("0.00");
                    mostrarRND4 = false;
                }
            }
            if (finLimpieza != Double.MaxValue)
            {
                dgv_cola.Rows[filaAMostrar].Cells["TiempoLimpieza"].Value = tiempoLimpieza.ToString("0.00");
                dgv_cola.Rows[filaAMostrar].Cells["FinLimpieza"].Value = finLimpieza.ToString("0.00");
            }

            if (evento is IDisciplina)
            {
                IDisciplina disciplina = (IDisciplina)evento;
                string columnaRnd = "";
                if (disciplina is Futbol) columnaRnd = "RND1";
                else if (disciplina is HandBall) columnaRnd = "RND2";
                else columnaRnd = "RND3";
                dgv_cola.Rows[filaAMostrar].Cells[columnaRnd].Value = disciplina.RndUtilizado.ToString("0.00");
            }
        }

        private void mostrarColumnasInicio(int iteracion, string evento, double reloj, int fila)
        {
            dgv_cola.Rows[fila].Cells["Numero"].Value = iteracion + 1;
            dgv_cola.Rows[fila].Cells["NombreEvento"].Value = evento;
            dgv_cola.Rows[fila].Cells["Reloj"].Value = reloj.ToString("0.00");
        }

        public void mostrarFilaInicio(double reloj, double rndFutbol, double proximaLlegadaFutbol, double rndHandBa, double proximaLlegadaHandBall, double rndBasket, double proximaLlegadaBasket, List<IDisciplina> colaInicial = null)
        {
            mostrarColumnasInicio(-1, "Inicio", reloj, 0);
            dgv_cola.Rows[0].Cells["RND1"].Value = rndFutbol.ToString("0.00");
            dgv_cola.Rows[0].Cells["ProxLlegadaF"].Value = proximaLlegadaFutbol.ToString("0.00");
            dgv_cola.Rows[0].Cells["RND2"].Value = rndHandBa.ToString("0.00");
            dgv_cola.Rows[0].Cells["ProxLlegadaH"].Value = proximaLlegadaBasket.ToString("0.00");
            dgv_cola.Rows[0].Cells["RND3"].Value = rndBasket.ToString("0.00");
            dgv_cola.Rows[0].Cells["ProxLlegadaB"].Value = proximaLlegadaHandBall.ToString("0.00");
            dgv_cola.Rows[0].Cells["EstadoCola"].Value = "Libre";
            dgv_cola.Rows[0].Cells["ColaFH"].Value = 0;
            dgv_cola.Rows[0].Cells["ColaB"].Value = 0;
            mostrarCola(colaInicial, 0);
        }

        public void agregarCola(int filaAMostrar, IDisciplina jugando, Queue<IDisciplina> colaFH, Queue<IDisciplina> colaB)
        {
            dgv_cola.Rows[filaAMostrar].Cells["ColaFH"].Value = colaFH.Count;
            dgv_cola.Rows[filaAMostrar].Cells["ColaB"].Value = colaB.Count;
            Queue<IDisciplina> colaFHcopy = new Queue<IDisciplina>(colaFH);
            Queue<IDisciplina> colaBcopy = new Queue<IDisciplina>(colaB);
            List<IDisciplina> disciplinas = new List<IDisciplina>();

            if (jugando is BasketBall)
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
            // Sirve para juntar las dos colas
            Queue<T> mergedQueue = new Queue<T>(queue1);
            while (queue2.Count > 0)
            {
                mergedQueue.Enqueue(queue2.Dequeue());
            }

            return mergedQueue.ToList();
        }

        private void mostrarCola(List<IDisciplina> cola, int filaAMostrar)
        {
            if (cola == null || cola.Count == 0) return;
            for (int i = 1; i <= cola.Count; i++)
            {
                if (cola[i - 1] == null || cola[i - 1].Estado == null) continue;
                dgv_cola.Rows[filaAMostrar].Cells["TipoCliente" + i.ToString()].Value = cola[i - 1].Nombre();
                dgv_cola.Rows[filaAMostrar].Cells["EstadoCliente" + i.ToString()].Value = cola[i - 1].Estado;
                dgv_cola.Rows[filaAMostrar].Cells["HoraLlegadaCliente" + i.ToString()].Value = cola[i - 1].ProximaLlegada.ToString("0.00");
            }
        }

        public void agregarEstadisticas(int filaAMostrar, int acGrupos, int acRetirados)
        {
            dgv_cola.Rows[filaAMostrar].Cells["AcLlegadaGrupos"].Value = acGrupos;
            dgv_cola.Rows[filaAMostrar].Cells["AcGruposRetirados"].Value = acRetirados;
        }

        public void agregarAcumulador(int filaAMostrar, int acLlegF, int acLlegH, int acLlegB, double acEspF, double acEspH, double acEspB)
        {
            dgv_cola.Rows[filaAMostrar].Cells["AcLlegF"].Value = acLlegF;
            dgv_cola.Rows[filaAMostrar].Cells["AcLlegHB"].Value = acLlegH;
            dgv_cola.Rows[filaAMostrar].Cells["AcLlegB"].Value = acLlegB;

            dgv_cola.Rows[filaAMostrar].Cells["AcEsperaF"].Value = acEspF.ToString("0.00");
            dgv_cola.Rows[filaAMostrar].Cells["AcEsperaH"].Value = acEspH.ToString("0.00");
            dgv_cola.Rows[filaAMostrar].Cells["AcEsperaB"].Value = acEspB.ToString("0.00");
        }

        public void MostrarUltimaFila(List<object> Ult)
        {
            for (int i = 0; i < Ult.Count; i++)
            {
                dgv_final.Rows[0].Cells[i].Value = Ult[i].ToString();
            }
        }

        public void limpiarFilas()
        {
            int ultimaFila = dgv_cola.Rows.Count - 1;
            while (ultimaFila >= 0)
            {
                DataGridViewRow fila = dgv_cola.Rows[ultimaFila];
                bool filaVacia = true;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null && !string.IsNullOrEmpty(celda.Value.ToString()))
                    {
                        filaVacia = false;
                        break;
                    }
                }
                if (filaVacia) dgv_cola.Rows.Remove(fila);
                else break;
                ultimaFila--;
            }

        }

        private void dgv_cola_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_cola.Columns[e.ColumnIndex].Name == "TiempoLimpieza")
            {
                var dataGridView = (DataGridView)sender;
                var cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.Style.ForeColor = Color.Blue;
                cell.Style.Font = new Font(dataGridView.Font, FontStyle.Underline);
                cell.Style.SelectionForeColor = Color.Blue;

                if(dgv_cola.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_cola.Cursor = Cursors.Hand;
                }
                else
                {
                    dgv_cola.Cursor = Cursors.Default;
                }
            }
        }

        private void dgv_final_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_final.Columns[e.ColumnIndex].Name == "TpoLimpieza")
            {
                var dataGridView = (DataGridView)sender;
                var cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.Style.ForeColor = Color.Blue;
                cell.Style.Font = new Font(dataGridView.Font, FontStyle.Underline);
                cell.Style.SelectionForeColor = Color.Blue;

                if (dgv_final.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_final.Cursor = Cursors.Hand;
                }
                else
                {
                    dgv_final.Cursor = Cursors.Default;
                }
            }
        }

        private void dgv_cola_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_cola.Columns[e.ColumnIndex].Name != "TiempoLimpieza") return;
            if (dgv_cola.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;

            int rowDondeEstaInfo = e.RowIndex - 1; //hay que encontrar la fila que no tenga un tiempoLimpieza para ver con qué datos se calculó el tiempo de limpieza
            while (dgv_cola.Rows[rowDondeEstaInfo].Cells[e.ColumnIndex].Value != null)
            {
                rowDondeEstaInfo--;
            }
            double d = 0;
            int c = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (dgv_cola.Rows[rowDondeEstaInfo].Cells["TipoCliente" + i.ToString()].Value == null) continue;

                if (dgv_cola.Rows[rowDondeEstaInfo].Cells["EstadoCliente" + i.ToString()].Value.Equals("Jugando"))
                {
                    if (dgv_cola.Rows[rowDondeEstaInfo].Cells["TipoCliente" + i.ToString()].Value.Equals(Futbol.nombre)) d = Futbol.d;
                    if (dgv_cola.Rows[rowDondeEstaInfo].Cells["TipoCliente" + i.ToString()].Value.Equals(HandBall.nombre)) d = HandBall.d;
                    if (dgv_cola.Rows[rowDondeEstaInfo].Cells["TipoCliente" + i.ToString()].Value.Equals(BasketBall.nombre)) d = BasketBall.d;
                }
                else
                {
                    c++;
                }
            }
            List<List<double>> euler = LimpiezaIntegracion.mostrarEuler(d, c);
            GrillaIntegracionNumerica ventana = new GrillaIntegracionNumerica(euler);
            Console.WriteLine("Valor D: " + d + "; Valor C: " + c);
            ventana.ShowDialog();
        }

        private void dgv_final_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_final.Columns[e.ColumnIndex].Name != "TpoLimpieza") return;
            if (dgv_final.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("")) return;

            double d;
            int c;
            (d, c) = gestor.obtenerParaMostrarLimpieza();

            List<List<double>> euler = LimpiezaIntegracion.mostrarEuler(d, c);
            GrillaIntegracionNumerica ventana = new GrillaIntegracionNumerica(euler);
            Console.WriteLine("Valor D: " + d + "; Valor C: " + c);
            ventana.ShowDialog();
        }
    }
}
