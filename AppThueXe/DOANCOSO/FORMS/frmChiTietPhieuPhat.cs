using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
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
    public partial class frmChiTietPhieuPhat : Form
    {
        public frmChiTietPhieuPhat()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
       
        private void frmChiTietPhieuPhat_Load(object sender, EventArgs e)
        {
            label1.Text = frmPhieuPhat.xemct;
            List<ChiTietPhieuPhat> lissCTPP = context.ChiTietPhieuPhat.Where(s=>s.isDeleted==false).ToList();
            fillDgvCTPP(lissCTPP);

        }
        private void fillDgvCTPP(List<ChiTietPhieuPhat> ListCT) 
        {
            dgvCTPhieuPhat.Rows.Clear();
            decimal Tong = 0;
            foreach (var item in ListCT)
            {


                if (item.MaPhieu_FK.MaPhieu == int.Parse(frmPhieuPhat.xemct) && item.isDeleted == false)
                {
                
                    int index = dgvCTPhieuPhat.Rows.Add();
                    dgvCTPhieuPhat.Rows[index].Cells[0].Value = item.MaKH;
                    dgvCTPhieuPhat.Rows[index].Cells[1].Value = item.MaKH_FK.TenKH;
                    dgvCTPhieuPhat.Rows[index].Cells[2].Value = item.MaNV;
                    dgvCTPhieuPhat.Rows[index].Cells[3].Value = item.BienSo;
                    dgvCTPhieuPhat.Rows[index].Cells[4].Value = item.BienSo_FK.TenXe;
                    dgvCTPhieuPhat.Rows[index].Cells[5].Value = item.TienPhat;
                    dgvCTPhieuPhat.Rows[index].Cells[6].Value = item.NoiDungCT;
                    Tong += item.TienPhat;
                    item.TongTienPhat = Tong;
                    txtTongTienPhat.Text = Tong.ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dgvCTPhieuPhat.Rows.Clear();
            List<ChiTietPhieuPhat> dsct = context.ChiTietPhieuPhat.ToList();
            HoaDonPhat hdp = new HoaDonPhat();
            foreach (var item in dsct)
            {

                if (item.MaPhieu_FK.MaPhieu == int.Parse(frmPhieuPhat.xemct) && item.isDeleted == false)
                {
                    item.MaPhieu_FK.isDeleted = true;
                    item.BienSo_FK.TrangThai = true;
                    item.isDeleted = true;
                    // thêm hóa đơn////////////////////////////
                    hdp.MaKH_FK = new KhachHang();
                    hdp.MaKH_FK = context.KhachHang.FirstOrDefault(a => a.MaKH == item.MaKH);

                    hdp.nvThanhToan = frmDangNhap.nvname;
                    hdp.NgayLapPhieu = DateTime.Now;
                    //
                    hdp.TongTienPhat = 0;

                    //
                    // add chi tiết hóa đơn
                    ChiTietHoaDonPhat ctHoaDonp = new ChiTietHoaDonPhat();
                    // khởi tạo đối tượng hóa đơn trong cthd;
                    ctHoaDonp.MaHoaDonPhat_FK = new HoaDonPhat();

                    ctHoaDonp.MaHoaDonPhat_FK = context.HoaDonPhat.FirstOrDefault(s => s.MaHoaDonPhat == hdp.MaHoaDonPhat);
                    ctHoaDonp.BienSo_FK = new Xe();
                    ctHoaDonp.BienSo_FK = context.Xe.FirstOrDefault(x => x.BienSo == item.BienSo);

                    ctHoaDonp.TienChiTiet = item.TienPhat;
                    ctHoaDonp.MaCTPP_FK = new ChiTietPhieuPhat();
                    ctHoaDonp.MaCTPP_FK = context.ChiTietPhieuPhat.FirstOrDefault(s => s.MaCTPP == item.MaCTPP);
                    hdp.TongTienPhat += ctHoaDonp.TienChiTiet;

                    context.ChiTietHoaDonPhat.Add(ctHoaDonp);
                }
            }
            context.HoaDonPhat.Add(hdp);
            context.SaveChanges();
            frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
            menuForm.XemCTRPPPForm();

        }

    }
}
