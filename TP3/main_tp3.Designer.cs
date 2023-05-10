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
            this.iteracionestxt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.vueltastxt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTipoDestinatario = new System.Windows.Forms.DataGridView();
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
            this.ultfila = new Guna.UI.WinForms.GunaLabel();
            this.btnIniciar = new Guna.UI.WinForms.GunaButton();
            this.volver = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionestxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueltastxt)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trabajo Práctico Nro 3 de Simulación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(1041, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ejercicio nro 3: Nuevo Servicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(357, 114);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 30);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(18, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(210, 27);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad de Filas (N):";
            // 
            // iteracionestxt
            // 
            this.iteracionestxt.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteracionestxt.Location = new System.Drawing.Point(357, 158);
            this.iteracionestxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iteracionestxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iteracionestxt.Name = "iteracionestxt";
            this.iteracionestxt.Size = new System.Drawing.Size(120, 30);
            this.iteracionestxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Inicio de muestra de iteraciones (j):";
            // 
            // vueltastxt
            // 
            this.vueltastxt.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueltastxt.Location = new System.Drawing.Point(357, 207);
            this.vueltastxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vueltastxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vueltastxt.Name = "vueltastxt";
            this.vueltastxt.Size = new System.Drawing.Size(120, 30);
            this.vueltastxt.TabIndex = 4;
            this.vueltastxt.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad de Vueltas a mostrar (i):";
            // 
            // dgvTipoDestinatario
            // 
            this.dgvTipoDestinatario.AllowUserToAddRows = false;
            this.dgvTipoDestinatario.AllowUserToDeleteRows = false;
            this.dgvTipoDestinatario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvTipoDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoDestinatario.ColumnHeadersHeight = 29;
            this.dgvTipoDestinatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTipoDestinatario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTipoDestinatario.Location = new System.Drawing.Point(505, 97);
            this.dgvTipoDestinatario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTipoDestinatario.Name = "dgvTipoDestinatario";
            this.dgvTipoDestinatario.RowHeadersVisible = false;
            this.dgvTipoDestinatario.RowHeadersWidth = 51;
            this.dgvTipoDestinatario.RowTemplate.Height = 24;
            this.dgvTipoDestinatario.Size = new System.Drawing.Size(645, 114);
            this.dgvTipoDestinatario.TabIndex = 27;
            this.dgvTipoDestinatario.TabStop = false;
            // 
            // dgvSolicitaAsesor
            // 
            this.dgvSolicitaAsesor.AllowUserToAddRows = false;
            this.dgvSolicitaAsesor.AllowUserToDeleteRows = false;
            this.dgvSolicitaAsesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvSolicitaAsesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitaAsesor.ColumnHeadersHeight = 29;
            this.dgvSolicitaAsesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSolicitaAsesor.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSolicitaAsesor.Location = new System.Drawing.Point(1244, 97);
            this.dgvSolicitaAsesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSolicitaAsesor.Name = "dgvSolicitaAsesor";
            this.dgvSolicitaAsesor.RowHeadersVisible = false;
            this.dgvSolicitaAsesor.RowHeadersWidth = 51;
            this.dgvSolicitaAsesor.RowTemplate.Height = 24;
            this.dgvSolicitaAsesor.Size = new System.Drawing.Size(645, 114);
            this.dgvSolicitaAsesor.TabIndex = 27;
            this.dgvSolicitaAsesor.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(83, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1728, 469);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
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
            this.tipo_destinatario.Width = 130;
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
            this.dgvUltimaFila.AllowUserToDeleteRows = false;
            this.dgvUltimaFila.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvUltimaFila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimaFila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroUltima,
            this.RND_tipo_destinatario_ultima,
            this.tipo_destinatario_ultima,
            this.RND_solicita_asesor_ultima,
            this.solicita_asesor_ultima,
            this.acum_solicita_asesor_ultima});
            this.dgvUltimaFila.Location = new System.Drawing.Point(83, 856);
            this.dgvUltimaFila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUltimaFila.Name = "dgvUltimaFila";
            this.dgvUltimaFila.ReadOnly = true;
            this.dgvUltimaFila.RowHeadersVisible = false;
            this.dgvUltimaFila.RowHeadersWidth = 51;
            this.dgvUltimaFila.Size = new System.Drawing.Size(1498, 131);
            this.dgvUltimaFila.TabIndex = 32;
            this.dgvUltimaFila.Visible = false;
            // 
            // NumeroUltima
            // 
            this.NumeroUltima.Frozen = true;
            this.NumeroUltima.HeaderText = "Numero";
            this.NumeroUltima.MinimumWidth = 6;
            this.NumeroUltima.Name = "NumeroUltima";
            this.NumeroUltima.ReadOnly = true;
            this.NumeroUltima.Width = 125;
            // 
            // RND_tipo_destinatario_ultima
            // 
            this.RND_tipo_destinatario_ultima.Frozen = true;
            this.RND_tipo_destinatario_ultima.HeaderText = "RND Tipo Destinatario";
            this.RND_tipo_destinatario_ultima.MinimumWidth = 6;
            this.RND_tipo_destinatario_ultima.Name = "RND_tipo_destinatario_ultima";
            this.RND_tipo_destinatario_ultima.ReadOnly = true;
            this.RND_tipo_destinatario_ultima.Width = 125;
            // 
            // tipo_destinatario_ultima
            // 
            this.tipo_destinatario_ultima.Frozen = true;
            this.tipo_destinatario_ultima.HeaderText = "Tipo Destinatario";
            this.tipo_destinatario_ultima.MinimumWidth = 6;
            this.tipo_destinatario_ultima.Name = "tipo_destinatario_ultima";
            this.tipo_destinatario_ultima.ReadOnly = true;
            this.tipo_destinatario_ultima.Width = 125;
            // 
            // RND_solicita_asesor_ultima
            // 
            this.RND_solicita_asesor_ultima.Frozen = true;
            this.RND_solicita_asesor_ultima.HeaderText = "RND Solicita Asesor";
            this.RND_solicita_asesor_ultima.MinimumWidth = 6;
            this.RND_solicita_asesor_ultima.Name = "RND_solicita_asesor_ultima";
            this.RND_solicita_asesor_ultima.ReadOnly = true;
            this.RND_solicita_asesor_ultima.Width = 125;
            // 
            // solicita_asesor_ultima
            // 
            this.solicita_asesor_ultima.Frozen = true;
            this.solicita_asesor_ultima.HeaderText = "Solicita Asesor";
            this.solicita_asesor_ultima.MinimumWidth = 6;
            this.solicita_asesor_ultima.Name = "solicita_asesor_ultima";
            this.solicita_asesor_ultima.ReadOnly = true;
            this.solicita_asesor_ultima.Width = 125;
            // 
            // acum_solicita_asesor_ultima
            // 
            this.acum_solicita_asesor_ultima.Frozen = true;
            this.acum_solicita_asesor_ultima.HeaderText = "Acumulador solicita asesor";
            this.acum_solicita_asesor_ultima.MinimumWidth = 6;
            this.acum_solicita_asesor_ultima.Name = "acum_solicita_asesor_ultima";
            this.acum_solicita_asesor_ultima.ReadOnly = true;
            this.acum_solicita_asesor_ultima.Width = 125;
            // 
            // ultfila
            // 
            this.ultfila.AutoSize = true;
            this.ultfila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ultfila.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultfila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ultfila.Location = new System.Drawing.Point(77, 806);
            this.ultfila.Name = "ultfila";
            this.ultfila.Size = new System.Drawing.Size(128, 32);
            this.ultfila.TabIndex = 34;
            this.ultfila.Text = "Ultima Fila";
            this.ultfila.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.AnimationHoverSpeed = 0.07F;
            this.btnIniciar.AnimationSpeed = 0.03F;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite__2_;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.BaseColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIniciar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Image = null;
            this.btnIniciar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIniciar.Location = new System.Drawing.Point(74, 259);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnIniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIniciar.OnHoverForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnIniciar.OnHoverImage = global::SIM_TP2.Properties.Resources.Dibujado_a_Mano_Marrón_y_Verde_Arte_Iconos_Conjunto_de_Iconos;
            this.btnIniciar.OnPressedColor = System.Drawing.Color.White;
            this.btnIniciar.Size = new System.Drawing.Size(209, 59);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciar.UseTransfarantBackground = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // volver
            // 
            this.volver.AnimationHoverSpeed = 0.07F;
            this.volver.AnimationSpeed = 0.03F;
            this.volver.BackColor = System.Drawing.Color.Transparent;
            this.volver.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite__2_;
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volver.BaseColor = System.Drawing.Color.Transparent;
            this.volver.BorderColor = System.Drawing.Color.Black;
            this.volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.volver.FocusedColor = System.Drawing.Color.Empty;
            this.volver.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.ForeColor = System.Drawing.Color.White;
            this.volver.Image = null;
            this.volver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.volver.ImageSize = new System.Drawing.Size(20, 20);
            this.volver.Location = new System.Drawing.Point(1602, 870);
            this.volver.Name = "volver";
            this.volver.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.volver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.volver.OnHoverForeColor = System.Drawing.Color.MediumSpringGreen;
            this.volver.OnHoverImage = global::SIM_TP2.Properties.Resources.Dibujado_a_Mano_Marrón_y_Verde_Arte_Iconos_Conjunto_de_Iconos;
            this.volver.OnPressedColor = System.Drawing.Color.White;
            this.volver.Size = new System.Drawing.Size(209, 59);
            this.volver.TabIndex = 36;
            this.volver.Text = "Volver";
            this.volver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.volver.UseTransfarantBackground = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite__2_;
            this.gunaButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(289, 259);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaButton1.OnHoverImage = global::SIM_TP2.Properties.Resources.Dibujado_a_Mano_Marrón_y_Verde_Arte_Iconos_Conjunto_de_Iconos;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton1.Size = new System.Drawing.Size(391, 59);
            this.gunaButton1.TabIndex = 5;
            this.gunaButton1.Text = "Ver tabla intervalos";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.UseTransfarantBackground = true;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // main_tp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources.protada;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.ultfila);
            this.Controls.Add(this.dgvUltimaFila);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvSolicitaAsesor);
            this.Controls.Add(this.dgvTipoDestinatario);
            this.Controls.Add(this.vueltastxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iteracionestxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main_tp3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Práctico Número 3 de Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionestxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueltastxt)).EndInit();
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
        private System.Windows.Forms.NumericUpDown iteracionestxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown vueltastxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTipoDestinatario;
        private System.Windows.Forms.DataGridView dgvSolicitaAsesor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvUltimaFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroUltima;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_tipo_destinatario_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_destinatario_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_solicita_asesor_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicita_asesor_ultima;
        private System.Windows.Forms.DataGridViewTextBoxColumn acum_solicita_asesor_ultima;
        private Guna.UI.WinForms.GunaLabel ultfila;
        private Guna.UI.WinForms.GunaButton btnIniciar;
        private Guna.UI.WinForms.GunaButton volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_tipo_dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND_solicita_asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicita_asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acumulador;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}