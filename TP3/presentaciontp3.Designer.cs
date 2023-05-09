namespace SIM_TP2.TP3
{
    partial class presentaciontp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(presentaciontp3));
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.btnTP3 = new Guna.UI.WinForms.GunaButton();
            this.consigna = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_SLIDE;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // btnTP3
            // 
            this.btnTP3.AnimationHoverSpeed = 0.07F;
            this.btnTP3.AnimationSpeed = 0.03F;
            this.btnTP3.BackColor = System.Drawing.Color.Transparent;
            this.btnTP3.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite__1_;
            this.btnTP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTP3.BaseColor = System.Drawing.Color.Transparent;
            this.btnTP3.BorderColor = System.Drawing.Color.Black;
            this.btnTP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTP3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTP3.FocusedColor = System.Drawing.Color.Empty;
            this.btnTP3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTP3.ForeColor = System.Drawing.Color.Black;
            this.btnTP3.Image = null;
            this.btnTP3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTP3.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTP3.Location = new System.Drawing.Point(550, 304);
            this.btnTP3.Name = "btnTP3";
            this.btnTP3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnTP3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTP3.OnHoverForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTP3.OnHoverImage = global::SIM_TP2.Properties.Resources.Dibujado_a_Mano_Marrón_y_Verde_Arte_Iconos_Conjunto_de_Iconos;
            this.btnTP3.OnPressedColor = System.Drawing.Color.Black;
            this.btnTP3.Size = new System.Drawing.Size(256, 84);
            this.btnTP3.TabIndex = 0;
            this.btnTP3.Text = "Resolucion";
            this.btnTP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTP3.UseTransfarantBackground = true;
            this.btnTP3.Click += new System.EventHandler(this.btnTP3_Click);
            // 
            // consigna
            // 
            this.consigna.AnimationHoverSpeed = 0.07F;
            this.consigna.AnimationSpeed = 0.03F;
            this.consigna.BackColor = System.Drawing.Color.Transparent;
            this.consigna.BackgroundImage = global::SIM_TP2.Properties.Resources.Copia_de_buttonwhite__1_;
            this.consigna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.consigna.BaseColor = System.Drawing.Color.Transparent;
            this.consigna.BorderColor = System.Drawing.Color.Black;
            this.consigna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consigna.DialogResult = System.Windows.Forms.DialogResult.None;
            this.consigna.FocusedColor = System.Drawing.Color.Empty;
            this.consigna.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consigna.ForeColor = System.Drawing.Color.Black;
            this.consigna.Image = null;
            this.consigna.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.consigna.ImageSize = new System.Drawing.Size(20, 20);
            this.consigna.Location = new System.Drawing.Point(207, 304);
            this.consigna.Name = "consigna";
            this.consigna.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.consigna.OnHoverBorderColor = System.Drawing.Color.Black;
            this.consigna.OnHoverForeColor = System.Drawing.Color.MidnightBlue;
            this.consigna.OnHoverImage = global::SIM_TP2.Properties.Resources.Dibujado_a_Mano_Marrón_y_Verde_Arte_Iconos_Conjunto_de_Iconos;
            this.consigna.OnPressedColor = System.Drawing.Color.Black;
            this.consigna.Size = new System.Drawing.Size(256, 84);
            this.consigna.TabIndex = 1;
            this.consigna.Text = "Consigna";
            this.consigna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.consigna.UseTransfarantBackground = true;
            this.consigna.Click += new System.EventHandler(this.consigna_Click);
            // 
            // presentaciontp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources.maintp3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 547);
            this.Controls.Add(this.consigna);
            this.Controls.Add(this.btnTP3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "presentaciontp3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Practico N°3";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaButton btnTP3;
        private Guna.UI.WinForms.GunaButton consigna;
    }
}