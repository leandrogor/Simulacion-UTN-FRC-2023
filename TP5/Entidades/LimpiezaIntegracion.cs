using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP5.Entidades
{
    public class LimpiezaIntegracion
    {
        private static double h;
        private double proximaLimpieza;
        private Dictionary<Keydc, double> memoization; //optimización
        struct Keydc
        {
            public double dKey;
            public double cKey;
        }
        public LimpiezaIntegracion(double h) 
        { 
            LimpiezaIntegracion.h = h;
            memoization = new Dictionary<Keydc, double>();//optimization
        }

        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }

        public double calcularUnidadesDeIntegracion(double d,  double c)
        {
            Keydc key = new Keydc { dKey = d, cKey = c }; //optimization
            if (memoization.ContainsKey(key)) return memoization[key]; //optimization
            double actualD = 0;
            double actualt = 0;
            while(actualD < d)
            {
                double dydx = 0.6 * c + actualt;
                double hdydx = h * dydx;
                actualD += h * hdydx;
                actualt += h;
            }
            memoization.Add(key, actualt);//optimization
            return actualt;
        }

        public static List<List<double>> mostrarEuler(double d, double c)
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
                double hdydx = h * dydx;
                fila.Add(dydx);
                fila.Add(hdydx);
                actualD += h * hdydx;
                actualt += h;
                fila.Add(actualD); 
                euler.Add(fila);
            }
            return euler;
        }

        public double generarProximaLimpieza(double reloj, double d, int v)
        {
            double unidades = calcularUnidadesDeIntegracion(d, v) / 60; //dividido 60 porque da el valor en minutos y nosotros lo tenemos todo en horas
            ProximaLimpieza = reloj + unidades; 
            return unidades;
        }

        public override string ToString()
        {
            return "Fin Limpieza";
        }
    }
}
