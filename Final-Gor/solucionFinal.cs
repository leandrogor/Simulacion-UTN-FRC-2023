using SIM_TP2.Final_Gor.Entidades;
using SIM_TP2.TP4.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.Final_Gor
{
    public partial class solucionFinal : Form
    {
        int iteraciones = 0;
        double reloj = 0;
        string evento = "";

        int contadorCredito = 0;
        double acTiempoCredito = 0;

        Cliente cli = new Cliente();
        Vendedor ven1 = new Vendedor();
        Vendedor ven2 = new Vendedor();
        Entrega ent = new Entrega();

        Queue<Cliente> colaClientes = new Queue<Cliente>();
        Queue<Cliente> colaCredito = new Queue<Cliente>();
        Queue<Cliente> colaContado = new Queue<Cliente>();

        static Random seed = new Random();
        Random rndLlegada = new Random(seed.Next());
        Random rndTipoCompra = new Random(seed.Next());
        Random rndAtencion = new Random(seed.Next());

        bool nuevaAtencion1;
        bool nuevaAtencion2;

        public solucionFinal()
        {
            InitializeComponent();
            //iniciar();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        public void iniciar()
        {
            ReiniciarVariables();

            Cliente.min = (double)minLleg.Value;
            Cliente.max = (double)maxLleg.Value;
            Cliente.prob_credito = (double)probabilidad.Value;
            Vendedor.min = (double)minAt.Value;
            Vendedor.max = (double)maxAt.Value;
            Entrega.tiempo = (double)reparto.Value;

            cli = new Cliente(reloj, rndLlegada.NextDouble(), rndTipoCompra.NextDouble());
            dgvFinal.Rows.Add(0, 0, "Inicio", cli.Rnd.ToString("0.00"), cli.TpoLlegada.ToString("0.00"), cli.ProxLlegada.ToString("0.00"),
                cli.RndCompra.ToString("0.00"), cli.TipoCompra, "", "", "", "", "", "", 0, 0, 0, "", "", 0, 0);

            while (iteraciones < iteracionesSim.Value)
            {
                iteraciones++;
                (reloj, evento) = obtenerProximoEvento();
                nuevaAtencion1 = false;
                nuevaAtencion2 = false;

                if (evento == "Llegada Cliente")
                {
                    if (ven1.ProxFinAtencion == double.MaxValue)
                    {
                        ven1.atenderCliente(reloj, rndAtencion.NextDouble(), cli);
                        nuevaAtencion1 = true;
                    }
                    else if (ven2.ProxFinAtencion == double.MaxValue)
                    {
                        ven2.atenderCliente(reloj, rndAtencion.NextDouble(), cli);
                        nuevaAtencion2 = true;
                    }
                    else
                    {
                        colaClientes.Enqueue(cli);
                    }
                    cli = new Cliente(reloj, rndLlegada.NextDouble(), rndTipoCompra.NextDouble());
                }
                else if (evento == "Fin At Ven 1")
                {
                    ven1.finAtencion(reloj, ref colaCredito, ref colaContado);
                    if (colaClientes.Count > 0)
                    {
                        ven1.atenderCliente(reloj, rndAtencion.NextDouble(), colaClientes.Dequeue());
                    }
                    verFurgon();
                }
                else if (evento == "Fin At Ven 2")
                {
                    ven2.finAtencion(reloj, ref colaCredito, ref colaContado);
                    if (colaClientes.Count > 0)
                    {
                        ven2.atenderCliente(reloj, rndAtencion.NextDouble(), colaClientes.Dequeue());
                    }
                    verFurgon();
                }
                else
                {
                    // Si la entrega era la última, que vea si tiene que empezar otra
                    if (ent.esUltimaEntrega(reloj, ref contadorCredito, ref acTiempoCredito)) verFurgon();
                }

                dgvFinal.Rows.Add(
                    iteraciones, reloj.ToString("0.00"), evento,

                    evento == "Llegada Cliente" ? cli.Rnd.ToString("0.00") : "",
                    evento == "Llegada Cliente" ? cli.TpoLlegada.ToString("0.00") : "",
                    cli.ProxLlegada.ToString("0.00"),
                    evento == "Llegada Cliente" ? cli.RndCompra.ToString("0.00") : "",
                    evento == "Llegada Cliente" ? cli.TipoCompra : "",

                    nuevaAtencion1 ? ven1.Rnd.ToString("0.00") : (nuevaAtencion2 ? ven2.Rnd.ToString("0.00") : ""),
                    nuevaAtencion1 ? ven1.TpoAtencion.ToString("0.00") : (nuevaAtencion2 ? ven2.TpoAtencion.ToString("0.00") : ""),
                    ven1.ProxFinAtencion == double.MaxValue ? "" : ven1.ProxFinAtencion.ToString("0.00"),
                    ven1.ProxFinAtencion == double.MaxValue ? "" : ven1.Cliente.TipoCompra,
                    ven2.ProxFinAtencion == double.MaxValue ? "" : ven2.ProxFinAtencion.ToString("0.00"),
                    ven2.ProxFinAtencion == double.MaxValue ? "" : ven2.Cliente.TipoCompra,

                    colaClientes.Count.ToString(), colaCredito.Count.ToString(), colaContado.Count.ToString(),
                    ent.ProxEntrega == double.MaxValue ? "" : (ent.ColaEntregas.Count + 1).ToString(),
                    ent.ProxEntrega == double.MaxValue ? "" : ent.ProxEntrega.ToString("0.00"),

                    contadorCredito, acTiempoCredito.ToString("0.00"),

                    ent.ProxEntrega == double.MaxValue ? "" : ent.ProxCliente.TipoCompra,
                    ent.ProxEntrega == double.MaxValue ? "" : ent.ProxCliente.InicioEspera.ToString("0.00")
                    );

            }

            lblRespuesta.Text = contadorCredito != 0 ? (acTiempoCredito / contadorCredito).ToString("0.00") : "0";
            grpRes.Visible = true;
        }

        public (double, string) obtenerProximoEvento()
        {
            List<double> tiempos = new List<double> { cli.ProxLlegada, ven1.ProxFinAtencion, ven2.ProxFinAtencion, ent.ProxEntrega };
            double menorTiempo = tiempos.Min();
            if (menorTiempo == cli.ProxLlegada) return (menorTiempo, "Llegada Cliente");
            else if (menorTiempo == ven1.ProxFinAtencion) return (menorTiempo, "Fin At Ven 1");
            else if (menorTiempo == ven2.ProxFinAtencion) return (menorTiempo, "Fin At Ven 2");
            else return (menorTiempo, "Fin Entrega");
        }

        public void verFurgon()
        {
            if (ent.ProxEntrega == double.MaxValue)
            {
                if (colaContado.Count >= 1)
                {
                    ent.iniciarEntrega(reloj, ref colaContado);
                }
                else if (colaCredito.Count >= 4)
                {
                    ent.iniciarEntrega(reloj, ref colaCredito);
                }
            }
        }

        private void ReiniciarVariables()
        {
            iteraciones = 0;
            reloj = 0;
            evento = "";

            contadorCredito = 0;
            acTiempoCredito = 0;

            cli = new Cliente();
            ven1 = new Vendedor();
            ven2 = new Vendedor();
            ent = new Entrega();

            colaClientes = new Queue<Cliente>();
            colaCredito = new Queue<Cliente>();
            colaContado = new Queue<Cliente>();

            seed = new Random();
            rndLlegada = new Random(seed.Next());
            rndTipoCompra = new Random(seed.Next());
            rndAtencion = new Random(seed.Next());
            dgvFinal.Rows.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
