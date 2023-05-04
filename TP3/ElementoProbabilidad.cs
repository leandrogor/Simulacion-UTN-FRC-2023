using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP3
{
    public class ElementoProbabilidad
    {
        private string nombre;
        private double probabilidad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Probabilidad
        {
            get { return probabilidad; }
            set { probabilidad = value; }
        }

        public ElementoProbabilidad(string nom, double prob)
        {
            nombre = nom;
            probabilidad = prob;
        }
    }
}
