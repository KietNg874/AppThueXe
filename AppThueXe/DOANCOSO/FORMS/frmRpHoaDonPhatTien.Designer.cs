
namespace DOANCOSO.FORMS
{
    partial class frmRpHoaDonPhatTien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpHoaDonPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonPhatReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonPhatReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpHoaDonPT
            // 
            this.rpHoaDonPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonPhatReportBindingSource;
            this.rpHoaDonPT.LocalReport.DataSources.Add(reportDataSource1);
            this.rpHoaDonPT.LocalReport.ReportEmbeddedResource = "DOANCOSO.rptHoaDonPhatTien.rdlc";
            this.rpHoaDonPT.Location = new System.Drawing.Point(11, 11);
            this.rpHoaDonPT.Margin = new System.Windows.Forms.Padding(2);
            this.rpHoaDonPT.Name = "rpHoaDonPT";
            this.rpHoaDonPT.ServerReport.BearerToken = null;
            this.rpHoaDonPT.Size = new System.Drawing.Size(804, 510);
            this.rpHoaDonPT.TabIndex = 4;
            // 
            // HoaDonPhatReportBindingSource
            // 
            this.HoaDonPhatReportBindingSource.DataSource = typeof(DOANCOSO.Entities.HoaDonPhatReport);
            // 
            // frmRpHoaDonPhatTien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 532);
            this.Controls.Add(this.rpHoaDonPT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRpHoaDonPhatTien";
            this.Text = "frmRpHoaDonPhatTien";
            this.Load += new System.EventHandler(this.frmRpHoaDonPhatTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonPhatReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpHoaDonPT;
        private System.Windows.Forms.BindingSource HoaDonPhatReportBindingSource;
    }
}