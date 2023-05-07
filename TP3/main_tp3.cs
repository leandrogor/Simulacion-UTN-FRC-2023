using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP2.TP3
{
    public partial class main_tp3 : Form
    {
        public main_tp3()
        {
            InitializeComponent();

            setUpDgvTipoDestinatario();
            setUpDgvSolicitaAsesor();




        }

        private void setUpDgvTipoDestinatario()
        {
            dgvTipoDestinatario.Columns.Add("tipoDestinatario", "Tipo de Destinatario");
            dgvTipoDestinatario.Columns.Add("probabilidad", "Probabilidad");

            List<ElementoProbabilidad> elementos = new List<ElementoProbabilidad>();
            elementos.Add(new ElementoProbabilidad("Destinatario del mail era paciente de la clínica y había asistido en el último año", 0.6));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail alguna vez anterior al último año había asistido a la clínica", 0.25));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail nunca había asistido a la clínica", 0.15));

            foreach (ElementoProbabilidad elemento in elementos)
            {
                dgvTipoDestinatario.Rows.Add(elemento.Nombre, elemento.Probabilidad.ToString("N2"));
            }

            dgvTipoDestinatario.Columns[0].ReadOnly = true;
            dgvTipoDestinatario.Columns[1].ReadOnly = false;
            dgvTipoDestinatario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvTipoDestinatario.ScrollBars = ScrollBars.None;
            dgvTipoDestinatario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTipoDestinatario.AutoSize = true;
            dgvTipoDestinatario.AllowUserToOrderColumns = false;
        }

        private void setUpDgvSolicitaAsesor()
        {
            dgvSolicitaAsesor.Columns.Add("tipoDestinatario", "Tipo de Destinatario");
            dgvSolicitaAsesor.Columns.Add("probSolicitar", "Probabilidad Solicitar Asesor");

            List<ElementoProbabilidad> elementos = new List<ElementoProbabilidad>();
            elementos.Add(new ElementoProbabilidad("Destinatario del mail era paciente de la clínica y había asistido en el último año", 0.5));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail alguna vez anterior al último año había asistido a la clínica", 0.4));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail nunca había asistido a la clínica", 0.15));

            foreach (ElementoProbabilidad elemento in elementos)
            {
                dgvSolicitaAsesor.Rows.Add(elemento.Nombre, elemento.Probabilidad.ToString("N2"));
            }

            dgvSolicitaAsesor.Columns[0].ReadOnly = true;
            dgvSolicitaAsesor.Columns[1].ReadOnly = false;
            dgvSolicitaAsesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSolicitaAsesor.ScrollBars = ScrollBars.None;
            dgvSolicitaAsesor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSolicitaAsesor.AutoSize = true;
            dgvSolicitaAsesor.AllowUserToOrderColumns = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
