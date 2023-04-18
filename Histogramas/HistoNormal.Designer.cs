namespace SIM_TP2.Histogramas
{
    partial class HistoNormal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoNormal));
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFreq
            // 
            this.chartFreq.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chartFreq.BackSecondaryColor = System.Drawing.Color.Green;
            this.chartFreq.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea2);
            this.chartFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFreq.Legends.Add(legend2);
            this.chartFreq.Location = new System.Drawing.Point(0, 0);
            this.chartFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartFreq.Name = "chartFreq";
            this.chartFreq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Frecuencias";
            this.chartFreq.Series.Add(series2);
            this.chartFreq.Size = new System.Drawing.Size(882, 466);
            this.chartFreq.TabIndex = 0;
            this.chartFreq.Text = "chartFreq";
            title2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Histograma Normal";
            this.chartFreq.Titles.Add(title2);
            this.chartFreq.Click += new System.EventHandler(this.chartFreq_Click);
            // 
            // HistoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 466);
            this.Controls.Add(this.chartFreq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoNormal";
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
    }
}