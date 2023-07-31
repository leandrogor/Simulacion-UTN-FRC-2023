namespace SIM_TP2.Final_Gor
{
    partial class consignaFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consignaFinal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Consigna = new System.Windows.Forms.Label();
            this.btnVolver = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIM_TP2.Properties.Resources.consignaFinal;
            this.pictureBox1.Location = new System.Drawing.Point(47, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Consigna
            // 
            this.lbl_Consigna.AutoSize = true;
            this.lbl_Consigna.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Consigna.Font = new System.Drawing.Font("SimSun-ExtB", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consigna.ForeColor = System.Drawing.Color.Beige;
            this.lbl_Consigna.Location = new System.Drawing.Point(73, 20);
            this.lbl_Consigna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Consigna.Name = "lbl_Consigna";
            this.lbl_Consigna.Size = new System.Drawing.Size(194, 42);
            this.lbl_Consigna.TabIndex = 2;
            this.lbl_Consigna.Text = "CONSIGNA";
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
            this.btnVolver.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = null;
            this.btnVolver.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVolver.Location = new System.Drawing.Point(394, 424);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVolver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVolver.OnHoverImage = null;
            this.btnVolver.OnPressedColor = System.Drawing.Color.Black;
            this.btnVolver.Size = new System.Drawing.Size(158, 47);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // consignaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources.fondoTP5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 575);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbl_Consigna);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("SimSun-ExtB", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "consignaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final - Consigna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Consigna;
        private Guna.UI.WinForms.GunaButton btnVolver;
    }
}