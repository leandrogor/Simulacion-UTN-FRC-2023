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
        public static string nombre = "Limpieza";
        private static double tiempoLimpieza;
        private double proximaLimpieza;

        public Limpieza(double tmpLimpieza)
        {
            tiempoLimpieza = tmpLimpieza;
            proximaLimpieza = Double.MaxValue;
        }

        public double TiempoLimpieza { get => tiempoLimpieza; set => tiempoLimpieza = value; }
        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }

        public void generarProximaLimpieza(double horaActual)
        {
            proximaLimpieza = horaActual + tiempoLimpieza; 
        }

    }
}
