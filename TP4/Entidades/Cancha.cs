using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Cancha
    {
        private bool libre;
        private Queue<IDisciplina> colaFH;
        private Queue<IDisciplina> colaB;
        private double tiempoJuego;
        private double horaFin;
        public static double tiempoLimpieza { get; set; }
        public double HoraFin { get => horaFin; set => horaFin = value; }

        private Random rnd = new Random();

        public Cancha()
        {
            colaFH = new Queue<IDisciplina>();
            colaB = new Queue<IDisciplina>();
            libre = true;
            HoraFin = Double.MaxValue;
        }

        public void recibirDisciplina(double horaInicio, IDisciplina disciplina, int retirados)
        {
            if (libre)
            {
                horaFin = generarProximoFinJuego(horaInicio, disciplina);
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
        }

        public double generarProximoFinJuego(double horaInicio, IDisciplina disciplina)
        {
            return disciplina.generarFinJuego(horaInicio, rnd);
        }

        public bool hayLugarEnCola()
        {
            return colaB.Count + colaFH.Count < 5;
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
            }
        }


    }
}
