
namespace AdditionalUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueChart
            // 
            chartArea1.Name = "data";
            this.revenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.revenueChart.Legends.Add(legend1);
            this.revenueChart.Location = new System.Drawing.Point(12, 12);
            this.revenueChart.Name = "revenueChart";
            series1.ChartArea = "data";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Salaries";
            this.revenueChart.Series.Add(series1);
            this.revenueChart.Size = new System.Drawing.Size(873, 489);
            this.revenueChart.TabIndex = 1;
            this.revenueChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Revenue Chart";
            this.revenueChart.Titles.Add(title1);
            this.revenueChart.Click += new System.EventHandler(this.revenueChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 513);
            this.Controls.Add(this.revenueChart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Employe Wage Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
    }
}

