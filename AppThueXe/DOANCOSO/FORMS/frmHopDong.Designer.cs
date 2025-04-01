
namespace DOANCOSO.FORMS
{
    partial class frmHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txtTimHD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sw_HienHopDong = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnXemCTHD = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaHopDong = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 30);
            this.label11.TabIndex = 84;
            this.label11.Text = "Thanh Toán Hợp Đồng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(174)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHopDong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHopDong.ColumnHeadersHeight = 21;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(174)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHopDong.EnableHeadersVisualStyles = false;
            this.dgvHopDong.Location = new System.Drawing.Point(318, 42);
            this.dgvHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHopDong.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(369, 236);
            this.dgvHopDong.TabIndex = 87;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(167, 65);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(135, 29);
            this.txtMaHD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaHD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMaHD.StateCommon.Border.Rounding = 2;
            this.txtMaHD.TabIndex = 96;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 92;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGian.Location = new System.Drawing.Point(438, 15);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(196, 22);
            this.dtpThoiGian.TabIndex = 101;
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // txtTimHD
            // 
            this.txtTimHD.Location = new System.Drawing.Point(167, 116);
            this.txtTimHD.Name = "txtTimHD";
            this.txtTimHD.Size = new System.Drawing.Size(135, 29);
            this.txtTimHD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimHD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTimHD.StateCommon.Border.Rounding = 2;
            this.txtTimHD.TabIndex = 106;
            this.txtTimHD.TextChanged += new System.EventHandler(this.txtTimHD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 105;
            this.label2.Text = "Tìm Mã Hợp Đồng";
            // 
            // sw_HienHopDong
            // 
            this.sw_HienHopDong.Checked = true;
            this.sw_HienHopDong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sw_HienHopDong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sw_HienHopDong.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.sw_HienHopDong.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sw_HienHopDong.Location = new System.Drawing.Point(167, 161);
            this.sw_HienHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.sw_HienHopDong.Name = "sw_HienHopDong";
            this.sw_HienHopDong.Size = new System.Drawing.Size(54, 27);
            this.sw_HienHopDong.TabIndex = 108;
            this.sw_HienHopDong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sw_HienHopDong.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sw_HienHopDong.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.sw_HienHopDong.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.sw_HienHopDong.CheckedChanged += new System.EventHandler(this.sw_HienHopDong_CheckedChanged);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemCTHD.AutoRoundedCorners = true;
            this.btnXemCTHD.BorderRadius = 17;
            this.btnXemCTHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemCTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemCTHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnXemCTHD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHD.ForeColor = System.Drawing.Color.White;
            this.btnXemCTHD.Location = new System.Drawing.Point(578, 333);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(109, 37);
            this.btnXemCTHD.TabIndex = 110;
            this.btnXemCTHD.Text = "Xem";
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 112;
            this.label3.Text = "Xem Hợp Đồng Cũ";
            // 
            // btnXoaHopDong
            // 
            this.btnXoaHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHopDong.AutoRoundedCorners = true;
            this.btnXoaHopDong.BorderRadius = 17;
            this.btnXoaHopDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHopDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHopDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaHopDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHopDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaHopDong.Location = new System.Drawing.Point(412, 333);
            this.btnXoaHopDong.Name = "btnXoaHopDong";
            this.btnXoaHopDong.Size = new System.Drawing.Size(150, 37);
            this.btnXoaHopDong.TabIndex = 114;
            this.btnXoaHopDong.Text = "Xóa Hợp Đồng";
            this.btnXoaHopDong.Click += new System.EventHandler(this.btnXoaHopDong_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hợp Đồng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khách hàng thuê";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Lập Hợp Đồng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình Trạng Xe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmHopDong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 382);
            this.Controls.Add(this.btnXoaHopDong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.sw_HienHopDong);
            this.Controls.Add(this.txtTimHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHopDong";
            this.Text = "Thông tin hợp đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimHD;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch sw_HienHopDong;
        private Guna.UI2.WinForms.Guna2Button btnXemCTHD;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnXoaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}