namespace SIM_TP2.Generadores
{
    partial class Exponencial
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
            this.txtParam = new System.Windows.Forms.NumericUpDown();
            this.cbxParam = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvExponencial = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxIntervalos = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParam
            // 
            this.txtParam.DecimalPlaces = 2;
            this.txtParam.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtParam.Location = new System.Drawing.Point(167, 90);
            this.txtParam.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtParam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(120, 22);
            this.txtParam.TabIndex = 40;
            this.txtParam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxParam
            // 
            this.cbxParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParam.FormattingEnabled = true;
            this.cbxParam.Items.AddRange(new object[] {
            "Media",
            "Lambda"});
            this.cbxParam.Location = new System.Drawing.Point(15, 90);
            this.cbxParam.Name = "cbxParam";
            this.cbxParam.Size = new System.Drawing.Size(120, 24);
            this.cbxParam.TabIndex = 39;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(172, 17);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 22);
            this.txtCantidad.TabIndex = 31;
            // 
            // dgvExponencial
            // 
            this.dgvExponencial.AllowUserToAddRows = false;
            this.dgvExponencial.AllowUserToDeleteRows = false;
            this.dgvExponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.valor});
            this.dgvExponencial.Location = new System.Drawing.Point(319, 12);
            this.dgvExponencial.Name = "dgvExponencial";
            this.dgvExponencial.ReadOnly = true;
            this.dgvExponencial.RowHeadersVisible = false;
            this.dgvExponencial.RowHeadersWidth = 51;
            this.dgvExponencial.RowTemplate.Height = 24;
            this.dgvExponencial.Size = new System.Drawing.Size(439, 217);
            this.dgvExponencial.TabIndex = 38;
            // 
            // nro
            // 
            this.nro.HeaderText = "Número";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Width = 125;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 125;
            // 
            // boxIntervalos
            // 
            this.boxIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxIntervalos.FormattingEnabled = true;
            this.boxIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.boxIntervalos.Location = new System.Drawing.Point(172, 51);
            this.boxIntervalos.Name = "boxIntervalos";
            this.boxIntervalos.Size = new System.Drawing.Size(120, 24);
            this.boxIntervalos.TabIndex = 32;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(172, 154);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(115, 31);
            this.btnGraficar.TabIndex = 33;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 154);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 31);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cantidad de Intervalos:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 23);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(133, 16);
            this.lblCantidad.TabIndex = 36;
            this.lblCantidad.Text = "Cantidad de Valores:";
            // 
            // Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.cbxParam);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvExponencial);
            this.Controls.Add(this.boxIntervalos);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Exponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.txtParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtParam;
        private System.Windows.Forms.ComboBox cbxParam;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvExponencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.ComboBox boxIntervalos;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
    }
}