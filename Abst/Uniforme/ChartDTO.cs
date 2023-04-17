using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Abst.Uniforme
{
    internal class ChartDTO
    {
        public static double[] limitesInferiores;
        public static double[] limitesSuperiores;
        public static int[] frecuencias;


        public static void SetValues(double[] li, double[] ls, int[] freq)
        {
            limitesInferiores = li;
            limitesSuperiores = ls;
            frecuencias = freq;
        }
    }
}
