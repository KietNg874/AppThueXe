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
    public partial class frmThemKhachHang : KryptonForm
    {
        public static string makh = "";
        public static string tenkh = "";
        public static string diachi = "";
        public static string sdt = "";
        public static string gplx = "";

        public frmThemKhachHang()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmMeNu3 frm = new frmMeNu3();
            this.Size = frm.Size;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.2, (float)1.2));
        }
        QLTXDBContext qlkh = new QLTXDBContext();
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            
            List<KhachHang> KH= qlkh.KhachHang.Where(s => s.isDeleted == false).ToList();

            fillDGVKhachHang(KH);
        }
        public void fillDGVKhachHang(List<KhachHang> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach(var kh in listKhachHang)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = kh.MaKH;
                dgvKhachHang.Rows[index].Cells[1].Value = kh.TenKH;
                dgvKhachHang.Rows[index].Cells[2].Value = kh.DiaChi;
                dgvKhachHang.Rows[index].Cells[3].Value = kh.SDT;
                dgvKhachHang.Rows[index].Cells[4].Value = kh.GPLX;


            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvKhachHang.CurrentCell.RowIndex;
            if (dgvKhachHang.CurrentCell == null || dgvKhachHang.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            else if (index >= 0)
            {
                var dongchon = dgvKhachHang.Rows[index];
                string MaKH = dongchon.Cells[0].Value.ToString();
                string TenKH = dongchon.Cells[1].Value.ToString();
                string DiaChi = dongchon.Cells[2].Value.ToString();
                string SDT = dongchon.Cells[3].Value.ToString();
                string GPLX = dongchon.Cells[4].Value.ToString();
                txtTenKH.Text = TenKH;
                txtCCCD.Text = MaKH;
                txtDiaChi.Text = DiaChi;
                txtSDT.Text = SDT;
                txtGPLX.Text = GPLX;

            }
        }

        // thêm khách hàng 
        private void EmptyTexbox()
        {
            txtCCCD.Text = txtTenKH.Text = txtSDT.Text = txtGPLX.Text = txtDiaChi.Text = string.Empty;
        }

        private void txtTimCCCD_TextChanged(object sender, EventArgs e)
        {
            string matim = txtTimCCCD.Text;
            List<KhachHang> listKH = qlkh.KhachHang.Where(s => s.isDeleted == false).ToList();
            var listTim = listKH.Where(s => s.MaKH.StartsWith(matim)).ToList();
            fillDGVKhachHang(listTim);
        }

        private void btnChonXe_Click(object sender, EventArgs e)
        {
            makh = txtCCCD.Text;
            tenkh = txtTenKH.Text;
            sdt = txtSDT.Text;
            diachi = txtDiaChi.Text;
            gplx = txtGPLX.Text;
            this.Hide();
            ////
            frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
            menuForm.OpenChonXeForm();
            ////
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCCCD.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtGPLX.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!");
                }
                KhachHang tim = qlkh.KhachHang.FirstOrDefault(x => x.MaKH == txtCCCD.Text);
                if (tim == null)
                {

                    KhachHang khachhang = new KhachHang();
                    khachhang.MaKH = txtCCCD.Text;
                    khachhang.DiaChi = txtDiaChi.Text;
                    khachhang.SDT = txtSDT.Text;
                    khachhang.TenKH = txtTenKH.Text;
                    khachhang.GPLX = txtGPLX.Text;
                    khachhang.isDeleted = false;

                    //Thêm xuống vào table
                    qlkh.KhachHang.Add(khachhang);
                    // Lưu xuống database
                    qlkh.SaveChanges();
                    List<KhachHang> KH = qlkh.KhachHang.Where(s => s.isDeleted == false).ToList();
                    fillDGVKhachHang(KH);
                    MessageBox.Show("Thêm thành công");

                }
                else if (tim != null && tim.isDeleted == true)
                {
                    if (tim.isDeleted == true)
                    {
                        tim.MaKH = txtCCCD.Text;
                    }
                    tim.MaKH = txtCCCD.Text;
                    tim.DiaChi = txtDiaChi.Text;
                    tim.SDT = txtSDT.Text;
                    tim.TenKH = txtTenKH.Text;
                    tim.GPLX = txtGPLX.Text;
                    tim.isDeleted = false;
                    qlkh.SaveChanges();

                    List<KhachHang> KH = qlkh.KhachHang.Where(s => s.isDeleted == false).ToList();
                    fillDGVKhachHang(KH);
                    MessageBox.Show("Thêm thành công");

                    {
                        tim.isDeleted = false;

                    }
                }
                else
                {
                    throw new Exception("Mã hàng hóa đã tồn tại, không thể thêm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCCCD.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtGPLX.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!");
                }
                KhachHang tim = qlkh.KhachHang.FirstOrDefault(x => x.MaKH == txtCCCD.Text);
                if (tim == null)
                {

                    throw new Exception("Mã khách không tồn tại, không thể sửa!");

                }
                else if (tim != null && tim.isDeleted == true)
                {
                    throw new Exception("Mã khách không tồn tại, không thể sửa!");
                }

                else if (tim != null)
                {
                    tim.MaKH = txtCCCD.Text;
                    tim.DiaChi = txtDiaChi.Text;
                    tim.SDT = txtSDT.Text;
                    tim.TenKH = txtTenKH.Text;
                    tim.GPLX = txtGPLX.Text;
                    tim.isDeleted = false;


                    qlkh.SaveChanges();
                    List<KhachHang> KH = qlkh.KhachHang.Where(s => s.isDeleted == false).ToList();
                    fillDGVKhachHang(KH);
                    MessageBox.Show("Cập nhật thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                KhachHang kh = qlkh.KhachHang.FirstOrDefault(p => p.MaKH == txtCCCD.Text);
                if (kh == null)
                {
                    MessageBox.Show("Không tìm thấy khách", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (kh != null && kh.isDeleted == true)
                {
                    MessageBox.Show("Không tìm thấy khách", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Thông tin từ hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kh.isDeleted = true;
                    qlkh.SaveChanges();
                    List<KhachHang> KH = qlkh.KhachHang.Where(p => p.isDeleted == false).ToList();
                    fillDGVKhachHang(KH);
                    EmptyTexbox();
                    MessageBox.Show("Xóa khách hàng thành công", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
