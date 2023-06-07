using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public class Limpieza
    {
        private static double tiempoLimpieza;
        private double proximaLimpieza = Double.MaxValue;

        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }

        public Limpieza(double tmpLimpieza)
        {
            tiempoLimpieza = tmpLimpieza;
        }

        public void generarProximaLimpieza(double horaActual)
        {
            proximaLimpieza = horaActual + tiempoLimpieza;
        }

        public override string ToString()
        {
            return "Fin Limpieza";
        }

    }
}
