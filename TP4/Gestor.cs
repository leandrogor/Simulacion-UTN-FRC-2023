using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Gestor
    {
        private double reloj { get; set; } = 0;
        private int acGrupos { get; set; } = 0;
        private int acRetirados { get; set; } = 0;
        private int acEspF { get; set; } = 0;
        private int acEspH { get; set; } = 0;
        private int acEspB { get; set; } = 0;


        public void iniciar(double tiempoASimular, double cantIterAMostrar, double horaInicioAMostrar, double tiempoLimpieza,
            List<List<double>> llegadas, List<List<double>> ocupaciones)
        {
            Cancha cancha = new Cancha(tiempoLimpieza);
            Futbol futbol = new Futbol(llegadas[0][0], ocupaciones[0][0], ocupaciones[0][1]);
            HandBall handBall = new HandBall(llegadas[1][0], llegadas[1][1], ocupaciones[1][0], ocupaciones[1][1]);
            BasketBall basketBall = new BasketBall(llegadas[2][0], llegadas[2][1], ocupaciones[2][0], ocupaciones[2][1]);

            Console.WriteLine(futbol.proximaLlegada);
            Console.WriteLine(handBall.proximaLlegada);
            Console.WriteLine(basketBall.proximaLlegada);

        }

    }
}
