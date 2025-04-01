
namespace DOANCOSO.FORMS
{
    partial class frmRpHoaDon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpTG = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANCOSO.rptHoaDonPhatTien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 11);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 518);
            this.reportViewer1.TabIndex = 3;
            // 
            // dtpTG
            // 
            this.dtpTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTG.Location = new System.Drawing.Point(623, 34);
            this.dtpTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTG.Name = "dtpTG";
            this.dtpTG.Size = new System.Drawing.Size(151, 20);
            this.dtpTG.TabIndex = 4;
            // 
            // frmRpHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 540);
            this.Controls.Add(this.dtpTG);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRpHoaDon";
            this.Text = "frmRpHoaDon";
            this.Load += new System.EventHandler(this.frmRpHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpTG;
    }
}