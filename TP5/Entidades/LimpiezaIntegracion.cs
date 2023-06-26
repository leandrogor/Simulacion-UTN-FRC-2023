using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP5.Entidades
{
    public class LimpiezaIntegracion
    {
        private double h;
        private double proximaLimpieza;

        public LimpiezaIntegracion(double h) 
        { 
            this.h = h;
        }

        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }

        public double calcularUnidadesDeIntegracion(double d,  double c)
        {
            double actualD = 0;
            double actualt = 0;
            while(actualD < d)
            {
                double dydx = 0.6 * c + actualt;
                double hdydx = this.h * dydx;
                actualD += this.h * hdydx;
                actualt += this.h;
            }
            return actualt;
        }

        public List<List<double>> mostrarEuler(double d, double c)
        {
            List<List<double>> euler = new List<List<double>>(); //fila: t, Di, dDi/dt, h * dDi/dt, Di+1
            double actualD = 0;
            double actualt = 0;
            while (actualD < d)
            {
                List<double> fila = new List<double>();
                fila.Add(actualt);
                fila.Add(actualD);
                double dydx = 0.6 * c + actualt;
                double hdydx = this.h * dydx;
                fila.Add(dydx);
                fila.Add(hdydx);
                actualD += this.h * hdydx;
                actualt += this.h;
                fila.Add(actualD); 
                euler.Add(fila);
            }
            return euler;
        }

        public void generarProximaLimpieza(double reloj, double d, int v)
        {
            ProximaLimpieza = reloj + calcularUnidadesDeIntegracion(d, v) / 60; //dividido 60 porque da el valor en minutos y nosotros lo tenemos todo en horas
        }

        public override string ToString()
        {
            return "Fin Limpieza";
        }
    }
}
