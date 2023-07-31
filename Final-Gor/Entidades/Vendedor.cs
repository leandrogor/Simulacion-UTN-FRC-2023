using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Final_Gor.Entidades
{
    public class Vendedor
    {
        public double Rnd { get; set; }
        public double TpoAtencion { get; set; }
        public double ProxFinAtencion { get; set; }
        public Cliente Cliente { get; set; }
        public static double min { get; set; }
        public static double max { get; set; }

        public Vendedor()
        {
            ProxFinAtencion = double.MaxValue;
        }

        public void atenderCliente(double reloj, double rndAtencion, Cliente cli)
        {
            Cliente = cli;
            Rnd = rndAtencion;
            TpoAtencion = min + Rnd * (max - min);
            ProxFinAtencion = (double)TpoAtencion + reloj;
        }

        public void finAtencion(double reloj, ref Queue<Cliente> credito, ref Queue<Cliente> contado)
        {
            Cliente.InicioEspera = reloj;
            if (Cliente.TipoCompra == "Credito")
            {
                credito.Enqueue(Cliente);
            }
            else
            {
                contado.Enqueue(Cliente);
            }
            ProxFinAtencion = double.MaxValue;
        }

    }
}
