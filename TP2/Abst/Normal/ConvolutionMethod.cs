using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Util.NormalUtil
{
    
    public class ConvolutionMethod : NormalDistributionCalculator
    {
        private static Random ran = new Random();
        public double CalcularNumero(double media, double desv)
        {
            List<double> numAleatorios = new List<double>();
            for(int i = 0; i<12; i++)
            {
                numAleatorios.Add(ran.NextDouble());
            }
            return (numAleatorios.Sum()-6)*desv+media;
        }
        public override string ToString()
        {
            return "Convolución";
        }
    }
}
