
namespace DOANCOSO.FORMS
{
    partial class frmThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThongKeXe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeXe)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(172, 146);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sửa Chữa";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(331, 296);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Thống Kê Doanh Thu";
            this.chartDoanhThu.Titles.Add(title1);
            this.chartDoanhThu.Click += new System.EventHandler(this.chartDoanhThu_Click);
            // 
            // chartThongKeXe
            // 
            this.chartThongKeXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chartThongKeXe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThongKeXe.Legends.Add(legend2);
            this.chartThongKeXe.Location = new System.Drawing.Point(654, 146);
            this.chartThongKeXe.Margin = new System.Windows.Forms.Padding(2);
            this.chartThongKeXe.Name = "chartThongKeXe";
            this.chartThongKeXe.Size = new System.Drawing.Size(330, 305);
            this.chartThongKeXe.TabIndex = 2;
            this.chartThongKeXe.Text = "Thống Kê Xe";
            title2.Name = "Title1";
            title2.Text = "Thống Kê Thuê Xe";
            this.chartThongKeXe.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartThongKeXe);
            this.Controls.Add(this.chartDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeXe;
        private System.Windows.Forms.Label label1;
    }
}