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
    public partial class frmXuLySuCo : Form
    {
        public frmXuLySuCo()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        public static string BienSoXeHu;
        QLTXDBContext context = new QLTXDBContext();
        private void frmXuLySuCo_Load(object sender, EventArgs e)
        {
            List<ChiTietHopDong> dsct = context.ChiTietHopDong.ToList();
            fillDgvSuCo(dsct);
            fillDgvXeHong(dsctphat);
        }
        private void fillDgvSuCo(List<ChiTietHopDong> listCTHD)
        {
            dgvXe.Rows.Clear();
            foreach (var item in listCTHD)
            {
                if (item.MaHD_FK.MaHD == frmHopDong.MaXemCT && item.isDeleted == false)
                {

                    int index = dgvXe.Rows.Add();

                    dgvXe.Rows[index].Cells[0].Value = item.BienSo;
                    dgvXe.Rows[index].Cells[1].Value = item.BienSo_FK.TenXe;
                    dgvXe.Rows[index].Cells[2].Value = item.MaKH_FK.TenKH;
                    dgvXe.Rows[index].Cells[3].Value = item.MaNV_FK.TenNV;
                    dgvXe.Rows[index].Cells[4].Value = item.MaKH_FK.MaKH;
                    dgvXe.Rows[index].Cells[5].Value = item.MaNV_FK.MaNV;

                }
            }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvXe.CurrentCell.RowIndex;
            if (dgvXe.CurrentCell == null || dgvXe.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            var dongChon = dgvXe.Rows[index];
            if (index >= 0)
            {
                string bienso = dongChon.Cells[0].Value.ToString();
                string tenxe = dongChon.Cells[1].Value.ToString();
                string tenkh = dongChon.Cells[2].Value.ToString();
                string tennv = dongChon.Cells[3].Value.ToString();
                string makh = dongChon.Cells[4].Value.ToString();
                string manv = dongChon.Cells[5].Value.ToString();
                txtBienSo.Text = bienso;
                txtTenXe.Text = tenxe;
                txtTenKH.Text = tenkh;
                txtTenNV.Text = tennv;
                txtMaKH.Text = makh;
                txtMaNV.Text = manv;
            }
        }
        List<ChiTietPhieuPhat> dsctphat = new List<ChiTietPhieuPhat>();
        
        private void fillDgvXeHong(List<ChiTietPhieuPhat> lisCTPhieuPhat)
        {
            int index = dgvXeHong.Rows.Add();
            txtSl.Text =dsctphat.Count.ToString();
            foreach (var item in dsctphat)
            {
                dgvXeHong.Rows[index].Cells[0].Value = item.BienSo;
                dgvXeHong.Rows[index].Cells[1].Value = item.BienSo_FK.TenXe;
                dgvXeHong.Rows[index].Cells[2].Value = item.MaKH_FK.TenKH;
                dgvXeHong.Rows[index].Cells[3].Value = item.MaNV_FK.TenNV;
                dgvXeHong.Rows[index].Cells[4].Value = item.TienPhat;
                dgvXeHong.Rows[index].Cells[5].Value = item.NoiDungCT;
                
            }
        }

        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            ChiTietPhieuPhat ctpp = new ChiTietPhieuPhat();


            if (txtTienPhat.Text == "" || rtbNDPhat.Text == ""||txtMaKH.Text==""||txtTenKH.Text==""||txtBienSo.Text==""||txtTenXe.Text==""||txtTenNV.Text==""||txtMaNV.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                ctpp.BienSo = txtBienSo.Text;
                ctpp.BienSo_FK = new Xe();
                ctpp.BienSo_FK.TenXe = txtTenXe.Text;
                ctpp.MaKH_FK = new KhachHang();
                ctpp.MaKH = txtMaKH.Text;
                ctpp.MaKH_FK.TenKH = txtTenKH.Text;
                ctpp.MaNV_FK = new NhanVien();
                ctpp.MaNV_FK.TenNV = txtTenNV.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(txtTienPhat.Text, "[^0-9]"))
                {
                    MessageBox.Show("Vui lòng nhập số cho Tiền phạt");
                }
                else
                {
                    ctpp.TienPhat = long.Parse(txtTienPhat.Text);
                    ctpp.NoiDungCT = rtbNDPhat.Text;
                    if (!dsctphat.Any(xe => xe.BienSo == ctpp.BienSo)) // KT xe đã chọn chưa
                    {
                        dsctphat.Add(ctpp);

                        fillDgvXeHong(dsctphat);
                    }
                    else
                    {
                        MessageBox.Show("Xe đã chọn");
                    }
                    txtBienSo.Text = "";
                    txtMaKH.Text = "";
                    txtMaNV.Text = "";
                    txtTenKH.Text = "";
                    txtTenNV.Text = "";
                    txtTenXe.Text = "";
                    txtTienPhat.Text = "";
                    rtbNDPhat.Text = "";
                }
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dsctphat.Count == 0)
            {
                MessageBox.Show("Không có xe cần xử lý");
            }
            else{
                List<PhieuPhat> dsphat = new List<PhieuPhat>();
                PhieuPhat pp = new PhieuPhat();
                List<XeHong> dsxehong = new List<XeHong>();

                foreach (var item in dsctphat)
                {
                    pp.MaKH = txtMaKH.Text;
                    pp.MaKH_FK = new KhachHang();
                    pp.MaKH_FK = context.KhachHang.FirstOrDefault(s => s.MaKH == item.MaKH);
                    ChiTietPhieuPhat ctpp = new ChiTietPhieuPhat();
                    ctpp.MaPhieu_FK = new PhieuPhat();
                    ctpp.MaPhieu_FK = context.PhieuPhat.FirstOrDefault(s => s.MaPhieu == item.MaPhieu);
                    ctpp.MaKH_FK = new KhachHang();
                    ctpp.MaKH_FK = context.KhachHang.FirstOrDefault(s => s.MaKH == item.MaKH);
                    ctpp.BienSo_FK = new Xe();
                    ctpp.BienSo_FK = context.Xe.FirstOrDefault(s => s.BienSo == item.BienSo);
                    ctpp.MaNV = frmDangNhap.manv;
                    ctpp.NoiDungCT = item.NoiDungCT;
                    ctpp.TienPhat = item.TienPhat;
                    ctpp.TongTienPhat = item.TongTienPhat;
                    XeHong xh = new XeHong();
                    xh.BienXeHong = item.BienSo;
                    xh.TenXeHong = item.BienSo_FK.TenXe;
                    xh.LyDoHong = item.NoiDungCT;
                    xh.NgaySua = DateTime.Now;
                    xh.isDeleted = true;
                    dsxehong.Add(xh);
                    context.XeHong.Add(xh);
                    context.ChiTietPhieuPhat.Add(ctpp);
                }
                dsphat.Add(pp);
                context.PhieuPhat.Add(pp);
                context.SaveChanges();
                dgvXeHong.Rows.Clear();
                dgvXe.Rows.Clear();
                MessageBox.Show("Thêm thành công, Mời bạn thanh toán hóa đơn phạt");
                frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                menuForm.XemPhieuPhat();
            }
        }
    }
}
