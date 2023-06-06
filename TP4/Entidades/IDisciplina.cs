using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP2.TP4.Entidades
{
    public interface IDisciplina
    {
        string Nombre();

        void generarProximaLlegada(double horaInicio, double rnd);

        double generarTiempoJuego(double rnd);
        string Estado { get; set; }

        double ProximaLlegada { get; set; }

        double RndUtilizado { get; set; }
    }
}
