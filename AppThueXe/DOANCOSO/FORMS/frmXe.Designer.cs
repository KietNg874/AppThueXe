
namespace DOANCOSO.FORMS
{
    partial class frmXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaThue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenXe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtMaXe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbDaThue = new System.Windows.Forms.CheckBox();
            this.cbChuaThue = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picXe = new System.Windows.Forms.PictureBox();
            this.txtLinkAnh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbLoaixe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txtTimXe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaoTri = new Guna.UI2.WinForms.Guna2Button();
            this.cbBaoTri = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaixe)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Link ảnh";
            this.label7.Visible = false;
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXe.ColumnHeadersHeight = 34;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.TenXe,
            this.GiaXe,
            this.LoaiXe,
            this.TTXe,
            this.ImgXe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXe.EnableHeadersVisualStyles = false;
            this.dgvXe.Location = new System.Drawing.Point(391, 11);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(651, 227);
            this.dgvXe.TabIndex = 57;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // BienSo
            // 
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // TenXe
            // 
            this.TenXe.HeaderText = "Tên xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            // 
            // GiaXe
            // 
            this.GiaXe.HeaderText = "Giá xe";
            this.GiaXe.MinimumWidth = 6;
            this.GiaXe.Name = "GiaXe";
            this.GiaXe.ReadOnly = true;
            // 
            // LoaiXe
            // 
            this.LoaiXe.HeaderText = "Loại xe";
            this.LoaiXe.MinimumWidth = 6;
            this.LoaiXe.Name = "LoaiXe";
            this.LoaiXe.ReadOnly = true;
            // 
            // TTXe
            // 
            this.TTXe.HeaderText = "Trạng thái xe";
            this.TTXe.MinimumWidth = 6;
            this.TTXe.Name = "TTXe";
            this.TTXe.ReadOnly = true;
            // 
            // ImgXe
            // 
            this.ImgXe.HeaderText = "Ảnh xe";
            this.ImgXe.MinimumWidth = 6;
            this.ImgXe.Name = "ImgXe";
            this.ImgXe.ReadOnly = true;
            this.ImgXe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Trạng thái xe";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(113, 148);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(219, 25);
            this.txtGiaThue.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGiaThue.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGiaThue.StateCommon.Border.Rounding = 2;
            this.txtGiaThue.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Giá Thuê";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(113, 100);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(219, 25);
            this.txtTenXe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenXe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTenXe.StateCommon.Border.Rounding = 2;
            this.txtTenXe.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Biến số xe";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(113, 12);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(219, 25);
            this.txtMaXe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaXe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMaXe.StateCommon.Border.Rounding = 2;
            this.txtMaXe.TabIndex = 47;
            // 
            // cbDaThue
            // 
            this.cbDaThue.AutoSize = true;
            this.cbDaThue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaThue.Location = new System.Drawing.Point(124, 210);
            this.cbDaThue.Margin = new System.Windows.Forms.Padding(2);
            this.cbDaThue.Name = "cbDaThue";
            this.cbDaThue.Size = new System.Drawing.Size(67, 17);
            this.cbDaThue.TabIndex = 67;
            this.cbDaThue.Text = "Đã thuê";
            this.cbDaThue.UseVisualStyleBackColor = true;
            this.cbDaThue.CheckedChanged += new System.EventHandler(this.cbDaThue_CheckedChanged);
            // 
            // cbChuaThue
            // 
            this.cbChuaThue.AutoSize = true;
            this.cbChuaThue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuaThue.Location = new System.Drawing.Point(197, 210);
            this.cbChuaThue.Margin = new System.Windows.Forms.Padding(2);
            this.cbChuaThue.Name = "cbChuaThue";
            this.cbChuaThue.Size = new System.Drawing.Size(80, 17);
            this.cbChuaThue.TabIndex = 68;
            this.cbChuaThue.Text = "Chưa thuê";
            this.cbChuaThue.UseVisualStyleBackColor = true;
            this.cbChuaThue.CheckedChanged += new System.EventHandler(this.cbChuaThue_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picXe
            // 
            this.picXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picXe.Location = new System.Drawing.Point(391, 242);
            this.picXe.Margin = new System.Windows.Forms.Padding(2);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(651, 309);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXe.TabIndex = 63;
            this.picXe.TabStop = false;
            // 
            // txtLinkAnh
            // 
            this.txtLinkAnh.Location = new System.Drawing.Point(113, 260);
            this.txtLinkAnh.Name = "txtLinkAnh";
            this.txtLinkAnh.Size = new System.Drawing.Size(219, 25);
            this.txtLinkAnh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLinkAnh.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtLinkAnh.StateCommon.Border.Rounding = 2;
            this.txtLinkAnh.TabIndex = 71;
            this.txtLinkAnh.Visible = false;
            // 
            // cbbLoaixe
            // 
            this.cbbLoaixe.DropDownWidth = 218;
            this.cbbLoaixe.Location = new System.Drawing.Point(113, 54);
            this.cbbLoaixe.Name = "cbbLoaixe";
            this.cbbLoaixe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.cbbLoaixe.Size = new System.Drawing.Size(220, 23);
            this.cbbLoaixe.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cbbLoaixe.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbLoaixe.StateCommon.ComboBox.Border.Rounding = 2;
            this.cbbLoaixe.TabIndex = 73;
            // 
            // txtTimXe
            // 
            this.txtTimXe.Location = new System.Drawing.Point(113, 314);
            this.txtTimXe.Name = "txtTimXe";
            this.txtTimXe.Size = new System.Drawing.Size(219, 25);
            this.txtTimXe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimXe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTimXe.StateCommon.Border.Rounding = 2;
            this.txtTimXe.TabIndex = 77;
            this.txtTimXe.TextChanged += new System.EventHandler(this.txtTimXe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(6, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Tìm biển số xe";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.AutoRoundedCorners = true;
            this.btnChonAnh.BorderRadius = 17;
            this.btnChonAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonAnh.FillColor = System.Drawing.Color.Yellow;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonAnh.Location = new System.Drawing.Point(8, 349);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(111, 37);
            this.btnChonAnh.TabIndex = 121;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemXe.AutoRoundedCorners = true;
            this.btnThemXe.BorderRadius = 17;
            this.btnThemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnThemXe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemXe.ForeColor = System.Drawing.Color.White;
            this.btnThemXe.Location = new System.Drawing.Point(10, 514);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(115, 37);
            this.btnThemXe.TabIndex = 122;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 17;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(131, 514);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 37);
            this.btnSua.TabIndex = 123;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 17;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(252, 514);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 37);
            this.btnXoa.TabIndex = 124;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.AutoRoundedCorners = true;
            this.btnBaoTri.BorderRadius = 17;
            this.btnBaoTri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoTri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoTri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoTri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoTri.FillColor = System.Drawing.Color.Yellow;
            this.btnBaoTri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaoTri.ForeColor = System.Drawing.Color.Black;
            this.btnBaoTri.Location = new System.Drawing.Point(131, 349);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(115, 37);
            this.btnBaoTri.TabIndex = 125;
            this.btnBaoTri.Text = "Bảo Trì Xe";
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // cbBaoTri
            // 
            this.cbBaoTri.AutoSize = true;
            this.cbBaoTri.Location = new System.Drawing.Point(296, 212);
            this.cbBaoTri.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaoTri.Name = "cbBaoTri";
            this.cbBaoTri.Size = new System.Drawing.Size(56, 17);
            this.cbBaoTri.TabIndex = 127;
            this.cbBaoTri.Text = "Bảo trì";
            this.cbBaoTri.UseVisualStyleBackColor = true;
            // 
            // frmXe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 573);
            this.Controls.Add(this.cbBaoTri);
            this.Controls.Add(this.btnBaoTri);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemXe);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtTimXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLoaixe);
            this.Controls.Add(this.txtLinkAnh);
            this.Controls.Add(this.cbChuaThue);
            this.Controls.Add(this.cbDaThue);
            this.Controls.Add(this.picXe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaXe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXe";
            this.Text = "frmXe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaixe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.PictureBox picXe;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvXe;
		private System.Windows.Forms.Label label6;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGiaThue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenXe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaXe;
		private System.Windows.Forms.CheckBox cbDaThue;
		private System.Windows.Forms.CheckBox cbChuaThue;
		private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLinkAnh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbLoaixe;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImgXe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimXe;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private Guna.UI2.WinForms.Guna2Button btnThemXe;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnBaoTri;
        private System.Windows.Forms.CheckBox cbBaoTri;
    }
}