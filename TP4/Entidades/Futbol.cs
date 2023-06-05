using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Futbol : IDisciplina
    {
        private static string nombre = "Futbol";
        private static double media;
        private static double ocupacionMinima;
        private static double ocupacionMaxima;

        private double tiempoLlegada;
        private double proximaLlegada;

        public double TiempoLlegada { get => tiempoLlegada; set => tiempoLlegada = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }

        public static void setFutbol(double med, double ocMin, double ocMax)
        {
            media = med;
            ocupacionMinima = ocMin;
            ocupacionMaxima = ocMax;
        }

        public Futbol(double horaInicio, double rnd)
        {
            generarProximaLlegada(horaInicio, rnd);
        }

        string IDisciplina.nombre()
        {
            return nombre;
        }

        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            TiempoLlegada = (-media * Math.Log(1 - rnd));
            ProximaLlegada = horaInicio + TiempoLlegada;
            Console.WriteLine("Próxima llegada: " + proximaLlegada);
        }

        public double generarTiempoJuego(double rnd)
        {
            return ocupacionMinima + rnd * (ocupacionMaxima - ocupacionMinima);
        }

    }
}
