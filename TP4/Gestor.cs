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

        private int acEspF = 0;
        private int acEspH = 0;
        private int acEspB = 0;

        private static Random seed = new Random();
        private Random rndF = new Random(seed.Next());
        private Random rndB = new Random(seed.Next());
        private Random rndH = new Random(seed.Next());

        private Cancha cancha;
        private Futbol futbol;
        private HandBall handBall;
        private BasketBall basketBall;

        private int iteraciones;
        private object evento;

        public Gestor(double tiempoLimpieza, List<List<double>> llegadas, List<List<double>> ocupaciones)
        {
            Futbol.setFutbol(llegadas[0][0], ocupaciones[0][0], ocupaciones[0][1]);
            HandBall.setHandBall(llegadas[1][0], llegadas[1][1], ocupaciones[1][0], ocupaciones[1][1]);
            BasketBall.setBasketBall(llegadas[2][0], llegadas[2][1], ocupaciones[2][0], ocupaciones[2][1]);

            cancha = new Cancha(tiempoLimpieza);
            futbol = new Futbol(reloj, rndF.NextDouble());
            handBall = new HandBall(reloj, rndH.NextDouble());
            basketBall = new BasketBall(reloj, rndB.NextDouble());

            Console.WriteLine();
            Console.WriteLine(rndF.NextDouble());
            Console.WriteLine(rndH.NextDouble());
            Console.WriteLine(rndB.NextDouble());
            Console.WriteLine();
            Console.WriteLine(reloj);
            Console.WriteLine(futbol.ProximaLlegada);
            Console.WriteLine(handBall.ProximaLlegada);
            Console.WriteLine(basketBall.ProximaLlegada);
            Console.WriteLine();
        }

        public void iniciar(double tiempoASimular, double horaInicioAMostrar, int cantIterAMostrar)
        {
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
                    cancha.iniciarProximoJuego(reloj);
                }
                else
                {
                    cancha.recibirDisciplina(reloj, (IDisciplina)evento, acRetirados);

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
                iteraciones++;
                Console.WriteLine();
            }
            Console.WriteLine("Ac. Grupos    : " + acGrupos);
            Console.WriteLine("Ac. Retirados : " + acRetirados);
            Console.WriteLine("Ac. Futbol    : " + acLlegF);
            Console.WriteLine("Ac. Handball  : " + acLlegH);
            Console.WriteLine("Ac. Basketball: " + acLlegB);
        }

        public object obtenerProximoEvento()
        {
            List<double> tiempos = new List<double> { cancha.HoraFin, futbol.ProximaLlegada, handBall.ProximaLlegada, basketBall.ProximaLlegada };
            double menorTiempo = tiempos.Min();

            if (menorTiempo == cancha.HoraFin)
            {
                return cancha;
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
            else
            {
                return ((IDisciplina)evento).ProximaLlegada;
            }
        }

    }
}
