using DOANCOSO.DATABASE;
using DoAnCoSoQLTX.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCOSO.FORMS
{
    public partial class frmDenHangThanhToan : Form
    {
        public static int MaXemCT;
        public frmDenHangThanhToan()
        {
        
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext ql = new QLTXDBContext();
        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Hợp đồng");
            }
            else
            {
                frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                menuForm.XemCTHDForm();
            }
        }

        private void frmDenHangThanhToan_Load(object sender, EventArgs e)
        {
            List<HopDong> dshd = ql.HopDong
                      .Where(s => s.isDeleted == false && DbFunctions.DiffDays(s.NgayLapHopDong, DateTime.Now) >29)
                      .ToList();

            // Hiển thị các hợp đồng đã lọc
            fillDGVHopDong(dshd);

        }
        public void fillDGVHopDong(List<HopDong> listHopDong)
        {
            dgvHopDong.Rows.Clear();
            foreach (var item in listHopDong)
            {
                int index = dgvHopDong.Rows.Add();
                dgvHopDong.Rows[index].Cells[0].Value = item.MaHD;
                dgvHopDong.Rows[index].Cells[1].Value = item.NoiDung;
                dgvHopDong.Rows[index].Cells[2].Value = item.SdtKH;
                dgvHopDong.Rows[index].Cells[3].Value = item.NgayLapHopDong;
            }

        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvHopDong.CurrentCell.RowIndex;
            if (dgvHopDong.CurrentCell == null || dgvHopDong.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            if (index >= 0)
            {
                var dongChon = dgvHopDong.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string mahd = dongChon.Cells[0].Value.ToString();
                string ngaylap = dongChon.Cells[1].Value.ToString();
                txtMaHD.Text = mahd;
                MaXemCT = int.Parse(mahd);
            }
        }
    }
}
