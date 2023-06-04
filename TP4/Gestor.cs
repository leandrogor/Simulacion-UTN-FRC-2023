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
        private int acEspF = 0;
        private int acEspH = 0;
        private int acEspB = 0;
        private Cancha cancha;
        private Futbol futbol;
        private HandBall handBall;
        private BasketBall basketBall;
        private object evento;


        public void iniciar(double tiempoASimular, double horaInicioAMostrar, int cantIterAMostrar, double tiempoLimpieza,
            List<List<double>> llegadas, List<List<double>> ocupaciones)
        {
            Cancha.tiempoLimpieza = tiempoLimpieza;
            Futbol.media = llegadas[0][0];
            Futbol.ocupacionMinima = ocupaciones[0][0];
            Futbol.ocupacionMaxima = ocupaciones[0][1];
            HandBall.llegadaMinima = llegadas[1][0];
            HandBall.llegadaMaxima = llegadas[1][1];
            HandBall.ocupacionMinima = ocupaciones[1][0];
            HandBall.ocupacionMaxima = ocupaciones[1][1];
            BasketBall.llegadaMinima = llegadas[2][0];
            BasketBall.llegadaMaxima = llegadas[2][1];
            BasketBall.ocupacionMinima = ocupaciones[2][0];
            BasketBall.ocupacionMaxima = ocupaciones[2][1];

            cancha = new Cancha();
            futbol = new Futbol();
            handBall = new HandBall();
            basketBall = new BasketBall();

            while (reloj < tiempoASimular)
            {
                evento = obtenerProximoEvento();
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
                        futbol = new Futbol();
                    }
                    else if (evento is HandBall)
                    {
                        handBall = new HandBall();
                    }
                    else
                    {
                        basketBall = new BasketBall();
                    }
                    acGrupos++;
                }

                reloj = obtenerProximoReloj();
            }
        }

        public object obtenerProximoEvento()
        {
            double menorTiempo = obtenerProximoReloj();

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

        public double obtenerProximoReloj()
        {
            List<double> tiempos = new List<double> { cancha.HoraFin, futbol.ProximaLlegada, handBall.ProximaLlegada, basketBall.ProximaLlegada };
            return tiempos.Min();
        }

    }
}
