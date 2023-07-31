using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Final_Gor.Entidades
{
    public class Cliente
    {
        public double Rnd { get; set; }
        public double TpoLlegada { get; set; }
        public double ProxLlegada { get; set; }
        public double RndCompra { get; set; }
        public string TipoCompra { get; set; }
        public double InicioEspera { get; set; }
        public double FinEspera { get; set; }

        public static double min { get; set; }
        public static double max { get; set; }
        public static double prob_credito { get; set; } = 0.8;

        public Cliente()
        {

        }
        public Cliente(double reloj, double rndLlegada, double rndTipoCompra)
        {
            Rnd = rndLlegada;
            TpoLlegada = min + Rnd * (max - min);
            ProxLlegada = TpoLlegada + reloj;
            RndCompra = rndTipoCompra;
            TipoCompra = (rndTipoCompra >= prob_credito) ? "Contado" : "Credito";
        }
    }
}
