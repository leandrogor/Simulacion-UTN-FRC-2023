namespace SIM_TP2.Generadores
{
    partial class Uniforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uniforme));
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.boxIntervalos = new System.Windows.Forms.ComboBox();
            this.dgvUniforme = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtA = new System.Windows.Forms.NumericUpDown();
            this.txtB = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvFrecuencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Goldenrod;
            this.lblB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(22, 68);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(154, 23);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "B (límite superior):";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Goldenrod;
            this.lblA.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(22, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(153, 23);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A (límite inferior) :";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Goldenrod;
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(22, 101);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(169, 23);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad de Valores:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(25, 189);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 35);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(182, 189);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(115, 35);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // boxIntervalos
            // 
            this.boxIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxIntervalos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIntervalos.FormattingEnabled = true;
            this.boxIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.boxIntervalos.Location = new System.Drawing.Point(181, 135);
            this.boxIntervalos.Name = "boxIntervalos";
            this.boxIntervalos.Size = new System.Drawing.Size(120, 31);
            this.boxIntervalos.TabIndex = 4;
            this.boxIntervalos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.boxIntervalos_PreviewKeyDown);
            // 
            // dgvUniforme
            // 
            this.dgvUniforme.AllowUserToAddRows = false;
            this.dgvUniforme.AllowUserToDeleteRows = false;
            this.dgvUniforme.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvUniforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.valor});
            this.dgvUniforme.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUniforme.Location = new System.Drawing.Point(317, 33);
            this.dgvUniforme.Name = "dgvUniforme";
            this.dgvUniforme.ReadOnly = true;
            this.dgvUniforme.RowHeadersVisible = false;
            this.dgvUniforme.RowHeadersWidth = 51;
            this.dgvUniforme.RowTemplate.Height = 24;
            this.dgvUniforme.Size = new System.Drawing.Size(439, 244);
            this.dgvUniforme.TabIndex = 25;
            this.dgvUniforme.TabStop = false;
            // 
            // nro
            // 
            this.nro.HeaderText = "Número";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Width = 200;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 200;
            // 
            // txtA
            // 
            this.txtA.DecimalPlaces = 2;
            this.txtA.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtA.Location = new System.Drawing.Point(182, 30);
            this.txtA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtA.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 30);
            this.txtA.TabIndex = 1;
            this.txtA.Enter += new System.EventHandler(this.select_all);
            // 
            // txtB
            // 
            this.txtB.DecimalPlaces = 2;
            this.txtB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtB.Location = new System.Drawing.Point(182, 66);
            this.txtB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtB.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 30);
            this.txtB.TabIndex = 2;
            this.txtB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtB.Enter += new System.EventHandler(this.select_all);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(182, 98);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 30);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtCantidad.Enter += new System.EventHandler(this.select_all);
            // 
            // dgvFrecuencias
            // 
            this.dgvFrecuencias.AllowUserToAddRows = false;
            this.dgvFrecuencias.AllowUserToDeleteRows = false;
            this.dgvFrecuencias.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvFrecuencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencias.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFrecuencias.Location = new System.Drawing.Point(25, 299);
            this.dgvFrecuencias.Name = "dgvFrecuencias";
            this.dgvFrecuencias.ReadOnly = true;
            this.dgvFrecuencias.RowHeadersVisible = false;
            this.dgvFrecuencias.RowHeadersWidth = 51;
            this.dgvFrecuencias.RowTemplate.Height = 24;
            this.dgvFrecuencias.Size = new System.Drawing.Size(731, 164);
            this.dgvFrecuencias.TabIndex = 26;
            this.dgvFrecuencias.TabStop = false;
            this.dgvFrecuencias.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Intervalos:";
            // 
            // Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFrecuencias);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.dgvUniforme);
            this.Controls.Add(this.boxIntervalos);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniforme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.ComboBox boxIntervalos;
        private System.Windows.Forms.DataGridView dgvUniforme;
        private System.Windows.Forms.NumericUpDown txtA;
        private System.Windows.Forms.NumericUpDown txtB;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvFrecuencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}