namespace SIM_TP2.Final_Gor
{
    partial class solucionFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solucionFinal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.iteracionesSim = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new Guna.UI.WinForms.GunaButton();
            this.btnVolver = new Guna.UI.WinForms.GunaButton();
            this.grpRes = new System.Windows.Forms.GroupBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relojSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finAt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finAt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restTras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinTraslado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contCred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoCred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.probabilidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLleg = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.minLleg = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.reparto = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maxAt = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minAt = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionesSim)).BeginInit();
            this.grpRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLleg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLleg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.iteracionesSim);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(431, 80);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulacion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(206, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Iteraciones a simular:";
            // 
            // iteracionesSim
            // 
            this.iteracionesSim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iteracionesSim.Location = new System.Drawing.Point(307, 32);
            this.iteracionesSim.Margin = new System.Windows.Forms.Padding(4);
            this.iteracionesSim.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iteracionesSim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iteracionesSim.Name = "iteracionesSim";
            this.iteracionesSim.Size = new System.Drawing.Size(96, 28);
            this.iteracionesSim.TabIndex = 1;
            this.iteracionesSim.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // btnIniciar
            // 
            this.btnIniciar.AnimationHoverSpeed = 0.07F;
            this.btnIniciar.AnimationSpeed = 0.03F;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite1;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.BaseColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIniciar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Image = null;
            this.btnIniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIniciar.Location = new System.Drawing.Point(465, 19);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnIniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIniciar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIniciar.OnHoverImage = null;
            this.btnIniciar.OnPressedColor = System.Drawing.Color.Black;
            this.btnIniciar.Size = new System.Drawing.Size(157, 70);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AnimationHoverSpeed = 0.07F;
            this.btnVolver.AnimationSpeed = 0.03F;
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite1;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.BaseColor = System.Drawing.Color.Transparent;
            this.btnVolver.BorderColor = System.Drawing.Color.Black;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVolver.FocusedColor = System.Drawing.Color.Empty;
            this.btnVolver.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = null;
            this.btnVolver.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVolver.Location = new System.Drawing.Point(663, 19);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVolver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVolver.OnHoverImage = null;
            this.btnVolver.OnPressedColor = System.Drawing.Color.Black;
            this.btnVolver.Size = new System.Drawing.Size(157, 70);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpRes
            // 
            this.grpRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpRes.Controls.Add(this.lblRespuesta);
            this.grpRes.Controls.Add(this.label1);
            this.grpRes.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRes.Location = new System.Drawing.Point(848, 9);
            this.grpRes.Margin = new System.Windows.Forms.Padding(0);
            this.grpRes.Name = "grpRes";
            this.grpRes.Padding = new System.Windows.Forms.Padding(4);
            this.grpRes.Size = new System.Drawing.Size(689, 80);
            this.grpRes.TabIndex = 49;
            this.grpRes.TabStop = false;
            this.grpRes.Text = "Resultado";
            this.grpRes.Visible = false;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(582, 34);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(107, 17);
            this.lblRespuesta.TabIndex = 19;
            this.lblRespuesta.Text = "(respuesta)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tiempo medio de reparto de paquetes a credito (minutos): ";
            // 
            // dgvFinal
            // 
            this.dgvFinal.AllowUserToAddRows = false;
            this.dgvFinal.AllowUserToDeleteRows = false;
            this.dgvFinal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFinal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinal.ColumnHeadersHeight = 60;
            this.dgvFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.relojSim,
            this.NombreEvento,
            this.RND1,
            this.tiempoLlegada,
            this.proximaLlegada,
            this.RND2,
            this.tipoCompra,
            this.RND3,
            this.tiempoAtencion,
            this.finAt1,
            this.tipo1,
            this.finAt2,
            this.tipo2,
            this.colaCli,
            this.colaCred,
            this.colaCont,
            this.restTras,
            this.proximoFinTraslado,
            this.contCred,
            this.acTiempoCred,
            this.tipoEntrega,
            this.inicioC1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinal.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvFinal.Location = new System.Drawing.Point(13, 95);
            this.dgvFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinal.RowHeadersVisible = false;
            this.dgvFinal.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFinal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinal.Size = new System.Drawing.Size(2027, 741);
            this.dgvFinal.TabIndex = 50;
            this.dgvFinal.TabStop = false;
            // 
            // Numero
            // 
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Nº";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 70;
            // 
            // relojSim
            // 
            this.relojSim.Frozen = true;
            this.relojSim.HeaderText = "Reloj";
            this.relojSim.MinimumWidth = 6;
            this.relojSim.Name = "relojSim";
            this.relojSim.ReadOnly = true;
            this.relojSim.Width = 70;
            // 
            // NombreEvento
            // 
            this.NombreEvento.Frozen = true;
            this.NombreEvento.HeaderText = "Nombre Evento";
            this.NombreEvento.MinimumWidth = 6;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.ReadOnly = true;
            this.NombreEvento.Width = 140;
            // 
            // RND1
            // 
            this.RND1.HeaderText = "RND1";
            this.RND1.MinimumWidth = 6;
            this.RND1.Name = "RND1";
            this.RND1.ReadOnly = true;
            this.RND1.Width = 70;
            // 
            // tiempoLlegada
            // 
            this.tiempoLlegada.HeaderText = "Tiempo Llegada";
            this.tiempoLlegada.MinimumWidth = 6;
            this.tiempoLlegada.Name = "tiempoLlegada";
            this.tiempoLlegada.ReadOnly = true;
            this.tiempoLlegada.Width = 70;
            // 
            // proximaLlegada
            // 
            this.proximaLlegada.HeaderText = "Proxima Llegada";
            this.proximaLlegada.MinimumWidth = 6;
            this.proximaLlegada.Name = "proximaLlegada";
            this.proximaLlegada.ReadOnly = true;
            this.proximaLlegada.Width = 70;
            // 
            // RND2
            // 
            this.RND2.HeaderText = "RND2";
            this.RND2.MinimumWidth = 6;
            this.RND2.Name = "RND2";
            this.RND2.ReadOnly = true;
            this.RND2.Width = 70;
            // 
            // tipoCompra
            // 
            this.tipoCompra.HeaderText = "Tipo Compra";
            this.tipoCompra.MinimumWidth = 6;
            this.tipoCompra.Name = "tipoCompra";
            this.tipoCompra.ReadOnly = true;
            this.tipoCompra.Width = 70;
            // 
            // RND3
            // 
            this.RND3.HeaderText = "RND3";
            this.RND3.MinimumWidth = 6;
            this.RND3.Name = "RND3";
            this.RND3.ReadOnly = true;
            this.RND3.Width = 70;
            // 
            // tiempoAtencion
            // 
            this.tiempoAtencion.HeaderText = "Tiempo Atencion";
            this.tiempoAtencion.MinimumWidth = 6;
            this.tiempoAtencion.Name = "tiempoAtencion";
            this.tiempoAtencion.ReadOnly = true;
            this.tiempoAtencion.Width = 70;
            // 
            // finAt1
            // 
            this.finAt1.HeaderText = "Fin Atencion 1";
            this.finAt1.MinimumWidth = 6;
            this.finAt1.Name = "finAt1";
            this.finAt1.ReadOnly = true;
            this.finAt1.Width = 70;
            // 
            // tipo1
            // 
            this.tipo1.HeaderText = "Tipo Cliente En 1";
            this.tipo1.MinimumWidth = 6;
            this.tipo1.Name = "tipo1";
            this.tipo1.ReadOnly = true;
            this.tipo1.Width = 70;
            // 
            // finAt2
            // 
            this.finAt2.HeaderText = "Fin Atencion 2";
            this.finAt2.MinimumWidth = 6;
            this.finAt2.Name = "finAt2";
            this.finAt2.ReadOnly = true;
            this.finAt2.Width = 70;
            // 
            // tipo2
            // 
            this.tipo2.HeaderText = "Tipo Cliente En 2";
            this.tipo2.MinimumWidth = 6;
            this.tipo2.Name = "tipo2";
            this.tipo2.ReadOnly = true;
            this.tipo2.Width = 70;
            // 
            // colaCli
            // 
            this.colaCli.HeaderText = "Cola Clientes";
            this.colaCli.MinimumWidth = 6;
            this.colaCli.Name = "colaCli";
            this.colaCli.ReadOnly = true;
            this.colaCli.Width = 50;
            // 
            // colaCred
            // 
            this.colaCred.HeaderText = "Cola Credito";
            this.colaCred.MinimumWidth = 6;
            this.colaCred.Name = "colaCred";
            this.colaCred.ReadOnly = true;
            this.colaCred.Width = 50;
            // 
            // colaCont
            // 
            this.colaCont.HeaderText = "Cola Contado";
            this.colaCont.MinimumWidth = 6;
            this.colaCont.Name = "colaCont";
            this.colaCont.ReadOnly = true;
            this.colaCont.Width = 50;
            // 
            // restTras
            // 
            this.restTras.HeaderText = "Restante Traslado";
            this.restTras.MinimumWidth = 6;
            this.restTras.Name = "restTras";
            this.restTras.ReadOnly = true;
            this.restTras.Width = 70;
            // 
            // proximoFinTraslado
            // 
            this.proximoFinTraslado.HeaderText = "Proximo Fin Traslado";
            this.proximoFinTraslado.MinimumWidth = 6;
            this.proximoFinTraslado.Name = "proximoFinTraslado";
            this.proximoFinTraslado.ReadOnly = true;
            this.proximoFinTraslado.Width = 70;
            // 
            // contCred
            // 
            this.contCred.HeaderText = "Contador Credito";
            this.contCred.MinimumWidth = 6;
            this.contCred.Name = "contCred";
            this.contCred.ReadOnly = true;
            this.contCred.Width = 70;
            // 
            // acTiempoCred
            // 
            this.acTiempoCred.HeaderText = "AC Tiempo Credito";
            this.acTiempoCred.MinimumWidth = 6;
            this.acTiempoCred.Name = "acTiempoCred";
            this.acTiempoCred.ReadOnly = true;
            this.acTiempoCred.Width = 70;
            // 
            // tipoEntrega
            // 
            this.tipoEntrega.HeaderText = "Tipo Entrega";
            this.tipoEntrega.MinimumWidth = 6;
            this.tipoEntrega.Name = "tipoEntrega";
            this.tipoEntrega.ReadOnly = true;
            this.tipoEntrega.Width = 70;
            // 
            // inicioC1
            // 
            this.inicioC1.HeaderText = "Inicio Espera C1";
            this.inicioC1.MinimumWidth = 6;
            this.inicioC1.Name = "inicioC1";
            this.inicioC1.ReadOnly = true;
            this.inicioC1.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.probabilidad);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maxLleg);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.minLleg);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.reparto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.maxAt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.minAt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 844);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(951, 134);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametros";
            // 
            // probabilidad
            // 
            this.probabilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.probabilidad.DecimalPlaces = 3;
            this.probabilidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.probabilidad.Location = new System.Drawing.Point(699, 75);
            this.probabilidad.Margin = new System.Windows.Forms.Padding(4);
            this.probabilidad.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            262144});
            this.probabilidad.Name = "probabilidad";
            this.probabilidad.Size = new System.Drawing.Size(79, 27);
            this.probabilidad.TabIndex = 43;
            this.probabilidad.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Probabilidad Credito:";
            // 
            // maxLleg
            // 
            this.maxLleg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxLleg.DecimalPlaces = 3;
            this.maxLleg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.maxLleg.Location = new System.Drawing.Point(787, 40);
            this.maxLleg.Margin = new System.Windows.Forms.Padding(4);
            this.maxLleg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxLleg.Name = "maxLleg";
            this.maxLleg.Size = new System.Drawing.Size(79, 27);
            this.maxLleg.TabIndex = 14;
            this.maxLleg.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(874, 50);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = ") min";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(765, 47);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = ",";
            // 
            // minLleg
            // 
            this.minLleg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minLleg.DecimalPlaces = 3;
            this.minLleg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.minLleg.Location = new System.Drawing.Point(678, 40);
            this.minLleg.Margin = new System.Windows.Forms.Padding(4);
            this.minLleg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minLleg.Name = "minLleg";
            this.minLleg.Size = new System.Drawing.Size(79, 27);
            this.minLleg.TabIndex = 13;
            this.minLleg.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(500, 42);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 17);
            this.label21.TabIndex = 40;
            this.label21.Text = "Llegada: Uniforme(";
            // 
            // reparto
            // 
            this.reparto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reparto.DecimalPlaces = 3;
            this.reparto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.reparto.Location = new System.Drawing.Point(228, 65);
            this.reparto.Margin = new System.Windows.Forms.Padding(4);
            this.reparto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.reparto.Name = "reparto";
            this.reparto.Size = new System.Drawing.Size(79, 27);
            this.reparto.TabIndex = 18;
            this.reparto.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Reparto: Constante:";
            // 
            // maxAt
            // 
            this.maxAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxAt.DecimalPlaces = 3;
            this.maxAt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.maxAt.Location = new System.Drawing.Point(336, 32);
            this.maxAt.Margin = new System.Windows.Forms.Padding(4);
            this.maxAt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxAt.Name = "maxAt";
            this.maxAt.Size = new System.Drawing.Size(79, 27);
            this.maxAt.TabIndex = 16;
            this.maxAt.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(423, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = ") min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(315, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = ",";
            // 
            // minAt
            // 
            this.minAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minAt.DecimalPlaces = 3;
            this.minAt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.minAt.Location = new System.Drawing.Point(228, 28);
            this.minAt.Margin = new System.Windows.Forms.Padding(4);
            this.minAt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minAt.Name = "minAt";
            this.minAt.Size = new System.Drawing.Size(79, 27);
            this.minAt.TabIndex = 15;
            this.minAt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Atencion: Uniforme(";
            // 
            // solucionFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::SIM_TP2.Properties.Resources.fondoTP51;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.grpRes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "solucionFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final - Solución";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionesSim)).EndInit();
            this.grpRes.ResumeLayout(false);
            this.grpRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLleg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLleg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown iteracionesSim;
        private Guna.UI.WinForms.GunaButton btnIniciar;
        private Guna.UI.WinForms.GunaButton btnVolver;
        private System.Windows.Forms.GroupBox grpRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown maxLleg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown minLleg;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown reparto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown maxAt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown minAt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown probabilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn relojSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finAt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finAt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCred;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn restTras;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinTraslado;
        private System.Windows.Forms.DataGridViewTextBoxColumn contCred;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoCred;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioC1;
    }
}