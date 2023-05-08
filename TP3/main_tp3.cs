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
            double var1 = Convert.ToDouble(dgvTipoDestinatario.Rows[0].Cells[1].Value);
            double var2 = Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[1].Value);
            double var3 = Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[1].Value);

            dataGridView1.Rows.Clear();

            double suma = var1 + var2 + var3;
            if (suma == 1)
            {
                Random random = new Random();

                for (int i = 1; i <= Convert.ToInt32(txtCantidad.Text); i++)
                {

                    //falta validar la suma de ambas tablas sea igual a 1 y recien simular.


                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i - 1].Cells[0].Value = Convert.ToString(i);

                    //GENERAR RND
                    double rnd = random.NextDouble();
                    dataGridView1.Rows[i - 1].Cells[1].Value = Math.Round(rnd, 4);


                    //Mostrar tipo de Distinatario



                    if (rnd > 0 && rnd <= Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[1].Value))
                    {

                        dataGridView1.Rows[i - 1].Cells[2].Value = dgvTipoDestinatario.Rows[2].Cells[0].Value.ToString();


                    }

                    if (rnd > Convert.ToDouble(dgvTipoDestinatario.Rows[2].Cells[1].Value) && rnd <= Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[1].Value))
                    {

                        dataGridView1.Rows[i - 1].Cells[2].Value = dgvTipoDestinatario.Rows[1].Cells[0].Value.ToString();


                    }

                    if (rnd > Convert.ToDouble(dgvTipoDestinatario.Rows[1].Cells[1].Value))
                    {

                        dataGridView1.Rows[i - 1].Cells[2].Value = dgvTipoDestinatario.Rows[0].Cells[0].Value.ToString();


                    }


                    //generar RND DE Asesor

                    double rnd1 = random.NextDouble();
                    dataGridView1.Rows[i - 1].Cells[3].Value = Math.Round(rnd1, 4);

                    //Solicita asesor?

                    int acumulador;

                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        // if(dataGridView1.Rows[i-1].Cells[3].Value == dgvTipoDestinatario.Rows[0].Cells[0].Value.ToString())
                        //if (rnd1 > 0 && rnd1 <= Convert.ToDouble(dgvSolicitaAsesor.Rows[1].Cells[1].Value))
                        // {
                        {
                            dataGridView1.Rows[i - 1].Cells[4].Value = i + 1;
                        }
                    }

                }
            }
            else
            {

                MessageBox.Show("La suma de las probabilidades debe ser igual a 1");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void main_tp3_Load(object sender, EventArgs e)
        {

        }

        private void dgvTipoDestinatario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
