using ComponentFactory.Krypton.Toolkit;
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
    public partial class frmDangKy : KryptonForm
    {
        public frmDangKy()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Scale(new SizeF((float)1.5, (float)1.5));
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            if (cbMK.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtNhapLaiMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtNhapLaiMK.UseSystemPasswordChar = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtTenNV.Text == "" || txtSDT.Text == "" || txtPassword.Text == "" || txtNhapLaiMK.Text == "" || txtDiaChiNV.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng ký nhân viên!");
                }
                QLTXDBContext qlxe = new QLTXDBContext();
                NhanVien nv = qlxe.NhanVien.FirstOrDefault(s => s.TenDangNhap == txtUserName.Text && s.isDeleted == false);
                if (nv != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
                else if (nv == null)
                {
                    if (txtNhapLaiMK.Text == txtPassword.Text)
                    {
                        NhanVien add = new NhanVien();
                        add.TenNV = txtTenNV.Text;
                        add.TenDangNhap = txtUserName.Text;
                        add.MatKhau = txtPassword.Text;
                        add.SDT = txtSDT.Text;
                        add.ChucVu = "0";
                        add.DiaChi = txtDiaChiNV.Text;
                        qlxe.NhanVien.Add(add);
                        qlxe.SaveChanges();
                        MessageBox.Show("Tạo tài khoản thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không giống nhau!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMK.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtNhapLaiMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtNhapLaiMK.UseSystemPasswordChar = true;
            }
        }
    }
}
