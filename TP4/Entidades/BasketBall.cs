using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class BasketBall : IDisciplina
    {
        private static string nombre { get; set; } = "Basket Ball";
        public static double llegadaMinima { get; set; }
        public static double llegadaMaxima { get; set; }
        public static double ocupacionMinima { get; set; }
        public static double ocupacionMaxima { get; set; }
        
        private double tiempoLlegada;

        private double proximaLlegada;

        public double TiempoLlegada { get => tiempoLlegada; set => tiempoLlegada = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }

        private static Random rndLlegada = new Random(3);


        public BasketBall()
        {
            generarProximaLlegada(0, rndLlegada.NextDouble());
        }

        string IDisciplina.nombre()
        {
            return nombre;
        }

        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            TiempoLlegada = llegadaMinima + rnd * (llegadaMaxima - llegadaMinima);
            ProximaLlegada = horaInicio + TiempoLlegada;
        }

        public double generarFinJuego(double horaInicio, Random rnd)
        {
            return horaInicio + ocupacionMinima + rnd.NextDouble() * (ocupacionMaxima - ocupacionMinima);
        }
    }
}
