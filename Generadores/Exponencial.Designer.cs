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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exponencial));
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
            this.dgvFrecuencias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParam
            // 
            this.txtParam.BackColor = System.Drawing.Color.LightYellow;
            this.txtParam.DecimalPlaces = 2;
            this.txtParam.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtParam.Location = new System.Drawing.Point(167, 140);
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
            this.txtParam.Size = new System.Drawing.Size(120, 25);
            this.txtParam.TabIndex = 40;
            this.txtParam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxParam
            // 
            this.cbxParam.BackColor = System.Drawing.Color.Cornsilk;
            this.cbxParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParam.FormattingEnabled = true;
            this.cbxParam.Items.AddRange(new object[] {
            "Media",
            "Lambda"});
            this.cbxParam.Location = new System.Drawing.Point(15, 140);
            this.cbxParam.Name = "cbxParam";
            this.cbxParam.Size = new System.Drawing.Size(120, 26);
            this.cbxParam.TabIndex = 39;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.LightYellow;
            this.txtCantidad.Location = new System.Drawing.Point(172, 19);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 25);
            this.txtCantidad.TabIndex = 31;
            // 
            // dgvExponencial
            // 
            this.dgvExponencial.AllowUserToAddRows = false;
            this.dgvExponencial.AllowUserToDeleteRows = false;
            this.dgvExponencial.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvExponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.valor});
            this.dgvExponencial.GridColor = System.Drawing.Color.DarkKhaki;
            this.dgvExponencial.Location = new System.Drawing.Point(319, 14);
            this.dgvExponencial.Name = "dgvExponencial";
            this.dgvExponencial.ReadOnly = true;
            this.dgvExponencial.RowHeadersVisible = false;
            this.dgvExponencial.RowHeadersWidth = 51;
            this.dgvExponencial.RowTemplate.Height = 24;
            this.dgvExponencial.Size = new System.Drawing.Size(439, 244);
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
            this.boxIntervalos.BackColor = System.Drawing.Color.Cornsilk;
            this.boxIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxIntervalos.FormattingEnabled = true;
            this.boxIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.boxIntervalos.Location = new System.Drawing.Point(172, 62);
            this.boxIntervalos.Name = "boxIntervalos";
            this.boxIntervalos.Size = new System.Drawing.Size(120, 26);
            this.boxIntervalos.TabIndex = 32;
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGraficar.Location = new System.Drawing.Point(172, 199);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(115, 35);
            this.btnGraficar.TabIndex = 33;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGenerar.Location = new System.Drawing.Point(15, 199);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 35);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cantidad de Intervalos:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Cornsilk;
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 26);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(146, 20);
            this.lblCantidad.TabIndex = 36;
            this.lblCantidad.Text = "Cantidad de Valores:";
            // 
            // dgvFrecuencias
            // 
            this.dgvFrecuencias.AllowUserToAddRows = false;
            this.dgvFrecuencias.AllowUserToDeleteRows = false;
            this.dgvFrecuencias.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencias.GridColor = System.Drawing.Color.DarkKhaki;
            this.dgvFrecuencias.Location = new System.Drawing.Point(15, 305);
            this.dgvFrecuencias.Name = "dgvFrecuencias";
            this.dgvFrecuencias.ReadOnly = true;
            this.dgvFrecuencias.RowHeadersVisible = false;
            this.dgvFrecuencias.RowHeadersWidth = 51;
            this.dgvFrecuencias.RowTemplate.Height = 24;
            this.dgvFrecuencias.Size = new System.Drawing.Size(731, 164);
            this.dgvFrecuencias.TabIndex = 41;
            this.dgvFrecuencias.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Parametros:";
            // 
            // Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFrecuencias);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.cbxParam);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvExponencial);
            this.Controls.Add(this.boxIntervalos);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.txtParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFrecuencias;
        private System.Windows.Forms.Label label2;
    }
}