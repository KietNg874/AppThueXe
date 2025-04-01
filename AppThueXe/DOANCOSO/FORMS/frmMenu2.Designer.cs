
namespace DOANCOSO.FORMS
{
    partial class frmMenu2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choThuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeHongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choThuêXeToolStripMenuItem,
            this.xemHợpĐồngToolStripMenuItem,
            this.xemKháchHàngToolStripMenuItem,
            this.xeHongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choThuêXeToolStripMenuItem
            // 
            this.choThuêXeToolStripMenuItem.Name = "choThuêXeToolStripMenuItem";
            this.choThuêXeToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.choThuêXeToolStripMenuItem.Text = "Cho Thuê Xe";
            // 
            // xemHợpĐồngToolStripMenuItem
            // 
            this.xemHợpĐồngToolStripMenuItem.Name = "xemHợpĐồngToolStripMenuItem";
            this.xemHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.xemHợpĐồngToolStripMenuItem.Text = "Xem hợp đồng";
            this.xemHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.xemHợpĐồngToolStripMenuItem_Click);
            // 
            // xemKháchHàngToolStripMenuItem
            // 
            this.xemKháchHàngToolStripMenuItem.Name = "xemKháchHàngToolStripMenuItem";
            this.xemKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.xemKháchHàngToolStripMenuItem.Text = "Thêm Khách Hàng";
            this.xemKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.xemKháchHàngToolStripMenuItem_Click);
            // 
            // xeHongToolStripMenuItem
            // 
            this.xeHongToolStripMenuItem.Name = "xeHongToolStripMenuItem";
            this.xeHongToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.xeHongToolStripMenuItem.Text = "Xe hong";
            this.xeHongToolStripMenuItem.Click += new System.EventHandler(this.xeHongToolStripMenuItem_Click);
            // 
            // frmMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu2";
            this.Text = "frmMenu2";
            this.Load += new System.EventHandler(this.frmMenu2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choThuêXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeHongToolStripMenuItem;
    }
}