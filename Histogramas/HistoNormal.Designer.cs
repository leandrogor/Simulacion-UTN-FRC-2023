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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFreq
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFreq.Legends.Add(legend1);
            this.chartFreq.Location = new System.Drawing.Point(53, 23);
            this.chartFreq.Name = "chartFreq";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencias";
            this.chartFreq.Series.Add(series1);
            this.chartFreq.Size = new System.Drawing.Size(686, 391);
            this.chartFreq.TabIndex = 0;
            this.chartFreq.Text = "chartFreq";
            this.chartFreq.Click += new System.EventHandler(this.chartFreq_Click);
            // 
            // HistoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFreq);
            this.Name = "HistoNormal";
            this.Text = "HistoNormal";
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
    }
}