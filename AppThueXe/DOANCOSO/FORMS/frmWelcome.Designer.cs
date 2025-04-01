
namespace DOANCOSO.FORMS
{
    partial class frmWelcome
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
            this.lb1 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Navy;
            this.lb1.Location = new System.Drawing.Point(173, 66);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(977, 55);
            this.lb1.TabIndex = 16;
            this.lb1.Text = "Hệ thống quản lý cho thuê xe 2 bánh và 4 bánh\r\n";
            // 
            // pb2
            // 
            this.pb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb2.Image = global::DOANCOSO.Properties.Resources.xinchao;
            this.pb2.Location = new System.Drawing.Point(-53, 239);
            this.pb2.Margin = new System.Windows.Forms.Padding(4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(1540, 597);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 18;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb1.Image = global::DOANCOSO.Properties.Resources.hutechlogo;
            this.pb1.Location = new System.Drawing.Point(1196, -21);
            this.pb1.Margin = new System.Windows.Forms.Padding(4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(291, 191);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 17;
            this.pb1.TabStop = false;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 794);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmWelcome";
            this.Text = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lb1;
    }
}