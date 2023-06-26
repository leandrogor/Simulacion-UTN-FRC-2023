using SIM_TP2.TP4.Entidades;
using SIM_TP2.TP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP2.TP5.Entidades;

namespace SIM_TP2.TP5
{
    public class Gestor2
    {
        private double reloj = 0;
        private int acGrupos = 0;
        private int acRetirados = 0;

        private int acLlegF = 0;
        private int acLlegH = 0;
        private int acLlegB = 0;

        private double acEspF = 0;
        private double acEspH = 0;
        private double acEspB = 0;

        private static Random seed = new Random();
        private Random rndF = new Random(seed.Next());
        private Random rndB = new Random(seed.Next());
        private Random rndH = new Random(seed.Next());

        private Cancha cancha;
        private Futbol futbol;
        private HandBall handBall;
        private BasketBall basketBall;
        private LimpiezaIntegracion limpieza;

        private solucionTP5 pantalla;

        private int iteraciones;
        private object evento;

        private List<object> utlimoEvento = new List<object>();

        public Gestor2(double h, double dFutbol, double dHandball, double dBasketBall, List<List<double>> llegadas, List<List<double>> ocupaciones, solucionTP5 pantalla)
        {
            this.pantalla = pantalla;

            Futbol.setFutbol(llegadas[0][0], ocupaciones[0][0], ocupaciones[0][1]);
            HandBall.setHandBall(llegadas[1][0], llegadas[1][1], ocupaciones[1][0], ocupaciones[1][1]);
            BasketBall.setBasketBall(llegadas[2][0], llegadas[2][1], ocupaciones[2][0], ocupaciones[2][1]);

            cancha = new Cancha();
            futbol = new Futbol(reloj, rndF.NextDouble());
            handBall = new HandBall(reloj, rndH.NextDouble());
            basketBall = new BasketBall(reloj, rndB.NextDouble());
            limpieza = new LimpiezaIntegracion(h);

            double rndFutbol = rndF.NextDouble();
            double rndHandBa = rndH.NextDouble();
            double rndBasket = rndB.NextDouble();

            futbol.D = dFutbol;
            handBall.D = dHandball;
            basketBall.D = dBasketBall;

            pantalla.mostrarFilaInicio(reloj, rndFutbol, futbol.ProximaLlegada, rndHandBa, handBall.ProximaLlegada, rndBasket, basketBall.ProximaLlegada);
        }

        public void iniciar(double tiempoASimular, double horaInicioAMostrar, int cantIterAMostrar)
        {
            int iteracionMostrada = 1;
            while (iteraciones < 100000)
            {
                evento = obtenerProximoEvento();
                reloj = getHoraActual(evento);

                if (reloj > tiempoASimular)
                {
                    break;
                }
                if (evento is Cancha)
                {
                    limpieza.generarProximaLimpieza(reloj, cancha.Jugando.D, cancha.ColaB.Count + cancha.ColaFH.Count);
                    cancha.HoraFin = Double.MaxValue;
                    cancha.Jugando.Estado = null;
                }
                else if (evento is LimpiezaIntegracion)
                {
                    limpieza.ProximaLimpieza = Double.MaxValue;
                    cancha.iniciarProximoJuego(reloj, ref acEspF, ref acEspH, ref acEspB);
                }
                else
                {
                    cancha.recibirDisciplina(reloj, (IDisciplina)evento, ref acRetirados);

                    if (evento is Futbol)
                    {
                        acLlegF++;
                        futbol = new Futbol(reloj, rndF.NextDouble());
                    }
                    else if (evento is HandBall)
                    {
                        acLlegH++;
                        handBall = new HandBall(reloj, rndH.NextDouble());
                    }
                    else
                    {
                        acLlegB++;
                        basketBall = new BasketBall(reloj, rndB.NextDouble());
                    }
                    acGrupos++;
                }

                if (reloj >= horaInicioAMostrar && iteracionMostrada <= cantIterAMostrar)
                {
                    pantalla.agregarFilaDeIteracion(iteracionMostrada, iteraciones, reloj, evento, futbol.RndUtilizado, futbol.ProximaLlegada,
                        basketBall.RndUtilizado, basketBall.ProximaLlegada, handBall.RndUtilizado, handBall.ProximaLlegada, cancha.RndUtilizado,
                        cancha.HoraFin, limpieza.ProximaLimpieza, cancha.Libre);
                    pantalla.agregarCola(iteracionMostrada, cancha.Jugando, cancha.ColaFH, cancha.ColaB);
                    pantalla.agregarEstadisticas(iteracionMostrada, acGrupos, acRetirados);
                    pantalla.agregarAcumulador(iteracionMostrada, acLlegF, acLlegH, acLlegB, acEspF, acEspH, acEspB);
                    iteracionMostrada++;
                }

                utlimoEvento.Clear();
                utlimoEvento.AddRange(new List<object> {
                    iteraciones+1, evento, reloj.ToString("0.00"),
                    futbol.ProximaLlegada.ToString("0.00"),
                    basketBall.ProximaLlegada.ToString("0.00"),
                    handBall.ProximaLlegada.ToString("0.00"),
                    cancha.HoraFin == double.MaxValue ? "" : cancha.HoraFin.ToString("0.00"),
                    limpieza.ProximaLimpieza == double.MaxValue ? "" : cancha.HoraFin.ToString("0.00"),
                    cancha.Libre ? "Libre" : "Ocupado",
                    cancha.ColaFH.Count(), cancha.ColaB.Count(),
                    acGrupos, acRetirados, acLlegF, acLlegH, acLlegB,
                    acEspF.ToString("0.00"), acEspH.ToString("0.00"), acEspB.ToString("0.00")
                });
                iteraciones++;
            }
            calcularEstadisticos();
            pantalla.MostrarUltimaFila(utlimoEvento);
            pantalla.limpiarFilas();
        }

        public object obtenerProximoEvento()
        {
            List<double> tiempos = new List<double> { cancha.HoraFin, futbol.ProximaLlegada, handBall.ProximaLlegada, basketBall.ProximaLlegada, limpieza.ProximaLimpieza };
            double menorTiempo = tiempos.Min();

            if (menorTiempo == cancha.HoraFin)
            {
                return cancha;
            }
            else if (menorTiempo == limpieza.ProximaLimpieza)
            {
                return limpieza;
            }
            else if (menorTiempo == futbol.ProximaLlegada)
            {
                return futbol;
            }
            else if (menorTiempo == handBall.ProximaLlegada)
            {
                return handBall;
            }
            else
            {
                return basketBall;
            }
        }

        private double getHoraActual(object evento)
        {
            if (evento is Cancha)
            {
                return ((Cancha)evento).HoraFin;
            }
            else if (evento is LimpiezaIntegracion)
            {
                return ((LimpiezaIntegracion)evento).ProximaLimpieza;
            }
            else
            {
                return ((IDisciplina)evento).ProximaLlegada;
            }
        }

        private void calcularEstadisticos()
        {
            string promEsperaF = acLlegF > 0 ? (acEspF / acLlegF).ToString("0.00") : "0";
            string promEsperaH = acLlegH > 0 ? (acEspF / acLlegH).ToString("0.00") : "0";
            string promEsperaB = acLlegB > 0 ? (acEspF / acLlegB).ToString("0.00") : "0";
            string porcenRetSinJugar = ((double)acRetirados / (double)acGrupos * 100).ToString("0.00") + "%";

            utlimoEvento.AddRange(new List<object>
            {
                promEsperaF,
                promEsperaH,
                promEsperaB,
                porcenRetSinJugar
            });

        }
    }
}

