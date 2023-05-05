using System;
using System.Collections.Generic;
using SIM_TP2.TP3.model;

namespace SIM_TP2.TP3.util
{
    public class Simulation
    {
        private Experimento lastExperiment;
        private Random randomTipoDestinatario;
        private Random randomSolicitaAsesor;

        private List<ElementoProbabilidad> tipoDestinatarioAcumulada;
        private List<ElementoProbabilidad> solicitaAsesor;

      
        // Parámetros:
        //   tipoDestinatario:
        //     Es la tabla tal cual está en la imagen del tp
        //   solicitaAsesor:
        //     Se trata de la primer y segunda columna de la segunda tabla
        //     tal cual está en el tp

        public Simulation(List<ElementoProbabilidad> tipoDestinatario,
            List<ElementoProbabilidad> solicitaAsesor)
        {
            this.tipoDestinatarioAcumulada = new List<ElementoProbabilidad>();
            this.solicitaAsesor = solicitaAsesor;

            double lastT = 0;
            foreach(ElementoProbabilidad e in tipoDestinatario)
            {
                lastT += e.Probabilidad;
                tipoDestinatarioAcumulada.Add(new ElementoProbabilidad(e.Nombre, lastT));
            }
            this.lastExperiment = new Experimento(0, 0, "", 0, false, 0);
            this.randomTipoDestinatario = new Random(24124);
            this.randomSolicitaAsesor = new Random(55566);
        }

        //
        // Resumen:
        //     Devuelve una lista de experimentos a partir de un cierto experimento con la longitud expecificada
        //
        // Parámetros:
        //   iteraciones:
        //     cuantas filas
        //   hora:
        //     a partir de que momento
        public List<Experimento> generarFilas(int iteraciones, int hora)
        {
            List<Experimento> ans = new List<Experimento>();
            bool seLlegoAHora = false;
            for(int i = 1; i <= hora + iteraciones; i++)
            {
                if (i == hora) seLlegoAHora = true;

                double tipoRND = randomTipoDestinatario.NextDouble();
                string tipo = getTipo(tipoRND);

                double asesRND = randomSolicitaAsesor.NextDouble();
                bool ases = getAsesor(asesRND, tipo);
                long acum = ases ? lastExperiment.AcumuladorSolicitaAsesor + 1 
                    : lastExperiment.AcumuladorSolicitaAsesor;

                lastExperiment = new Experimento(i, tipoRND, tipo, asesRND, ases, acum);

                if (seLlegoAHora)
                {
                    ans.Add((Experimento)lastExperiment.Clone());
                }
            }
            return ans;
        }

        private string getTipo(double rnd)
        {
            foreach(ElementoProbabilidad e in tipoDestinatarioAcumulada)
            {
                if (rnd < e.Probabilidad) return e.Nombre;
            }
            throw new Exception("No puede ser mayor a 1 el valor de probabilidad");
        }

        private bool getAsesor(double rnd, string tipo)
        {
            foreach(ElementoProbabilidad e in solicitaAsesor)
            {
                if (e.Nombre.Equals(tipo)) return rnd < e.Probabilidad;
            }
            throw new Exception("no se encontró el tipo solicitado");
        }
    }
}
