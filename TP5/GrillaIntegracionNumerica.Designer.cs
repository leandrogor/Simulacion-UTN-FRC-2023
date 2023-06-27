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
            this.dgv_integracion_numerica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_integracion_numerica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_integracion_numerica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.di,
            this.dDidt,
            this.hdDidt,
            this.Diproximo});
            this.dgv_integracion_numerica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_integracion_numerica.Location = new System.Drawing.Point(0, 0);
            this.dgv_integracion_numerica.Name = "dgv_integracion_numerica";
            this.dgv_integracion_numerica.ReadOnly = true;
            this.dgv_integracion_numerica.RowHeadersVisible = false;
            this.dgv_integracion_numerica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_integracion_numerica.Size = new System.Drawing.Size(530, 450);
            this.dgv_integracion_numerica.TabIndex = 0;
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            this.t.Width = 35;
            // 
            // di
            // 
            this.di.HeaderText = "Di";
            this.di.Name = "di";
            this.di.ReadOnly = true;
            this.di.Width = 42;
            // 
            // dDidt
            // 
            this.dDidt.HeaderText = "Di\'";
            this.dDidt.Name = "dDidt";
            this.dDidt.ReadOnly = true;
            this.dDidt.Width = 44;
            // 
            // hdDidt
            // 
            this.hdDidt.HeaderText = "h*Di\'";
            this.hdDidt.Name = "hdDidt";
            this.hdDidt.ReadOnly = true;
            this.hdDidt.Width = 54;
            // 
            // Diproximo
            // 
            this.Diproximo.HeaderText = "Di+1";
            this.Diproximo.Name = "Diproximo";
            this.Diproximo.ReadOnly = true;
            this.Diproximo.Width = 54;
            // 
            // GrillaIntegracionNumerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.dgv_integracion_numerica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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