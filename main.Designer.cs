namespace SIM_TP2
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo Práctico Nro 2 de Simulación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generador de variables aleatorias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUniforme
            // 
            this.btnUniforme.Location = new System.Drawing.Point(45, 127);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(139, 47);
            this.btnUniforme.TabIndex = 2;
            this.btnUniforme.Text = "UNIFORME";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Location = new System.Drawing.Point(223, 127);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(139, 47);
            this.btnExponencial.TabIndex = 3;
            this.btnExponencial.Text = "EXPONENCIAL";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(407, 127);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(139, 47);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "EXPONENCIAL";
            this.btnNormal.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.btnUniforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación - TP2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnNormal;
    }
}

