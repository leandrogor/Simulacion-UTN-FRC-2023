using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Futbol : IDisciplina
    {
        private string nombre { get; set; }
        private double media { get; set; }
        private double tiempoLlegada { get; set; }
        public double proximaLlegada { get; set; }
        private double ocupacionMinima { get; set; }
        private double ocupacionMaxima { get; set; }

        private Random rndLlegada = new Random(1);

        
        public Futbol(double media, double ocupacionMinima, double ocupacionMaxima)
        {
            nombre = "Fútbol";
            this.media = media;
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
            tiempoLlegada = (-media * Math.Log(1 - rnd));
            proximaLlegada = horaInicio + tiempoLlegada;
        }

        public double generarFinJuego(double horaInicio, Random rnd)
        {
            return horaInicio + ocupacionMinima + rnd.NextDouble() * (ocupacionMaxima - ocupacionMinima);
        }

    }
}
