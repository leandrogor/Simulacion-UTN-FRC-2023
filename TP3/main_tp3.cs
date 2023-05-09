using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            dgvTipoDestinatario.Columns.Add("numero", "Numero");
            dgvTipoDestinatario.Columns.Add("tipoDestinatario", "Tipo de Destinatario");
            dgvTipoDestinatario.Columns.Add("probabilidad", "Probabilidad");

            List<ElementoProbabilidad> elementos = new List<ElementoProbabilidad>();
            elementos.Add(new ElementoProbabilidad("Destinatario del mail era paciente de la clínica y había asistido en el último año", 0.6));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail alguna vez anterior al último año había asistido a la clínica", 0.25));
            elementos.Add(new ElementoProbabilidad("Destinatario del mail nunca había asistido a la clínica", 0.15));

            int c = 1;
            foreach (ElementoProbabilidad elemento in elementos)
            {
                dgvTipoDestinatario.Rows.Add(c++, elemento.Nombre, elemento.Probabilidad.ToString("N2"));
            }

            dgvTipoDestinatario.Columns[0].ReadOnly = true;
            dgvTipoDestinatario.Columns[2].ReadOnly = false;
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
            if (validar_txt()) return;
            if (validar_dgv_1()) return;

            int inicioDeMuestra = Convert.ToInt32(iteracionestxt.Value); //j
            int cantidadDeVueltas = Convert.ToInt32(vueltastxt.Value); //i
            int finDeMuestra = inicioDeMuestra + cantidadDeVueltas;

            int acumuladorSolicitaAsesor = 0;

            string tipoEraPaciente = 1.ToString();
            string tipoAlgunaVez = 2.ToString();
            string tipoNunca = 3.ToString();

            int tableIndex = 0;

            dataGridView1.Rows.Clear();
            dgvUltimaFila.Show();
            ultfila.Show();
            dataGridView1.Show();

            double var4 = Convert.ToDouble(dgvTipoDestinatario.Rows[0].Cells[2].Value);
            double var5 = Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[2].Value);
            double var6 = Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[2].Value);
            //Agregar que ningun valor pueda ser cero
            double sumaTabla2 = var4 + var5 + var6;
            if (sumaTabla2 != 1)
            {
                MessageBox.Show("La suma de las probabilidades en la tabla de solicitud de asesor debe ser igual a 1", "Error en la probabilidad");
                return;
            }

            Random random = new Random();
            int N = Convert.ToInt32(txtCantidad.Text);

            //Validaciones para los valores de entrada
            if (N < cantidadDeVueltas)
            {

                cantidadDeVueltas = N;
            }
            if (N < inicioDeMuestra)
            {
                iteracionestxt.Value = N;
                inicioDeMuestra = N;
            }

            int validadorAux1 = N - inicioDeMuestra;

            if (validadorAux1 < cantidadDeVueltas)
            {
                int validadorAux2 = cantidadDeVueltas - validadorAux1;
                inicioDeMuestra = inicioDeMuestra - validadorAux2;
                iteracionestxt.Value = inicioDeMuestra;
            }

            for (int i = 1; i <= N; i++)
            {

                //GENERAR RND
                double rnd = random.NextDouble();

                //Mostrar tipo de Distinatario

                string tipoDestinatario = null;

                if (rnd > 0 && rnd <= Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[2].Value))
                {
                    tipoDestinatario = tipoEraPaciente;
                }

                if (rnd > Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[2].Value) && rnd <= Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[2].Value))
                {
                    tipoDestinatario = tipoAlgunaVez;

                }

                if (rnd > Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[2].Value))
                {
                    tipoDestinatario = tipoNunca;
                }

                //generar RND DE Asesor

                double rndAsesor = random.NextDouble();
                bool solicitaAsesor = false;

                //Solicita asesor?
                if (tipoDestinatario.Equals(tipoEraPaciente))
                {
                    if (rndAsesor < Convert.ToDouble(dgvSolicitaAsesor.Rows[0].Cells[1].Value)) solicitaAsesor = true;
                }

                if (tipoDestinatario.Equals(tipoAlgunaVez))
                {
                    if (rndAsesor < Convert.ToDouble(dgvSolicitaAsesor.Rows[1].Cells[1].Value)) solicitaAsesor = true;
                }

                if (tipoDestinatario.Equals(tipoNunca))
                {
                    if (rndAsesor < Convert.ToDouble(dgvSolicitaAsesor.Rows[1].Cells[1].Value)) solicitaAsesor = true;
                }

                if (solicitaAsesor) acumuladorSolicitaAsesor++;

                //Si está dentro del rango, mostrarlo..
                if (inicioDeMuestra <= i && i <= finDeMuestra)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[tableIndex].Cells[0].Value = Convert.ToString(i);
                    dataGridView1.Rows[tableIndex].Cells[1].Value = Math.Round(rnd, 4);
                    dataGridView1.Rows[tableIndex].Cells[2].Value = tipoDestinatario;
                    dataGridView1.Rows[tableIndex].Cells[3].Value = Math.Round(rndAsesor, 4);
                    dataGridView1.Rows[tableIndex].Cells[4].Value = (solicitaAsesor ? "Si" : "No");
                    dataGridView1.Rows[tableIndex].Cells[5].Value = acumuladorSolicitaAsesor;

                    tableIndex++;
                }

                if (i == N)
                {
                    dgvUltimaFila.Rows[0].Cells[0].Value = Convert.ToString(i);
                    dgvUltimaFila.Rows[0].Cells[1].Value = Math.Round(rnd, 4);
                    dgvUltimaFila.Rows[0].Cells[2].Value = tipoDestinatario;
                    dgvUltimaFila.Rows[0].Cells[3].Value = Math.Round(rndAsesor, 4);
                    dgvUltimaFila.Rows[0].Cells[4].Value = (solicitaAsesor ? "Si" : "No");
                    dgvUltimaFila.Rows[0].Cells[5].Value = acumuladorSolicitaAsesor;
                }
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validar_txt()
        {
            if (txtCantidad.Value <= 0)
            {

                MessageBox.Show("La cantidad de filas a mostrar debe ser mayor a 0", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;

            }
            if (vueltastxt.Value <= 0)
            {
                MessageBox.Show("La cantidad de vueltas a mostrar debe ser mayor a 0", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (validar_dgv_1()) return;
            tablaIntervalos tabla = new tablaIntervalos(dgvTipoDestinatario, dgvSolicitaAsesor);
            tabla.Show();
        }

        private bool validar_dgv_1()
        {
            double var1 = Convert.ToDouble(dgvTipoDestinatario.Rows[0].Cells[2].Value);
            double var2 = Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[2].Value);
            double var3 = Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[2].Value);
            double suma = var1 + var2 + var3;
            if (suma != 1)
            {
                MessageBox.Show("La suma de las probabilidades en la tabla de destinatario debe ser igual a 1", "Error en la probabilidad");
                return true;
            }
            return false;
        }
    }
}
