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
    public partial class tablaIntervalos : Form
    {
        public tablaIntervalos(DataGridView dgbDesti, DataGridView dgbSoli)
        {
            InitializeComponent();

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12);
            dgv.DefaultCellStyle.Font = new Font("Calibri", 12);

            dgv.Columns.Add("desti", "Destinatario");
            dgv.Columns.Add("min1", "Mínimo");
            dgv.Columns.Add("max1", "Máximo");
            dgv.Columns.Add("soli", "Solicita");
            dgv.Columns.Add("min2", "Mínimo");
            dgv.Columns.Add("max2", "Máximo");

            dgv.Rows.Add(dgbDesti.Rows[0].Cells[1].Value, 0,
                Convert.ToDouble(dgbDesti.Rows[0].Cells[2].Value) - 0.0001, "Si", 0,
                Convert.ToDouble(dgbSoli.Rows[0].Cells[1].Value) - 0.0001);

            dgv.Rows.Add("", "", "", "No",
                Convert.ToDouble(dgbSoli.Rows[0].Cells[1].Value),
                0.9999);

            dgv.Rows.Add(dgbDesti.Rows[1].Cells[1].Value, Convert.ToDouble(dgbDesti.Rows[0].Cells[2].Value),
                Convert.ToDouble(dgbDesti.Rows[0].Cells[2].Value) + Convert.ToDouble(dgbDesti.Rows[1].Cells[2].Value) - 0.0001, 
                "Si", 0, Convert.ToDouble(dgbSoli.Rows[1].Cells[1].Value) - 0.0001);

            dgv.Rows.Add("", "", "", "No",
                Convert.ToDouble(dgbSoli.Rows[1].Cells[1].Value),
                0.9999);

            dgv.Rows.Add(dgbDesti.Rows[2].Cells[1].Value,
                Convert.ToDouble(dgbDesti.Rows[0].Cells[2].Value) + Convert.ToDouble(dgbDesti.Rows[1].Cells[2].Value), 
                0.9999, "Si", 0,
                Convert.ToDouble(dgbSoli.Rows[2].Cells[1].Value) - 0.0001);

            dgv.Rows.Add("", "", "", "No",
                Convert.ToDouble(dgbSoli.Rows[2].Cells[1].Value),
                0.9999);

            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable; // Deshabilitamos la ordenación en la columna
            }

        }
    }
}
