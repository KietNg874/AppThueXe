using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DOANCOSO.DATABASE;
using DOANCOSO.Entities;

namespace DOANCOSO.FORMS
{
    public partial class frmDangNhap : KryptonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Scale(new SizeF((float)1.5, (float)1.5));
        }
        static public string nvname;
        static public string nvrole;
        static public int manv;
        public static string TenNhanVienDN;
        public static string UserName;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (cbMK.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if(cbMK.Checked==false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap, MatKhau;
            TenDangNhap = txtUserName.Text;
            MatKhau = txtPassword.Text;
            UserName = txtUserName.Text;
            //xử lý kiểm tra logic đăng nhập
            if (string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(TenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
            else
            {
                QLTXDBContext qlxe = new QLTXDBContext();
                NhanVien nv = qlxe.NhanVien.FirstOrDefault(s => s.TenDangNhap == txtUserName.Text && s.isDeleted == false);
                if (nv != null)
                {
                    if (MatKhau == nv.MatKhau)
                    {
                        //Trường hợp đăng nhập thành công
                        nvname = TenDangNhap;
                        nvrole = nv.ChucVu;
                        manv = nv.MaNV;
                        TenNhanVienDN = nv.TenNV;
                        if (nv.ChucVu == "1")
                        {
                            frmMeNu3 form = new frmMeNu3();

                            this.Hide();
                            form.ShowDialog();
                            //Code sẽ thực khi khi đóng form dialog
                            this.Show();
                        }
                        else
                        {
                            frmMeNu3 form = new frmMeNu3();

                            this.Hide();
                            form.ShowDialog();
                            //Code sẽ thực khi khi đóng form dialog
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại");
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDK = new frmDangKy();
            frmDK.ShowDialog();
        }

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMK.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (cbMK.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
