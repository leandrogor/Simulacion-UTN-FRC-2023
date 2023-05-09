namespace SIM_TP2.TP3
{
    partial class main_tp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_tp3));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.dgvTipoDestinatario = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSolicitaAsesor = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND_tipo_dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND_solicita_asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicita_asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acumulador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUltimaFila = new System.Windows.Forms.DataGridView();
            this.NumeroUltima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND_tipo_destinatario_ultima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_destinatario_ultima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND_solicita_asesor_ultima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicita_asesor_ultima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acum_solicita_asesor_ultima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDestinatario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitaAsesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimaFila)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(43, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trabajo Práctico Nro 3 de Simulación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(63, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ejercicio nro 3: Nuevo Servicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(255, 93);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(90, 26);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(17, 93);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(152, 19);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad de Filas (N):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(255, 128);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 26);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Inicio de muestra de iteraciones (j)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(255, 168);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 26);
            this.numericUpDown2.TabIndex = 24;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad de Vueltas a mostrar (i):";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(46, 211);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 28);
            this.btnIniciar.TabIndex = 26;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // dgvTipoDestinatario
            // 
            this.dgvTipoDestinatario.AllowUserToAddRows = false;
            this.dgvTipoDestinatario.AllowUserToDeleteRows = false;
            this.dgvTipoDestinatario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvTipoDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoDestinatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDestinatario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTipoDestinatario.Location = new System.Drawing.Point(366, 60);
            this.dgvTipoDestinatario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTipoDestinatario.Name = "dgvTipoDestinatario";
            this.dgvTipoDestinatario.RowHeadersVisible = false;
            this.dgvTipoDestinatario.RowHeadersWidth = 51;
            this.dgvTipoDestinatario.RowTemplate.Height = 24;
            this.dgvTipoDestinatario.Size = new System.Drawing.Size(486, 93);
            this.dgvTipoDestinatario.TabIndex = 27;
            this.dgvTipoDestinatario.TabStop = false;
            this.dgvTipoDestinatario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoDestinatario_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(366, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de destinatario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(915, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Solicita Asesor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // dgvSolicitaAsesor
            // 
            this.dgvSolicitaAsesor.AllowUserToAddRows = false;
            this.dgvSolicitaAsesor.AllowUserToDeleteRows = false;
            this.dgvSolicitaAsesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvSolicitaAsesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitaAsesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitaAsesor.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSolicitaAsesor.Location = new System.Drawing.Point(890, 60);
            this.dgvSolicitaAsesor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSolicitaAsesor.Name = "dgvSolicitaAsesor";
            this.dgvSolicitaAsesor.RowHeadersVisible = false;
            this.dgvSolicitaAsesor.RowHeadersWidth = 51;
            this.dgvSolicitaAsesor.RowTemplate.Height = 24;
            this.dgvSolicitaAsesor.Size = new System.Drawing.Size(484, 93);
            this.dgvSolicitaAsesor.TabIndex = 29;
            this.dgvSolicitaAsesor.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.RND_tipo_dest,
            this.tipo_destinatario,
            this.RND_solicita_asesor,
            this.Solicita_asesor,
            this.Acumulador});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.Location = new System.Drawing.Point(63, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 316);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 160;
            // 
            // RND_tipo_dest
            // 
            this.RND_tipo_dest.HeaderText = "RND Tipo Destinatario";
            this.RND_tipo_dest.MinimumWidth = 6;
            this.RND_tipo_dest.Name = "RND_tipo_dest";
            this.RND_tipo_dest.ReadOnly = true;
            this.RND_tipo_dest.Width = 180;
            // 
            // tipo_destinatario
            // 
            this.tipo_destinatario.HeaderText = "Tipo Destinatario";
            this.tipo_destinatario.MinimumWidth = 6;
            this.tipo_destinatario.Name = "tipo_destinatario";
            this.tipo_destinatario.ReadOnly = true;
            this.tipo_destinatario.Width = 125;
            // 
            // RND_solicita_asesor
            // 
            this.RND_solicita_asesor.HeaderText = "RND Solicita Asesor";
            this.RND_solicita_asesor.MinimumWidth = 6;
            this.RND_solicita_asesor.Name = "RND_solicita_asesor";
            this.RND_solicita_asesor.ReadOnly = true;
            this.RND_solicita_asesor.Width = 180;
            // 
            // Solicita_asesor
            // 
            this.Solicita_asesor.HeaderText = "Solicita Asesor";
            this.Solicita_asesor.MinimumWidth = 6;
            this.Solicita_asesor.Name = "Solicita_asesor";
            this.Solicita_asesor.ReadOnly = true;
            this.Solicita_asesor.Width = 180;
            // 
            // Acumulador
            // 
            this.Acumulador.HeaderText = "Acumulador solicita asesor";
            this.Acumulador.MinimumWidth = 6;
            this.Acumulador.Name = "Acumulador";
            this.Acumulador.ReadOnly = true;
            this.Acumulador.Width = 180;
            // 
            // dgvUltimaFila
            // 
            this.dgvUltimaFila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimaFila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroUltima,
            this.RND_tipo_destinatario_ultima,
            this.tipo_destinatario_ultima,
            this.RND_solicita_asesor_ultima,
            this.solicita_asesor_ultima,
            this.acum_solicita_asesor_ultima});
            this.dgvUltimaFila.Location = new System.Drawing.Point(63, 740);
            this.dgvUltimaFila.Name = "dgvUltimaFila";
            this.dgvUltimaFila.Size = new System.Drawing.Size(998, 70);
            this.dgvUltimaFila.TabIndex = 32;
            // 
            // NumeroUltima
            // 
            this.NumeroUltima.Frozen = true;
            this.NumeroUltima.HeaderText = "Numero";
            this.NumeroUltima.Name = "NumeroUltima";
            this.NumeroUltima.ReadOnly = true;
            // 
            // RND_tipo_destinatario_ultima
            // 
            this.RND_tipo_destinatario_ultima.Frozen = true;
            this.RND_tipo_destinatario_ultima.HeaderText = "RND Tipo Destinatario";
            this.RND_tipo_destinatario_ultima.Name = "RND_tipo_destinatario_ultima";
            this.RND_tipo_destinatario_ultima.ReadOnly = true;
            // 
            // tipo_destinatario_ultima
            // 
            this.tipo_destinatario_ultima.Frozen = true;
            this.tipo_destinatario_ultima.HeaderText = "Tipo Destinatario";
            this.tipo_destinatario_ultima.Name = "tipo_destinatario_ultima";
            this.tipo_destinatario_ultima.ReadOnly = true;
            // 
            // RND_solicita_asesor_ultima
            // 
            this.RND_solicita_asesor_ultima.Frozen = true;
            this.RND_solicita_asesor_ultima.HeaderText = "RND Solicita Asesor";
            this.RND_solicita_asesor_ultima.Name = "RND_solicita_asesor_ultima";
            this.RND_solicita_asesor_ultima.ReadOnly = true;
            // 
            // solicita_asesor_ultima
            // 
            this.solicita_asesor_ultima.Frozen = true;
            this.solicita_asesor_ultima.HeaderText = "Solicita Asesor";
            this.solicita_asesor_ultima.Name = "solicita_asesor_ultima";
            this.solicita_asesor_ultima.ReadOnly = true;
            // 
            // acum_solicita_asesor_ultima
            // 
            this.acum_solicita_asesor_ultima.Frozen = true;
            this.acum_solicita_asesor_ultima.HeaderText = "Acumulador solicita asesor";
            this.acum_solicita_asesor_ultima.Name = "acum_solicita_asesor_ultima";
            this.acum_solicita_asesor_ultima.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 706);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ultima fila";
            // 
            // main_tp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources.protada;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvUltimaFila);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSolicitaAsesor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTipoDestinatario);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_tp3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Práctico Número 3 de Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_tp3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDestinatario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitaAsesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimaFila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView dgvTipoDestinatario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSolicitaAsesor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_tipo_dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_solicita_asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicita_asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acumulador;
        private System.Windows.Forms.DataGridView dgvUltimaFila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroUltima;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_tipo_destinatario_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_destinatario_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_solicita_asesor_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicita_asesor_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn acum_solicita_asesor_ultima;
    }
}