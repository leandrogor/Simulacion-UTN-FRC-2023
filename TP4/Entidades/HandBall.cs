using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class HandBall : IDisciplina
    {
        private string nombre { get; set; }
        private double llegadaMinima { get; set; }
        private double llegadaMaxima { get; set; }
        private double tiempoLlegada { get; set; }
        public double proximaLlegada { get; set; }
        private double ocupacionMinima { get; set; }
        private double ocupacionMaxima { get; set; }

        private Random rndLlegada = new Random(2);


        public HandBall(double llegadaMinima, double llegadaMaxima, double ocupacionMinima, double ocupacionMaxima)
        {
            nombre = "Hand Ball";
            this.llegadaMinima = llegadaMinima;
            this.llegadaMaxima = llegadaMaxima;
            this.ocupacionMinima = ocupacionMinima;
            this.ocupacionMaxima = ocupacionMaxima;
            generarProximaLlegada(0, rndLlegada.NextDouble());
        }

        string IDisciplina.nombre()
        {
            return nombre;
        }

        public void generarProximaLlegada(double horaInicio, double rnd)
        {
            tiempoLlegada = llegadaMinima + rnd * (llegadaMaxima - llegadaMinima);
            proximaLlegada = horaInicio + tiempoLlegada;
        }

        public double generarFinJuego(double horaInicio, Random rnd)
        {
            return horaInicio + ocupacionMinima + rnd.NextDouble() * (ocupacionMaxima - ocupacionMinima);
        }
    }
}
