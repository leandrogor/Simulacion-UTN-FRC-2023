using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP3.model
{
    public class Experimento : ICloneable
    {
        private int numero;
        private double rndTipoDestinatario;
        private string tipoDestinatario;
        private double rndSolicitaAsesor;
        private bool solicitaAsesor;
        private long acumuladorSolicitaAsesor;

        public Experimento(int numero, 
            double rndTipoDestinatario, 
            string tipoDestinatario, 
            double rndSolicitaAsesor, 
            bool solicitaAsesor,
            long acumuladorSolicitaAsesor)
        {
            this.numero = numero;
            this.rndTipoDestinatario = rndTipoDestinatario;
            this.tipoDestinatario = tipoDestinatario;
            this.rndSolicitaAsesor = rndSolicitaAsesor;
            this.solicitaAsesor = solicitaAsesor;
            this.acumuladorSolicitaAsesor = acumuladorSolicitaAsesor;
        }

        public int Numero { get => numero; set => numero = value; }
        public double RndTipoDestinatario { get => rndTipoDestinatario; set => rndTipoDestinatario = value; }
        public string TipoDestinatario { get => tipoDestinatario; set => tipoDestinatario = value; }
        public double RndSolicitaAsesor { get => rndSolicitaAsesor; set => rndSolicitaAsesor = value; }
        public bool SolicitaAsesor { get => solicitaAsesor; set => solicitaAsesor = value; }
        public long AcumuladorSolicitaAsesor { get => acumuladorSolicitaAsesor; set => acumuladorSolicitaAsesor = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
