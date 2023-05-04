using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Util.NormalUtil
{
    
    public class BoxMullerMethod : NormalDistributionCalculator
    {
        //Se inicializan con seeds distintas.
        private static Random rand1 = new Random(24065);
        private static Random rand2 = new Random(117929);
        public double CalcularNumero(double media, double desv)
        {
            double rnd1 = rand1.NextDouble();
            double rnd2 = rand2.NextDouble();
            
            //Normal con media 0 y desviación 1
            double Z1 = Math.Sqrt(-2.0 * Math.Log(rnd1)) * Math.Cos(2.0 * Math.PI * rnd2);
            //double Z2 = Math.Sqrt(-2.0 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2);

            return Z1 * desv + media;
        }
        public override string ToString()
        {
            return "Box-Muller";
        }
    }
}
