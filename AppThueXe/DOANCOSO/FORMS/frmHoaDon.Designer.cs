
namespace DOANCOSO.FORMS
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txtXemCTHD = new System.Windows.Forms.TextBox();
            this.txtTongTienTatCaHd = new System.Windows.Forms.TextBox();
            this.btnXemCTHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(184)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHoaDon.ColumnHeadersHeight = 21;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Column2,
            this.MaNV,
            this.Column1,
            this.TongTien});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(184)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 45);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(743, 291);
            this.dgvHoaDon.TabIndex = 34;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV Thanh Toán";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày In HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiGian.Location = new System.Drawing.Point(491, 11);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(254, 22);
            this.dtpThoiGian.TabIndex = 101;
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpTimTg_ValueChanged);
            // 
            // txtXemCTHD
            // 
            this.txtXemCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtXemCTHD.Location = new System.Drawing.Point(112, 11);
            this.txtXemCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtXemCTHD.Name = "txtXemCTHD";
            this.txtXemCTHD.Size = new System.Drawing.Size(44, 22);
            this.txtXemCTHD.TabIndex = 102;
            this.txtXemCTHD.Visible = false;
            // 
            // txtTongTienTatCaHd
            // 
            this.txtTongTienTatCaHd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTienTatCaHd.Location = new System.Drawing.Point(645, 340);
            this.txtTongTienTatCaHd.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTienTatCaHd.Name = "txtTongTienTatCaHd";
            this.txtTongTienTatCaHd.Size = new System.Drawing.Size(107, 22);
            this.txtTongTienTatCaHd.TabIndex = 105;
            // 
            // btnXemCTHoaDon
            // 
            this.btnXemCTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemCTHoaDon.AutoRoundedCorners = true;
            this.btnXemCTHoaDon.BorderRadius = 17;
            this.btnXemCTHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemCTHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemCTHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnXemCTHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemCTHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXemCTHoaDon.Location = new System.Drawing.Point(9, 410);
            this.btnXemCTHoaDon.Name = "btnXemCTHoaDon";
            this.btnXemCTHoaDon.Size = new System.Drawing.Size(144, 37);
            this.btnXemCTHoaDon.TabIndex = 108;
            this.btnXemCTHoaDon.Text = "Xem hóa đơn";
            this.btnXemCTHoaDon.Click += new System.EventHandler(this.btnXemCTHoaDon_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatBaoCao.AutoRoundedCorners = true;
            this.btnXuatBaoCao.BorderRadius = 24;
            this.btnXuatBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatBaoCao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(509, 396);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(109, 51);
            this.btnXuatBaoCao.TabIndex = 109;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnReset.BorderRadius = 24;
            this.btnReset.BorderThickness = 2;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(643, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 51);
            this.btnReset.TabIndex = 110;
            this.btnReset.Text = "Ngày hiện tại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 111;
            this.label1.Text = "Doanh thu";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(160, 410);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(194, 37);
            this.guna2Button1.TabIndex = 112;
            this.guna2Button1.Text = "Hóa đơn trong tháng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnXemCTHoaDon);
            this.Controls.Add(this.txtTongTienTatCaHd);
            this.Controls.Add(this.txtXemCTHD);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.TextBox txtXemCTHD;
        private System.Windows.Forms.TextBox txtTongTienTatCaHd;
        private Guna.UI2.WinForms.Guna2Button btnXemCTHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnXuatBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}