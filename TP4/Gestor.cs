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

            Cancha cancha = new Cancha();
            Futbol futbol = new Futbol();
            HandBall handBall = new HandBall();
            BasketBall basketBall = new BasketBall();


            //while(reloj < tiempoASimular)
            //{
            //    cancha
            //}

        }

    }
}
