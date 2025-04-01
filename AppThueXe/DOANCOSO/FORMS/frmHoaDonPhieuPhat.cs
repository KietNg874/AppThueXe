using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCOSO.FORMS
{
    public partial class frmHoaDonPhieuPhat : Form
    {
        public frmHoaDonPhieuPhat()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        public static int MaXemHoaDonPhat;

        private void frmHoaDonPhieuPhat_Load(object sender, EventArgs e)
        {
            List<HoaDonPhat> dsHoaDon = context.HoaDonPhat.Where(s => s.isDeleted == false).ToList();

            fillDgvHoaDon(dsHoaDon);
        }
        private void fillDgvHoaDon(List<HoaDonPhat> ListHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            decimal tongtien = 0;
            foreach (var item in ListHoaDon)
            {
                if (item.NgayLapPhieu.Date == dtpThoiGian.Value.Date)
                {
                    int index = dgvHoaDon.Rows.Add();
                    dgvHoaDon.Rows[index].Cells[0].Value = item.MaHoaDonPhat;
                    dgvHoaDon.Rows[index].Cells[1].Value = item.MaKH_FK.MaKH;
                    dgvHoaDon.Rows[index].Cells[2].Value = item.nvThanhToan;
                    dgvHoaDon.Rows[index].Cells[3].Value = item.NgayLapPhieu;
                    dgvHoaDon.Rows[index].Cells[4].Value = item.TongTienPhat;
                    tongtien += item.TongTienPhat;
                }
                txtTongTienTatCaHd.Text = tongtien.ToString();

            }
        }

        private void btnXemCTHoaDonP_Click(object sender, EventArgs e)
        {
            if (txtXemCTHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn xem");
            }
            else
            {
                frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                menuForm.XemCTHDPP_Form();
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvHoaDon.CurrentCell.RowIndex;
            if (dgvHoaDon.CurrentCell == null || dgvHoaDon.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            if (index >= 0)
            {
                var dongChon = dgvHoaDon.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string mahd = dongChon.Cells[0].Value.ToString();
                txtXemCTHD.Text = mahd;
                MaXemHoaDonPhat = int.Parse(mahd);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpThoiGian.Value = DateTime.Now;
            List<HoaDonPhat> dsHoaDon = context.HoaDonPhat.Where(s => s.isDeleted == false).ToList();
            fillDgvHoaDon(dsHoaDon);
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            DateTime NgayCanTim = dtpThoiGian.Value.Date;
            List<HoaDonPhat> dsHoaDon = context.HoaDonPhat.Where(s => s.isDeleted == false).ToList();
            var hoadontrongngay = dsHoaDon.Where(hd => hd.NgayLapPhieu.Date == NgayCanTim).ToList();
            decimal tongtien = 0;
            foreach (var item in hoadontrongngay)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MaHoaDonPhat;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MaKH_FK.MaKH;
                dgvHoaDon.Rows[index].Cells[2].Value = item.nvThanhToan;
                dgvHoaDon.Rows[index].Cells[3].Value = item.NgayLapPhieu;
                dgvHoaDon.Rows[index].Cells[4].Value = item.TongTienPhat;
                tongtien += item.TongTienPhat;

            }
            txtTongTienTatCaHd.Text = tongtien.ToString();
        }
    }
}
