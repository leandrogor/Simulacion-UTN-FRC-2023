namespace SIM_TP2.TP5
{
    partial class mainTP5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainTP5));
            this.btnSolucion = new Guna.UI.WinForms.GunaButton();
            this.btnConsigna = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolucion
            // 
            this.btnSolucion.AnimationHoverSpeed = 0.07F;
            this.btnSolucion.AnimationSpeed = 0.03F;
            this.btnSolucion.BackColor = System.Drawing.Color.Transparent;
            this.btnSolucion.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite1;
            this.btnSolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolucion.BaseColor = System.Drawing.Color.Transparent;
            this.btnSolucion.BorderColor = System.Drawing.Color.Black;
            this.btnSolucion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSolucion.FocusedColor = System.Drawing.Color.Empty;
            this.btnSolucion.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolucion.ForeColor = System.Drawing.Color.Black;
            this.btnSolucion.Image = null;
            this.btnSolucion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSolucion.Location = new System.Drawing.Point(506, 411);
            this.btnSolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSolucion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSolucion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSolucion.OnHoverImage = null;
            this.btnSolucion.OnPressedColor = System.Drawing.Color.Black;
            this.btnSolucion.Size = new System.Drawing.Size(182, 72);
            this.btnSolucion.TabIndex = 0;
            this.btnSolucion.Text = "SOLUCION";
            this.btnSolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSolucion.Click += new System.EventHandler(this.btnSolucion_Click);
            // 
            // btnConsigna
            // 
            this.btnConsigna.AnimationHoverSpeed = 0.07F;
            this.btnConsigna.AnimationSpeed = 0.03F;
            this.btnConsigna.BackColor = System.Drawing.Color.Transparent;
            this.btnConsigna.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite1;
            this.btnConsigna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsigna.BaseColor = System.Drawing.Color.Transparent;
            this.btnConsigna.BorderColor = System.Drawing.Color.Black;
            this.btnConsigna.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConsigna.FocusedColor = System.Drawing.Color.Empty;
            this.btnConsigna.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsigna.ForeColor = System.Drawing.Color.Black;
            this.btnConsigna.Image = null;
            this.btnConsigna.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConsigna.Location = new System.Drawing.Point(296, 411);
            this.btnConsigna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsigna.Name = "btnConsigna";
            this.btnConsigna.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnConsigna.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsigna.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsigna.OnHoverImage = null;
            this.btnConsigna.OnPressedColor = System.Drawing.Color.Black;
            this.btnConsigna.Size = new System.Drawing.Size(182, 72);
            this.btnConsigna.TabIndex = 1;
            this.btnConsigna.Text = "CONSIGNA";
            this.btnConsigna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConsigna.Click += new System.EventHandler(this.btnConsigna_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mainTP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSolucion);
            this.Controls.Add(this.btnConsigna);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainTP5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Práctico Nº5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSolucion;
        private Guna.UI.WinForms.GunaButton btnConsigna;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}