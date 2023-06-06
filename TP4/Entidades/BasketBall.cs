using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class BasketBall : IDisciplina
    {
        private static string nombre = "Basket Ball";
        private static double llegadaMinima;
        private static double llegadaMaxima;
        private static double ocupacionMinima;
        private static double ocupacionMaxima;

        private double tiempoLlegada;
        private double proximaLlegada;
        private string estado = "Esperando";

        private double rndUtilizado;
        public double TiempoLlegada { get => tiempoLlegada; set => tiempoLlegada = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }
        public double RndUtilizado { get => rndUtilizado; set => rndUtilizado = value; }
        public string Estado { get => estado; set => estado = value; }

        public static void setBasketBall(double llegMin, double llegMax, double ocMin, double ocMax)
        {
            llegadaMinima = llegMin;
            llegadaMaxima = llegMax;
            ocupacionMinima = ocMin;
            ocupacionMaxima = ocMax;
        }

        public BasketBall(double horaInicio, double rnd)
        {
            generarProximaLlegada(horaInicio, rnd);
        }


        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            RndUtilizado = rnd;
            TiempoLlegada = llegadaMinima + rnd * (llegadaMaxima - llegadaMinima);
            ProximaLlegada = horaInicio + TiempoLlegada;
            Console.WriteLine("Próxima llegada: " + proximaLlegada);
        }

        public double generarTiempoJuego(double rnd)
        {
            return ocupacionMinima + rnd * (ocupacionMaxima - ocupacionMinima);
        }
        public override string ToString()
        {
            return "Llegada BasketBall";
        }

        public string Nombre()
        {
            return nombre;
        }

    }
}
