using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.Final_Gor.Entidades
{
    public class Entrega
    {
        public Queue<Cliente> ColaEntregas { get; set; }
        public Cliente ProxCliente { get; set; }
        public double ProxEntrega { get; set; }
        public static double tiempo { get; set; }

        public Entrega()
        {
            ProxEntrega = double.MaxValue;
            ColaEntregas = new Queue<Cliente>();
        }

        public void iniciarEntrega(double reloj, ref Queue<Cliente> cola)
        {
            int elementosASacar = Math.Min(cola.Count, 4);

            for (int i = 0; i < elementosASacar; i++)
            {
                ColaEntregas.Enqueue(cola.Dequeue());
            }

            ProxCliente = ColaEntregas.Dequeue();
            ProxEntrega = reloj + tiempo;
            ProxCliente.FinEspera = ProxEntrega;
        }

        public bool esUltimaEntrega(double reloj, ref int contadorCred, ref double acCred)
        {
            if (ProxCliente.TipoCompra == "Credito")
            {
                contadorCred++;
                acCred += ProxCliente.FinEspera - ProxCliente.InicioEspera;
            }
            if (ColaEntregas.Count == 0)
            {
                ProxEntrega = double.MaxValue;
                return true;
            }

            ProxCliente = ColaEntregas.Dequeue();
            ProxEntrega = reloj + tiempo;
            ProxCliente.FinEspera = ProxEntrega;

            return false;
        }
    }
}
