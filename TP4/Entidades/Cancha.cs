using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Cancha
    {
        private bool libre { get; set; }
        private Queue<IDisciplina> colaFH { get; set; }
        private Queue<IDisciplina> colaB { get; set; }
        private double tiempoJuego { get; set; }
        private double tiempoLimpieza { get; set; }
        private double horaFin { get; set; }

        private Random rnd = new Random();

        public Cancha(double tiempoLimpieza)
        {
            this.tiempoLimpieza = tiempoLimpieza;
            colaFH = new Queue<IDisciplina>();
            colaB = new Queue<IDisciplina>();
            libre = true;
            horaFin = Double.MaxValue;
        }

        public bool recibirDisciplina(double horaInicio, IDisciplina disciplina)
        {
            if (libre)
            {
                generarProximoFinJuego(horaInicio, disciplina);
                return true;
            }
            if (hayLugarEnCola())
            {
                if (disciplina.nombre() == "Basket Ball")
                {
                    colaB.Enqueue(disciplina);
                }
                else
                {
                    colaFH.Enqueue(disciplina);
                }
                return true;
            }
            return false;
        }

        public double generarProximoFinJuego(double horaInicio, Object disciplina)
        {
            return 1;
        }

        public bool hayLugarEnCola()
        {
            return colaB.Count + colaFH.Count < 5;
        }


    }
}
