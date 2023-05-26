namespace SIM_TP2.TP4
{
    partial class main_TP4
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
            this.dgv_cola = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaFutbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegadaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaHandball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegadaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaBasket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegadaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcEsperaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcEsperaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcEsperaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcLlegadaGrupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcGruposRetirados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaCliente6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cola
            // 
            this.dgv_cola.AllowUserToDeleteRows = false;
            this.dgv_cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NombreEvento,
            this.Reloj,
            this.RND1,
            this.LlegadaFutbol,
            this.ProxLlegadaF,
            this.RND2,
            this.LlegadaHandball,
            this.ProxLlegadaH,
            this.RND3,
            this.LlegadaBasket,
            this.ProxLlegadaB,
            this.RND4,
            this.TiempoF,
            this.TiempoH,
            this.TiempoB,
            this.ProxFinJuego,
            this.EstadoCola,
            this.Cola,
            this.AcEsperaF,
            this.AcEsperaH,
            this.AcEsperaB,
            this.AcLlegadaGrupos,
            this.AcGruposRetirados,
            this.TipoCliente1,
            this.EstadoCliente1,
            this.HoraLlegadaCliente1,
            this.TipoCliente2,
            this.EstadoCliente2,
            this.HoraLlegadaCliente2,
            this.TipoCliente3,
            this.EstadoCliente3,
            this.HoraLlegadaCliente3,
            this.TipoCliente4,
            this.EstadoCliente4,
            this.HoraLlegadaCliente4,
            this.TipoCliente5,
            this.EstadoCliente5,
            this.HoraLlegadaCliente5,
            this.TipoCliente6,
            this.EstadoCliente6,
            this.HoraLlegadaCliente6});
            this.dgv_cola.Location = new System.Drawing.Point(12, 262);
            this.dgv_cola.Name = "dgv_cola";
            this.dgv_cola.ReadOnly = true;
            this.dgv_cola.Size = new System.Drawing.Size(1944, 420);
            this.dgv_cola.TabIndex = 0;
            this.dgv_cola.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cola_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 30;
            // 
            // NombreEvento
            // 
            this.NombreEvento.Frozen = true;
            this.NombreEvento.HeaderText = "Nombre Evento";
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.ReadOnly = true;
            this.NombreEvento.Width = 75;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            this.Reloj.Width = 50;
            // 
            // RND1
            // 
            this.RND1.HeaderText = "RND1";
            this.RND1.Name = "RND1";
            this.RND1.ReadOnly = true;
            this.RND1.Width = 50;
            // 
            // LlegadaFutbol
            // 
            this.LlegadaFutbol.HeaderText = "Llegada Futbol";
            this.LlegadaFutbol.Name = "LlegadaFutbol";
            this.LlegadaFutbol.ReadOnly = true;
            this.LlegadaFutbol.Width = 75;
            // 
            // ProxLlegadaF
            // 
            this.ProxLlegadaF.HeaderText = "Proxima Llegada Futbol";
            this.ProxLlegadaF.Name = "ProxLlegadaF";
            this.ProxLlegadaF.ReadOnly = true;
            this.ProxLlegadaF.Width = 75;
            // 
            // RND2
            // 
            this.RND2.HeaderText = "RND2";
            this.RND2.Name = "RND2";
            this.RND2.ReadOnly = true;
            this.RND2.Width = 50;
            // 
            // LlegadaHandball
            // 
            this.LlegadaHandball.HeaderText = "Llegada Handball";
            this.LlegadaHandball.Name = "LlegadaHandball";
            this.LlegadaHandball.ReadOnly = true;
            this.LlegadaHandball.Width = 75;
            // 
            // ProxLlegadaH
            // 
            this.ProxLlegadaH.HeaderText = "Proxima Llegada Handball";
            this.ProxLlegadaH.Name = "ProxLlegadaH";
            this.ProxLlegadaH.ReadOnly = true;
            this.ProxLlegadaH.Width = 75;
            // 
            // RND3
            // 
            this.RND3.HeaderText = "RND3";
            this.RND3.Name = "RND3";
            this.RND3.ReadOnly = true;
            this.RND3.Width = 50;
            // 
            // LlegadaBasket
            // 
            this.LlegadaBasket.HeaderText = "Llegada Basketball";
            this.LlegadaBasket.Name = "LlegadaBasket";
            this.LlegadaBasket.ReadOnly = true;
            this.LlegadaBasket.Width = 75;
            // 
            // ProxLlegadaB
            // 
            this.ProxLlegadaB.HeaderText = "Proxima Llegada Basketball";
            this.ProxLlegadaB.Name = "ProxLlegadaB";
            this.ProxLlegadaB.ReadOnly = true;
            this.ProxLlegadaB.Width = 75;
            // 
            // RND4
            // 
            this.RND4.HeaderText = "RND4";
            this.RND4.Name = "RND4";
            this.RND4.ReadOnly = true;
            this.RND4.Width = 50;
            // 
            // TiempoF
            // 
            this.TiempoF.HeaderText = "TiempoF";
            this.TiempoF.Name = "TiempoF";
            this.TiempoF.ReadOnly = true;
            this.TiempoF.Width = 60;
            // 
            // TiempoH
            // 
            this.TiempoH.HeaderText = "TiempoH";
            this.TiempoH.Name = "TiempoH";
            this.TiempoH.ReadOnly = true;
            this.TiempoH.Width = 60;
            // 
            // TiempoB
            // 
            this.TiempoB.HeaderText = "TiempoB";
            this.TiempoB.Name = "TiempoB";
            this.TiempoB.ReadOnly = true;
            this.TiempoB.Width = 60;
            // 
            // ProxFinJuego
            // 
            this.ProxFinJuego.HeaderText = "Proximo Fin Juego";
            this.ProxFinJuego.Name = "ProxFinJuego";
            this.ProxFinJuego.ReadOnly = true;
            this.ProxFinJuego.Width = 50;
            // 
            // EstadoCola
            // 
            this.EstadoCola.HeaderText = "Estado";
            this.EstadoCola.Name = "EstadoCola";
            this.EstadoCola.ReadOnly = true;
            // 
            // Cola
            // 
            this.Cola.HeaderText = "Cola";
            this.Cola.Name = "Cola";
            this.Cola.ReadOnly = true;
            this.Cola.Width = 35;
            // 
            // AcEsperaF
            // 
            this.AcEsperaF.HeaderText = "Acumulador Espera Futbol";
            this.AcEsperaF.Name = "AcEsperaF";
            this.AcEsperaF.ReadOnly = true;
            this.AcEsperaF.Width = 75;
            // 
            // AcEsperaH
            // 
            this.AcEsperaH.HeaderText = "Acumulador Espera Handball";
            this.AcEsperaH.Name = "AcEsperaH";
            this.AcEsperaH.ReadOnly = true;
            this.AcEsperaH.Width = 75;
            // 
            // AcEsperaB
            // 
            this.AcEsperaB.HeaderText = "Acumulador Espera Basketball";
            this.AcEsperaB.Name = "AcEsperaB";
            this.AcEsperaB.ReadOnly = true;
            this.AcEsperaB.Width = 75;
            // 
            // AcLlegadaGrupos
            // 
            this.AcLlegadaGrupos.HeaderText = "Acumulador Llegada Grupos";
            this.AcLlegadaGrupos.Name = "AcLlegadaGrupos";
            this.AcLlegadaGrupos.ReadOnly = true;
            this.AcLlegadaGrupos.Width = 75;
            // 
            // AcGruposRetirados
            // 
            this.AcGruposRetirados.HeaderText = "Acumulador grupos retirados sin jugar";
            this.AcGruposRetirados.Name = "AcGruposRetirados";
            this.AcGruposRetirados.ReadOnly = true;
            this.AcGruposRetirados.Width = 75;
            // 
            // TipoCliente1
            // 
            this.TipoCliente1.HeaderText = "Tipo Cliente1";
            this.TipoCliente1.Name = "TipoCliente1";
            this.TipoCliente1.ReadOnly = true;
            this.TipoCliente1.Width = 60;
            // 
            // EstadoCliente1
            // 
            this.EstadoCliente1.HeaderText = "Estado Cliente1";
            this.EstadoCliente1.Name = "EstadoCliente1";
            this.EstadoCliente1.ReadOnly = true;
            this.EstadoCliente1.Width = 65;
            // 
            // HoraLlegadaCliente1
            // 
            this.HoraLlegadaCliente1.HeaderText = "Hora Llegada Cliente1";
            this.HoraLlegadaCliente1.Name = "HoraLlegadaCliente1";
            this.HoraLlegadaCliente1.ReadOnly = true;
            this.HoraLlegadaCliente1.Width = 55;
            // 
            // TipoCliente2
            // 
            this.TipoCliente2.HeaderText = "Tipo Cliente 2";
            this.TipoCliente2.Name = "TipoCliente2";
            this.TipoCliente2.ReadOnly = true;
            this.TipoCliente2.Width = 60;
            // 
            // EstadoCliente2
            // 
            this.EstadoCliente2.HeaderText = "Estado Cliente 2";
            this.EstadoCliente2.Name = "EstadoCliente2";
            this.EstadoCliente2.ReadOnly = true;
            this.EstadoCliente2.Width = 65;
            // 
            // HoraLlegadaCliente2
            // 
            this.HoraLlegadaCliente2.HeaderText = "Hora Llegada Cliente2";
            this.HoraLlegadaCliente2.Name = "HoraLlegadaCliente2";
            this.HoraLlegadaCliente2.ReadOnly = true;
            this.HoraLlegadaCliente2.Width = 55;
            // 
            // TipoCliente3
            // 
            this.TipoCliente3.HeaderText = "Tipo Cliente 3";
            this.TipoCliente3.Name = "TipoCliente3";
            this.TipoCliente3.ReadOnly = true;
            this.TipoCliente3.Width = 60;
            // 
            // EstadoCliente3
            // 
            this.EstadoCliente3.HeaderText = "Estado Cliente 3";
            this.EstadoCliente3.Name = "EstadoCliente3";
            this.EstadoCliente3.ReadOnly = true;
            this.EstadoCliente3.Width = 65;
            // 
            // HoraLlegadaCliente3
            // 
            this.HoraLlegadaCliente3.HeaderText = "Hora Llegada Cliente3";
            this.HoraLlegadaCliente3.Name = "HoraLlegadaCliente3";
            this.HoraLlegadaCliente3.ReadOnly = true;
            this.HoraLlegadaCliente3.Width = 55;
            // 
            // TipoCliente4
            // 
            this.TipoCliente4.HeaderText = "Tipo Cliente4";
            this.TipoCliente4.Name = "TipoCliente4";
            this.TipoCliente4.ReadOnly = true;
            this.TipoCliente4.Width = 60;
            // 
            // EstadoCliente4
            // 
            this.EstadoCliente4.HeaderText = "Estado Cliente 4";
            this.EstadoCliente4.Name = "EstadoCliente4";
            this.EstadoCliente4.ReadOnly = true;
            this.EstadoCliente4.Width = 65;
            // 
            // HoraLlegadaCliente4
            // 
            this.HoraLlegadaCliente4.HeaderText = "Hora Llegada Cliente4";
            this.HoraLlegadaCliente4.Name = "HoraLlegadaCliente4";
            this.HoraLlegadaCliente4.ReadOnly = true;
            this.HoraLlegadaCliente4.Width = 55;
            // 
            // TipoCliente5
            // 
            this.TipoCliente5.HeaderText = "Tipo Cliente5";
            this.TipoCliente5.Name = "TipoCliente5";
            this.TipoCliente5.ReadOnly = true;
            this.TipoCliente5.Width = 60;
            // 
            // EstadoCliente5
            // 
            this.EstadoCliente5.HeaderText = "Estado Cliente5";
            this.EstadoCliente5.Name = "EstadoCliente5";
            this.EstadoCliente5.ReadOnly = true;
            this.EstadoCliente5.Width = 65;
            // 
            // HoraLlegadaCliente5
            // 
            this.HoraLlegadaCliente5.HeaderText = "Hora Llegada Cliente5";
            this.HoraLlegadaCliente5.Name = "HoraLlegadaCliente5";
            this.HoraLlegadaCliente5.ReadOnly = true;
            this.HoraLlegadaCliente5.Width = 55;
            // 
            // TipoCliente6
            // 
            this.TipoCliente6.HeaderText = "Tipo Cliente6";
            this.TipoCliente6.Name = "TipoCliente6";
            this.TipoCliente6.ReadOnly = true;
            this.TipoCliente6.Width = 60;
            // 
            // EstadoCliente6
            // 
            this.EstadoCliente6.HeaderText = "Estado Cliente6";
            this.EstadoCliente6.Name = "EstadoCliente6";
            this.EstadoCliente6.ReadOnly = true;
            this.EstadoCliente6.Width = 65;
            // 
            // HoraLlegadaCliente6
            // 
            this.HoraLlegadaCliente6.HeaderText = "Hora Llegada Cliente6";
            this.HoraLlegadaCliente6.Name = "HoraLlegadaCliente6";
            this.HoraLlegadaCliente6.ReadOnly = true;
            this.HoraLlegadaCliente6.Width = 55;
            // 
            // main_TP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 706);
            this.Controls.Add(this.dgv_cola);
            this.Name = "main_TP4";
            this.Text = "main_tp4";
            this.Load += new System.EventHandler(this.main_TP4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlegadaFutbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegadaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlegadaHandball;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegadaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlegadaBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegadaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcEsperaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcEsperaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcEsperaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcLlegadaGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcGruposRetirados;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente4;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente5;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente6;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaCliente6;
    }
}