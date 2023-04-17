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
            this.chartFreqUnif = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqUnif)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFreqUnif
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFreqUnif.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFreqUnif.Legends.Add(legend1);
            this.chartFreqUnif.Location = new System.Drawing.Point(62, 21);
            this.chartFreqUnif.Name = "chartFreqUnif";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencias";
            this.chartFreqUnif.Series.Add(series1);
            this.chartFreqUnif.Size = new System.Drawing.Size(675, 342);
            this.chartFreqUnif.TabIndex = 0;
            this.chartFreqUnif.Text = "chartFreqUnif";
            // 
            // HistoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 439);
            this.Controls.Add(this.chartFreqUnif);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoUniforme";
            this.Load += new System.EventHandler(this.HistoUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqUnif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreqUnif;
    }
}