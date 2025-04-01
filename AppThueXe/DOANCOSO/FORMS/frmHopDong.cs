using ComponentFactory.Krypton.Toolkit;
using DOANCOSO.DATABASE;
using DoAnCoSoQLTX.Entities;
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
    public partial class frmHopDong : KryptonForm
    {
        public static int MaXemCT;
        public frmHopDong()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.5, (float)1.5));
        }
        QLTXDBContext ql = new QLTXDBContext();
        private void frmHopDong_Load(object sender, EventArgs e)
        {

            List<HopDong> dshd = ql.HopDong.Where(s => s.isDeleted == false).ToList();
          
            List<ChiTietHopDong> cthd = ql.ChiTietHopDong.Where(s => s.isDeleted == false).ToList();
            if (sw_HienHopDong.Checked == true)
            {
                // hien hop dong dang thue
                fillDGVHopDong(dshd);
            }
            if (frmDangNhap.nvrole == "1")
            {
                btnXoaHopDong.Visible = true;
            }
            else
            {
                btnXoaHopDong.Visible = false;
            }
        
        }
        public void fillDGVHopDong(List<HopDong> listHopDong)
        {
            dgvHopDong.Rows.Clear();
            foreach (var item in listHopDong)
            {
                int index = dgvHopDong.Rows.Add();
                dgvHopDong.Rows[index].Cells[0].Value = item.MaHD;
                dgvHopDong.Rows[index].Cells[1].Value = item.NoiDung;
                dgvHopDong.Rows[index].Cells[2].Value = item.NgayLapHopDong;
                dgvHopDong.Rows[index].Cells[3].Value = item.TrangThaiBanDau;
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

        private void txtTimHD_TextChanged(object sender, EventArgs e)
        {
            string matim = txtTimHD.Text;
            List<HopDong> listHD = ql.HopDong.Where(s => s.isDeleted == false).ToList();
            var listTim = listHD.Where(s => s.MaHD.ToString().StartsWith(matim)).ToList();
            fillDGVHopDong(listTim);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void sw_HienHopDong_CheckedChanged(object sender, EventArgs e)
        {

            List<HopDong> dshd = ql.HopDong.Where(s => s.isDeleted == false).ToList();
            List<HopDong> dsdt = ql.HopDong.Where(s => s.isDeleted == true).ToList();

            if (sw_HienHopDong.Checked == true)
            {
                // hien hop dong dang thue
                fillDGVHopDong(dshd);
                
            }
            else if (sw_HienHopDong.Checked == false)
            {
                // hien hop dong da thue r
                fillDGVHopDong(dsdt);
                // khi hopwj dodngf thuee xong thif k dc thi an nut xoa hop dong
                btnXoaHopDong.Visible = true;
            }
         

        }

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

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaHopDong_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("vui lòng chọn hợp đồng");
            }
            int mahd = int.Parse(txtMaHD.Text);
     

            HopDong xoahopdong = ql.HopDong.FirstOrDefault(s => s.MaHD == mahd);
            List<HopDong> dshd = ql.HopDong.Where(s => s.isDeleted == false).ToList();
            List<ChiTietHopDong> dscthopdong = ql.ChiTietHopDong.Where(s => s.MaHD_FK.MaHD == mahd).ToList();
            if (xoahopdong != null)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa hợp đồng?", "Thông tin từ hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach(var item in dscthopdong)
                    {
                        item.BienSo_FK.TrangThai = false;
                    }
                    ql.HopDong.Remove(xoahopdong);
                    ql.SaveChanges();
                    MessageBox.Show("Xóa hợp đồng thành công");
                    
                    fillDGVHopDong(dshd);
                }
            }else if (xoahopdong == null)
            {
                MessageBox.Show("Không tìm thấy hợp đồng cần xóa");
            }
           
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            dgvHopDong.Rows.Clear();
            DateTime NgayCanTim = dtpThoiGian.Value.Date;
            List<HopDong> dsHoaDon = ql.HopDong.Where(s => s.isDeleted == false).ToList();
            var hopdontrongngay = dsHoaDon.Where(hd => hd.NgayLapHopDong.Date == NgayCanTim).ToList();
           
            foreach (var item in hopdontrongngay)
            {
                int index = dgvHopDong.Rows.Add();
                dgvHopDong.Rows[index].Cells[0].Value = item.MaHD;
                dgvHopDong.Rows[index].Cells[1].Value = item.NoiDung;
                dgvHopDong.Rows[index].Cells[2].Value = item.NgayLapHopDong;
                dgvHopDong.Rows[index].Cells[3].Value = item.TrangThaiBanDau;

            }
          
        }
    }
}
