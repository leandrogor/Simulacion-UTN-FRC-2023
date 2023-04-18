namespace SIM_TP2.Histogramas
{
    partial class HistoUniforme
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoUniforme));
            this.chrUniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrUniforme)).BeginInit();
            this.SuspendLayout();
            // 
            // chrUniforme
            // 
            this.chrUniforme.BackColor = System.Drawing.Color.Wheat;
            this.chrUniforme.BackSecondaryColor = System.Drawing.Color.LemonChiffon;
            this.chrUniforme.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrUniforme.ChartAreas.Add(chartArea1);
            this.chrUniforme.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrUniforme.Legends.Add(legend1);
            this.chrUniforme.Location = new System.Drawing.Point(0, 0);
            this.chrUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.chrUniforme.Name = "chrUniforme";
            this.chrUniforme.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Frecuencias";
            this.chrUniforme.Series.Add(series1);
            this.chrUniforme.Size = new System.Drawing.Size(800, 450);
            this.chrUniforme.TabIndex = 1;
            this.chrUniforme.Text = "chartFreq";
            title1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.SaddleBrown;
            title1.Name = "Title1";
            title1.Text = "Histograma Uniforme";
            this.chrUniforme.Titles.Add(title1);
            // 
            // HistoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrUniforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoUniforme";
            ((System.ComponentModel.ISupportInitialize)(this.chrUniforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrUniforme;
    }
}