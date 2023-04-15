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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad de Intervalos:";
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(182, 117);
            this.txtIntervalos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(89, 22);
            this.txtIntervalos.TabIndex = 20;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 92);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(133, 16);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad de Valores:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(182, 88);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(89, 22);
            this.txtCantidad.TabIndex = 18;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(73, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 16);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(73, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 16);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(182, 58);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(89, 22);
            this.txtB.TabIndex = 15;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(182, 29);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(89, 22);
            this.txtA.TabIndex = 14;
            // 
            // Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervalos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Uniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniforme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
    }
}