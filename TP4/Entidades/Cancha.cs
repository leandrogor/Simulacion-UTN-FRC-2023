using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Cancha
    {
        private bool libre = true;
        private Queue<IDisciplina> colaFH = new Queue<IDisciplina>();
        private Queue<IDisciplina> colaB = new Queue<IDisciplina>();
        private double tiempoLimpieza;
        private double tiempoJuego;
        private double horaFin = Double.MaxValue;

        public double HoraFin { get => horaFin; set => horaFin = value; }

        private Random rnd = new Random();

        public Cancha(double tpoLimpieza)
        {
            tiempoLimpieza = tpoLimpieza;
        }

        public void recibirDisciplina(double horaInicio, IDisciplina disciplina, int retirados)
        {
            if (libre)
            {
                iniciarProximoJuego(horaInicio, disciplina);
                libre = false;
            }
            else if (hayLugarEnCola())
            {
                if (disciplina.nombre() == "Basket Ball")
                {
                    colaB.Enqueue(disciplina);
                }
                else
                {
                    colaFH.Enqueue(disciplina);
                }
            }
            else
            {
                retirados++;
            }
            Console.WriteLine("Hora fin: " + horaFin);
        }

        public void iniciarProximoJuego(double reloj, IDisciplina disciplina)
        {
            horaFin = generarProximoFinJuego(reloj, disciplina);
        }

        public void iniciarProximoJuego(double reloj)
        {
            if (colaFH.Count > 0)
            {
                horaFin = generarProximoFinJuego(reloj, colaFH.Dequeue());
            }
            else if (colaB.Count > 0)
            {
                horaFin = generarProximoFinJuego(reloj, colaB.Dequeue());
            }
            else
            {
                libre = true;
                horaFin = Double.MaxValue;
            }
        }

        public double generarProximoFinJuego(double horaInicio, IDisciplina disciplina)
        {
            tiempoJuego = disciplina.generarTiempoJuego(rnd.NextDouble());
            return horaInicio + tiempoJuego + tiempoLimpieza;
        }

        public bool hayLugarEnCola()
        {
            return colaB.Count + colaFH.Count < 5;
        }

    }
}
