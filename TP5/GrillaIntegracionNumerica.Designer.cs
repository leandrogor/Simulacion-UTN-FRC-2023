namespace SIM_TP2.TP5
{
    partial class GrillaIntegracionNumerica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrillaIntegracionNumerica));
            this.dgv_integracion_numerica = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDidt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdDidt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diproximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integracion_numerica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_integracion_numerica
            // 
            this.dgv_integracion_numerica.AllowUserToAddRows = false;
            this.dgv_integracion_numerica.AllowUserToDeleteRows = false;
            this.dgv_integracion_numerica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_integracion_numerica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_integracion_numerica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_integracion_numerica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_integracion_numerica.ColumnHeadersHeight = 50;
            this.dgv_integracion_numerica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.di,
            this.dDidt,
            this.hdDidt,
            this.Diproximo});
            this.dgv_integracion_numerica.GridColor = System.Drawing.Color.Indigo;
            this.dgv_integracion_numerica.Location = new System.Drawing.Point(0, 0);
            this.dgv_integracion_numerica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_integracion_numerica.Name = "dgv_integracion_numerica";
            this.dgv_integracion_numerica.ReadOnly = true;
            this.dgv_integracion_numerica.RowHeadersVisible = false;
            this.dgv_integracion_numerica.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            this.dgv_integracion_numerica.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_integracion_numerica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_integracion_numerica.Size = new System.Drawing.Size(892, 554);
            this.dgv_integracion_numerica.TabIndex = 0;
            this.dgv_integracion_numerica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_integracion_numerica_CellContentClick);
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.MinimumWidth = 6;
            this.t.Name = "t";
            this.t.ReadOnly = true;
            this.t.Width = 48;
            // 
            // di
            // 
            this.di.HeaderText = "Di";
            this.di.MinimumWidth = 6;
            this.di.Name = "di";
            this.di.ReadOnly = true;
            this.di.Width = 58;
            // 
            // dDidt
            // 
            this.dDidt.HeaderText = "Di\'";
            this.dDidt.MinimumWidth = 6;
            this.dDidt.Name = "dDidt";
            this.dDidt.ReadOnly = true;
            this.dDidt.Width = 68;
            // 
            // hdDidt
            // 
            this.hdDidt.HeaderText = "h*Di\'";
            this.hdDidt.MinimumWidth = 6;
            this.hdDidt.Name = "hdDidt";
            this.hdDidt.ReadOnly = true;
            this.hdDidt.Width = 88;
            // 
            // Diproximo
            // 
            this.Diproximo.HeaderText = "Di+1";
            this.Diproximo.MinimumWidth = 6;
            this.Diproximo.Name = "Diproximo";
            this.Diproximo.ReadOnly = true;
            this.Diproximo.Width = 78;
            // 
            // GrillaIntegracionNumerica
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgv_integracion_numerica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrillaIntegracionNumerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grilla Integracion Numerica";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integracion_numerica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_integracion_numerica;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn di;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDidt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdDidt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diproximo;
    }
}