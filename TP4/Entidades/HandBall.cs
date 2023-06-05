using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class HandBall : IDisciplina
    {
        private static string nombre = "Hand Ball";
        private static double llegadaMinima;
        private static double llegadaMaxima;
        private static double ocupacionMinima;
        private static double ocupacionMaxima;

        private double tiempoLlegada;
        private double proximaLlegada;

        public double TiempoLlegada { get => tiempoLlegada; set => tiempoLlegada = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }

        public static void setHandBall(double llegMin, double llegMax, double ocMin, double ocMax)
        {
            llegadaMinima = llegMin;
            llegadaMaxima = llegMax;
            ocupacionMinima = ocMin;
            ocupacionMaxima = ocMax;
        }

        public HandBall(double horaInicio, double rnd)
        {
            generarProximaLlegada(horaInicio, rnd);
        }

        string IDisciplina.nombre()
        {
            return nombre;
        }

        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            TiempoLlegada = llegadaMinima + rnd * (llegadaMaxima - llegadaMinima);
            ProximaLlegada = horaInicio + TiempoLlegada;
            Console.WriteLine("Próxima llegada: " + proximaLlegada);
        }

        public double generarTiempoJuego(double rnd)
        {
            return ocupacionMinima + rnd * (ocupacionMaxima - ocupacionMinima);
        }
    }
}
