namespace ChessApp
{
    partial class AccountStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelLocalPlay = new Label();
            labelComputerPlay = new Label();
            chartWins = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartOutcomes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartComputerWins = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartWins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOutcomes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartComputerWins).BeginInit();
            SuspendLayout();
            // 
            // labelLocalPlay
            // 
            labelLocalPlay.Anchor = AnchorStyles.None;
            labelLocalPlay.AutoSize = true;
            labelLocalPlay.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelLocalPlay.ForeColor = Color.White;
            labelLocalPlay.Location = new Point(56, -21);
            labelLocalPlay.Name = "labelLocalPlay";
            labelLocalPlay.Size = new Size(225, 59);
            labelLocalPlay.TabIndex = 1;
            labelLocalPlay.Text = "Local Play";
            labelLocalPlay.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelComputerPlay
            // 
            labelComputerPlay.Anchor = AnchorStyles.None;
            labelComputerPlay.AutoSize = true;
            labelComputerPlay.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelComputerPlay.ForeColor = Color.White;
            labelComputerPlay.Location = new Point(56, 477);
            labelComputerPlay.Name = "labelComputerPlay";
            labelComputerPlay.Size = new Size(323, 59);
            labelComputerPlay.TabIndex = 2;
            labelComputerPlay.Text = "Computer Play";
            labelComputerPlay.TextAlign = ContentAlignment.TopCenter;
            // 
            // chartWins
            // 
            chartWins.BackSecondaryColor = Color.FromArgb(56, 56, 56);
            chartWins.BorderlineColor = Color.FromArgb(56, 56, 56);
            chartArea1.Name = "ChartArea1";
            chartWins.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartWins.Legends.Add(legend1);
            chartWins.Location = new Point(56, 83);
            chartWins.Name = "chartWins";
            chartWins.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            chartWins.Series.Add(series1);
            chartWins.Size = new Size(521, 391);
            chartWins.TabIndex = 3;
            chartWins.Text = "chartWins";
            // 
            // chartOutcomes
            // 
            chartOutcomes.BackSecondaryColor = Color.FromArgb(56, 56, 56);
            chartOutcomes.BorderlineColor = Color.FromArgb(56, 56, 56);
            chartArea2.Name = "ChartArea1";
            chartOutcomes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartOutcomes.Legends.Add(legend2);
            chartOutcomes.Location = new Point(632, 83);
            chartOutcomes.Name = "chartOutcomes";
            chartOutcomes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            chartOutcomes.Series.Add(series2);
            chartOutcomes.Size = new Size(540, 391);
            chartOutcomes.TabIndex = 4;
            chartOutcomes.Text = "chartOutcomes";
            // 
            // chartComputerWins
            // 
            chartArea3.Name = "ChartArea1";
            chartComputerWins.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartComputerWins.Legends.Add(legend3);
            chartComputerWins.Location = new Point(56, 583);
            chartComputerWins.Name = "chartComputerWins";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            chartComputerWins.Series.Add(series3);
            chartComputerWins.Size = new Size(1116, 435);
            chartComputerWins.TabIndex = 5;
            chartComputerWins.Text = "chartComputerWins";
            // 
            // AccountStatistics
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1234, 993);
            Controls.Add(chartComputerWins);
            Controls.Add(chartOutcomes);
            Controls.Add(chartWins);
            Controls.Add(labelComputerPlay);
            Controls.Add(labelLocalPlay);
            Name = "AccountStatistics";
            Text = "AccountStatistics";
            Load += AccountStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)chartWins).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOutcomes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartComputerWins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelLocalPlay;
        public Label labelComputerPlay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWins;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutcomes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComputerWins;
    }
}