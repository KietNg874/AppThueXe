using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCOSO.FORMS
{
    public partial class frmMeNu3 : Form
    {
        public static string nvname = "";
        public static string nvrole = "";
        public frmMeNu3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void frmMeNu3_Load(object sender, EventArgs e)
        {
            label1.Text = frmDangNhap.nvname;
            if (frmDangNhap.nvrole == "1")
            {
                label2.Text = "Admin";
                btnQuanLy.Visible = true;
            }
            else
            {
                label2.Text = "Nhân viên";
                btnQuanLy.Visible = false;
            }
            btnNhanVien.Visible = false;
            btnKhachHang.Visible = false;
            btnXe.Visible = false;
            btnHDPP.Visible = false;
            LoadForm(new frmHopDong());
            LoadForm(new frmChonXe());
            LoadForm(new frmNhanVien());
            guna2Panel2.Controls.Clear();
            LoadForm(new frmWelcome());
            lbtenfrm.Text = "";


        }
        private void LoadForm(Form form)
        {
            guna2Panel2.Controls.Clear();
            form.TopLevel = false;
            guna2Panel2.Controls.Add(form);
            form.Show();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btn_DangKy_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

        }


        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadForm(new frmNhanVien());
            lbtenfrm.Text = "Nhân viên";
        }

        private void btnThueXe_Click(object sender, EventArgs e)
        {
            LoadForm(new frmChonXe());
            lbtenfrm.Text = "Cho thuê xe";
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHoaDon());
            lbtenfrm.Text = "Hóa đơn";

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new frmThemKhachHang());
            lbtenfrm.Text = "Khách hàng";
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            LoadForm(new frmXe());
            lbtenfrm.Text = "Quản lý xe";
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHopDong());
            lbtenfrm.Text = "Hợp đồng";
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            {
                if (btnNhanVien.Visible == false)
                {
                    btnNhanVien.Visible = true;
                    btnKhachHang.Visible = true;
                    btnXe.Visible = true; 
                    btnHDPP.Visible = true;
                }
                else if (btnNhanVien.Visible == true)
                {
                    btnNhanVien.Visible = false;
                    btnKhachHang.Visible = false;
                    btnXe.Visible = false;
                    btnHDPP.Visible = false;
                }
            } 
        }

        private void btnXemXeHong_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPhieuPhat());
            lbtenfrm.Text = "Xe hỏng";
        }

        private void btnXeDangSua_Click(object sender, EventArgs e)
        {
            LoadForm(new frmXeDangSua());
            lbtenfrm.Text = "Xe đang sửa";
        }

        private void btnThongKeDT_Click(object sender, EventArgs e)
        {
            LoadForm(new frmThongKeDoanhThu());
            lbtenfrm.Text = "Thống kê";
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        public void OpenHopDongForm()
        {
            btnHopDong_Click(this, EventArgs.Empty);
        }

        public void OpenChonXeForm()
        {
            btnThueXe_Click(this, EventArgs.Empty);
        }

        public void XemHDForm()
        {
            LoadForm(new frmChiTietHoaDon());
            lbtenfrm.Text = "Chi tiết hóa đơn";
        }
   
        public void XemRPHDForm()
        {
            LoadForm(new frmRpHoaDon());
            lbtenfrm.Text = "Report Hóa đơn";
        }

        public void XemPhieuPhat()
        {
            LoadForm(new frmPhieuPhat());
            lbtenfrm.Text = "Phiếu Phạt";
        }
        public void XemCTHDForm()
        {
            LoadForm(new frmChiTietHopDong());
            lbtenfrm.Text = "Chi tiết Hợp đồng";
        }
        public void XemXeHongForm()
        {
            LoadForm(new frmXuLySuCo());
            lbtenfrm.Text = "Xử lý sự cố";
        }
        public void XemCTPPForm()
        {
            LoadForm(new frmChiTietPhieuPhat());
            lbtenfrm.Text = "Chi tiết phiếu phạt";
        }
        public void XemCTRPPPForm()
        {
            LoadForm(new frmRpHoaDonPhatTien());
            lbtenfrm.Text = "Report Hóa đơn phạt tiền";
        }
        public void XemCTHDPP_Form()
        {
            LoadForm(new frmChiTietHoaDonPhat());
            lbtenfrm.Text = "Chi tiết hóa đơn phạt tiền";
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHDPP_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHoaDonPhieuPhat());
            lbtenfrm.Text = "Hóa đơn phạt tiền";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDenHangThanhToan());
            lbtenfrm.Text = "Hợp đồng đến hạng";
        }

        private void btnXeHongTrongThang_Click(object sender, EventArgs e)
        {
            LoadForm(new frmXeHongTrongThang());
            lbtenfrm.Text = "Xe hỏng trong tháng";
        }

        private void lbtenfrm_Click(object sender, EventArgs e)
        {

        }
    }
}
