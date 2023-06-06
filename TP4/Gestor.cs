using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Gestor
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
        private Limpieza limpieza;

        private main_TP4 pantalla;

        private int iteraciones;
        private object evento;

        private List<object> utlimoEvento = new List<object>();

        public Gestor(double tiempoLimpieza, List<List<double>> llegadas, List<List<double>> ocupaciones, main_TP4 pantalla)
        {

            this.pantalla = pantalla;

            Futbol.setFutbol(llegadas[0][0], ocupaciones[0][0], ocupaciones[0][1]);
            HandBall.setHandBall(llegadas[1][0], llegadas[1][1], ocupaciones[1][0], ocupaciones[1][1]);
            BasketBall.setBasketBall(llegadas[2][0], llegadas[2][1], ocupaciones[2][0], ocupaciones[2][1]);

            cancha = new Cancha();
            futbol = new Futbol(reloj, rndF.NextDouble());
            handBall = new HandBall(reloj, rndH.NextDouble());
            basketBall = new BasketBall(reloj, rndB.NextDouble());
            limpieza = new Limpieza(tiempoLimpieza);

            double rndFutbol = rndF.NextDouble();
            double rndBasket = rndB.NextDouble();
            double rndHandBa = rndH.NextDouble();

            string estadoInicialCancha = "Libre";

            pantalla.mostrarFilaInicio(0, reloj, rndFutbol, futbol.ProximaLlegada, rndBasket, basketBall.ProximaLlegada, rndHandBa, handBall.ProximaLlegada, estadoInicialCancha, null);

            Console.WriteLine();
            Console.WriteLine(rndFutbol);
            Console.WriteLine(rndBasket);
            Console.WriteLine(rndHandBa);
            Console.WriteLine();
            Console.WriteLine(reloj);
            Console.WriteLine(futbol.ProximaLlegada);
            Console.WriteLine(handBall.ProximaLlegada);
            Console.WriteLine(basketBall.ProximaLlegada);
            Console.WriteLine();
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


                Console.WriteLine("Iteración: " + (iteraciones + 1));
                Console.WriteLine("Reloj: " + reloj);
                Console.WriteLine(evento);

                if (evento is Cancha)
                {
                    limpieza.generarProximaLimpieza(reloj);
                    cancha.HoraFin = Double.MaxValue;
                    cancha.Jugando.Estado = null;
                }
                else if (evento is Limpieza)
                {
                    limpieza.ProximaLimpieza = Double.MaxValue;
                    cancha.iniciarProximoJuego(reloj, ref acEspF, ref acEspH, ref acEspB);
                    Console.WriteLine("Proximo fin juego: " + cancha.HoraFin);
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
                    iteraciones, evento, reloj,
                    futbol.ProximaLlegada,
                    basketBall.ProximaLlegada, 
                    handBall.ProximaLlegada, 
                    cancha.HoraFin, 
                    limpieza.ProximaLimpieza, cancha.Libre,
                    cancha.ColaFH, cancha.ColaB, 
                    acGrupos, acRetirados, acLlegF, acLlegH, acLlegB, acEspF, acEspH, acEspB

                });

                iteraciones++;

                Console.WriteLine();


            }

            calcularEstadisticos();
            pantalla.MostrarUltimaFila(utlimoEvento);
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
            else if (evento is Limpieza)
            {
                return ((Limpieza)evento).ProximaLimpieza;
            }
            else
            {
                return ((IDisciplina)evento).ProximaLlegada;
            }
        }

        private void calcularEstadisticos()
        {
            
            string promEsperaF = (acEspF/acLlegF).ToString();
            string promEsperaH = (acEspF/acLlegH).ToString();
            string promEsperaB = (acEspF/acLlegB).ToString();
            string porcenRetSinJugar = (acRetirados/acGrupos*100).ToString();

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
