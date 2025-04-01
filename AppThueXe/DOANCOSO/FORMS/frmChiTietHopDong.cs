using ComponentFactory.Krypton.Toolkit;
using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
using DoAnCoSoQLTX.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCOSO.FORMS
{
    public partial class frmChiTietHopDong : KryptonForm
    {
        public frmChiTietHopDong()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();

        private void frmChiTietHopDong_Load(object sender, EventArgs e)
        {
           
            List<ChiTietHopDong> cthd = context.ChiTietHopDong.Where(s => s.isDeleted == false).ToList();
            
            fillDGVChiTietHD(cthd);
     
        }
        List<ChiTietHopDong> thanhtoanhd = new List<ChiTietHopDong>();
        public void fillDGVChiTietHD(List<ChiTietHopDong> listCTHD)
        {
            dgvHopDong.Rows.Clear();
            
            foreach (var item in listCTHD)
            {


                if (item.MaHD_FK.MaHD == frmHopDong.MaXemCT && item.isDeleted == false)
                {

                    int index = dgvHopDong.Rows.Add();
                  
                    dgvHopDong.Rows[index].Cells[0].Value = item.BienSo;
                    dgvHopDong.Rows[index].Cells[1].Value = item.BienSo_FK.TenXe;
                    dgvHopDong.Rows[index].Cells[2].Value = item.MaKH_FK.MaKH;
                    dgvHopDong.Rows[index].Cells[3].Value = item.MaNV_FK.MaNV;
                    dgvHopDong.Rows[index].Cells[4].Value = item.MaHD_FK.NgayLapHopDong;
                    dgvHopDong.Rows[index].Cells[5].Value = item.TienThue;
                    dgvHopDong.Rows[index].Cells[6].Value = item.MaKH_FK.SDT;
                    dgvHopDong.Rows[index].Cells[7].Value = item.MaKH;
    
                   
                    thanhtoanhd.Add(item);
                }
            }
        }

       
        List<Xe> dsxehong = new List<Xe>();
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
                    string biensoxe = dongChon.Cells[0].Value.ToString();
               
          
                }
  
        }
        

        private void dtpTGKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

   
        List<PhieuPhat> ListPhieuPHat = new List<PhieuPhat>();

        private void dgvXeHong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            foreach (var item in thanhtoanhd)
            {
                // thêm hóa đơn
                hd.MaKH_FK = new KhachHang();
                hd.MaKH_FK = context.KhachHang.FirstOrDefault(a => a.MaKH == item.MaKH);
                
                hd.nvThanhToan = frmDangNhap.nvname;
                hd.NgayThanhToan = DateTime.Now;
                //
                DateTime tgbd = item.MaHD_FK.NgayLapHopDong;
                DateTime tgkt = DateTime.Now;
                TimeSpan thoigianthue = tgkt - tgbd;
                long TienThue = 0;
                long SoNgayThue = (int)Math.Ceiling(thoigianthue.TotalDays);
                TienThue = SoNgayThue * item.BienSo_FK.GiaXe;
                // add chi tiết hóa đơn
                ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                // khởi tạo đối tượng hóa đơn trong cthd;
                ctHoaDon.MaHoaDon_FK = new HoaDon();   
                ctHoaDon.MaHoaDon_FK = context.HoaDon.FirstOrDefault(s => s.MaHoaDon == hd.MaHoaDon);
                ctHoaDon.BienSo_FK = new Xe();
                ctHoaDon.BienSo_FK = context.Xe.FirstOrDefault(x => x.BienSo == item.BienSo); 
                ctHoaDon.TienChiTiet = TienThue;
                ctHoaDon.MaHD_FK = new HopDong();
                ctHoaDon.MaHD_FK = context.HopDong.FirstOrDefault(s => s.MaHD == item.MaHD);
                hd.TongTienHoaDon += ctHoaDon.TienChiTiet;
                // tim xem xe da sua chua 
                List<XeHong> listxedasua = context.XeHong.Where(s=>s.isDeleted==true).ToList();
              //  List<XeHong> listxedasua = context.XeHong.ToList();
                if (listxedasua.Count!=0)
               {
                    foreach (var kt in listxedasua)
                    {
                        // kiem tra xem xe da sua chua neu xe chua duoc sua thi khi thanh toan xe van khong the nao duoc thue
                        if (item.BienSo == kt.BienXeHong && kt.isDeleted == true)
                        {
                            // khong dc thuê
                            item.BienSo_FK.TrangThai = true;
                        }
                        else if (item.BienSo != kt.BienXeHong)
                        {
                            // duoc thue
                            item.BienSo_FK.TrangThai = false;
                        }
                    }
                }
                else
                {
                    // được thuê
                    item.BienSo_FK.TrangThai = false;
                }
               
                    item.MaHD_FK.isDeleted = true;
                context.ChiTietHoaDon.Add(ctHoaDon);


            }
            context.HoaDon.Add(hd);
          
            try
            {
                // Thực hiện lưu vào cơ sở dữ liệu
               
                DialogResult result = MessageBox.Show("Thanh toán thành công", " Xác nhận", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    context.SaveChanges();
                    frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                    menuForm.XemRPHDForm();
                }
                context.SaveChanges();
                dgvHopDong.Rows.Clear();
                this.Close();
            }

            catch (DbEntityValidationException ex)
            {
                // Xử lý các lỗi xác nhận dữ liệu
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var validationError in error.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
            menuForm.XemXeHongForm();
        }

        private void btnGiaHanHopDong_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            foreach (var item in thanhtoanhd)
            {
                // thêm hóa đơn
                hd.MaKH_FK = new KhachHang();
                hd.MaKH_FK = context.KhachHang.FirstOrDefault(a => a.MaKH == item.MaKH);

                hd.nvThanhToan = frmDangNhap.nvname;
                hd.NgayThanhToan = DateTime.Now;
                //
                DateTime tgbd = item.MaHD_FK.NgayLapHopDong;
                DateTime tgkt = DateTime.Now;
                TimeSpan thoigianthue = tgkt - tgbd;
                long TienThue = 0;
                long SoNgayThue = (int)Math.Ceiling(thoigianthue.TotalDays);
                TienThue = SoNgayThue * item.BienSo_FK.GiaXe;
                // add chi tiết hóa đơn
                ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                // khởi tạo đối tượng hóa đơn trong cthd;
                ctHoaDon.MaHoaDon_FK = new HoaDon(); 
                ctHoaDon.MaHoaDon_FK = context.HoaDon.FirstOrDefault(s => s.MaHoaDon == hd.MaHoaDon);
                ctHoaDon.BienSo_FK = new Xe();
                ctHoaDon.BienSo_FK = context.Xe.FirstOrDefault(x => x.BienSo == item.BienSo);
                ctHoaDon.TienChiTiet = TienThue;
                ctHoaDon.MaHD_FK = new HopDong();
                ctHoaDon.MaHD_FK = context.HopDong.FirstOrDefault(s => s.MaHD == item.MaHD);
                hd.TongTienHoaDon += ctHoaDon.TienChiTiet;
                // được thuê
                item.BienSo_FK.TrangThai = true;
                item.MaHD_FK.isDeleted = false;
                context.ChiTietHoaDon.Add(ctHoaDon);
            }
            context.HoaDon.Add(hd);

            try
            {
                // Thực hiện lưu vào cơ sở dữ liệu

                DialogResult result = MessageBox.Show("Thanh toan thanh cong, Ban muon in hoa don khong", " Xac nhan", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    context.SaveChanges();
                    frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                    menuForm.XemRPHDForm();
                }
                context.SaveChanges();
                dgvHopDong.Rows.Clear();
                this.Close();

            }

            catch (DbEntityValidationException ex)
            {
                // Xử lý các lỗi xác nhận dữ liệu
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var validationError in error.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            //List<HopDong> listHopHong = context.HopDong.Where(s => s.isDeleted == false).ToList();
            //List<ChiTietHoaDon> listCTHoaDon = context.ChiTietHoaDon.ToList();
            //foreach(var timcthoadon in listCTHoaDon) // tìm lấy mã hợp đồng trong ct hóa đơn
            //{
            //    foreach(var timhopdong in listHopHong) // tìm lấy mã hợp đồng 
            //    {
            //        if (timhopdong.MaHD ==timcthoadon.MaHD_FK.MaHD)// tìm có cùng mã hợp đòng
            //        {
            //           timhopdong.
            //        }
            //    }
            //}
        }
    }
}