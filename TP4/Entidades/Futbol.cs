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

        private double rndUtilizado;

        private double tiempoLlegada;
        private double proximaLlegada;
        private string estado = "Esperando";

        public double TiempoLlegada { get => tiempoLlegada; set => tiempoLlegada = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }
        public double RndUtilizado { get => rndUtilizado; set => rndUtilizado = value; }
        public string Estado { get => estado; set => estado = value; }

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

        public string Nombre()
        {
            return nombre;
        }

        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            RndUtilizado = rnd;

            TiempoLlegada = (-media * Math.Log(1 - rnd));
            ProximaLlegada = horaInicio + TiempoLlegada;
            Console.WriteLine("Próxima llegada: " + proximaLlegada);
        }

        public double generarTiempoJuego(double rnd)
        {
            return ocupacionMinima + rnd * (ocupacionMaxima - ocupacionMinima);
        }

        public override string ToString()
        {
            return "Llegada Futbol";
        }


    }
}
