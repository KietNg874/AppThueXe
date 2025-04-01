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
    public partial class frmNhanVien : KryptonForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			this.Dock = DockStyle.Fill;
			this.Scale(new SizeF((float)1.3, (float)1.3));
		}

        QLTXDBContext ql = new QLTXDBContext();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> NV = ql.NhanVien.Where(s => s.isDeleted == false).ToList();
            fillDGVNhanVien(NV);
        }
        private void fillDGVNhanVien(List<NhanVien> ListNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var nv in ListNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
				dgvNhanVien.Rows[index].Cells[0].Value = nv.MaNV;
				dgvNhanVien.Rows[index].Cells[1].Value = nv.TenDangNhap;
				dgvNhanVien.Rows[index].Cells[2].Value = nv.TenNV;
				dgvNhanVien.Rows[index].Cells[3].Value = nv.SDT;
				dgvNhanVien.Rows[index].Cells[4].Value = nv.ChucVu;
                dgvNhanVien.Rows[index].Cells[5].Value = nv.MatKhau;
				dgvNhanVien.Rows[index].Cells[6].Value = nv.DiaChi;

			}
		}

		// Kiệt gửi

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			var index = dgvNhanVien.CurrentCell.RowIndex;
			if (dgvNhanVien.CurrentCell == null || dgvNhanVien.CurrentCell.Value == null || e.RowIndex == -1)
			{
				return;
			}
			else if (index >= 0)
			{

				var dongchon = dgvNhanVien.Rows[index];

				string TenDN = dongchon.Cells[1].Value.ToString();
				string TenNV = dongchon.Cells[2].Value.ToString();
				string SDT = dongchon.Cells[3].Value.ToString();
				string ChucVu = dongchon.Cells[4].Value.ToString();
				string mk = dongchon.Cells[5].Value.ToString();
				string diachi = dongchon.Cells[6].Value.ToString();
				txtTenDN.Text = TenDN;
				txtTenNV.Text = TenNV;
				txtSDT.Text = SDT;
				txtChucVu.Text = ChucVu;
				txtMK.Text = mk;
				txtDiaChiNV.Text = diachi;
			}
		}
		private void EmptyTexbox()
		{
			txtTenDN.Text = txtTenNV.Text = txtSDT.Text = txtChucVu.Text = txtMK.Text = string.Empty;
		}

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
			string matim = txtTimNV.Text;
			List<NhanVien> listnv = ql.NhanVien.Where(p => p.isDeleted == false).ToList();
			var listTim = listnv.Where(s => s.TenDangNhap.StartsWith(matim)).ToList();
			fillDGVNhanVien(listTim);
		}
        private void btnThemNV_Click(object sender, EventArgs e)
        {
			try
			{
				if (txtTenDN.Text == "" || txtTenNV.Text == "" || txtSDT.Text == "" || txtChucVu.Text == "" || txtMK.Text == "")
				{
					throw new Exception("Vui lòng nhập đầy đủ thông tin nhân viên!");
				}
				NhanVien tim = ql.NhanVien.FirstOrDefault(x => x.TenDangNhap.ToString() == txtTenDN.Text);
				if (tim == null)
				{

					NhanVien nv = new NhanVien();
					nv.TenDangNhap = txtTenDN.Text;
					nv.TenNV = txtTenNV.Text;
					nv.SDT = txtSDT.Text;
					nv.ChucVu = txtChucVu.Text;
					nv.MatKhau = txtMK.Text;
					nv.DiaChi = txtDiaChiNV.Text;
					nv.isDeleted = false;
					ql.NhanVien.Add(nv);
					ql.SaveChanges();
					List<NhanVien> NV = ql.NhanVien.Where(s => s.isDeleted == false).ToList();
					fillDGVNhanVien(NV);
					MessageBox.Show("Thêm thành công");

				}
				else if (tim != null && tim.isDeleted == true)
				{
					if (tim.isDeleted == true)
					{
						tim.TenDangNhap = txtTenDN.Text;
					}
					tim.TenDangNhap = txtTenDN.Text;
					tim.TenNV = txtTenNV.Text;
					tim.SDT = txtSDT.Text;
					tim.ChucVu = txtChucVu.Text;
					tim.Luongcb = Int32.Parse(txtMK.Text);
					tim.DiaChi = txtDiaChiNV.Text;
					tim.isDeleted = false;

					ql.SaveChanges();

					List<NhanVien> NV = ql.NhanVien.Where(s => s.isDeleted == false).ToList();
					fillDGVNhanVien(NV);
					MessageBox.Show("Thêm thành công");

					{
						tim.isDeleted = false;

					}
				}
				else
				{
					throw new Exception("Tên đăng nhập đã tồn tại, không thể thêm!");
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
				if (txtTenDN.Text == "" || txtTenNV.Text == "" || txtSDT.Text == "" || txtChucVu.Text == "" || txtMK.Text == "")
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				}
				NhanVien tim = ql.NhanVien.FirstOrDefault(x => x.TenDangNhap.ToString() == txtTenDN.Text);
				if (tim == null)
				{

					throw new Exception("Tên đăng nhập không tồn tại, không thể sửa!");

				}
				else if (tim != null && tim.isDeleted == true)
				{
					throw new Exception("Tên đăng nhập không tồn tại, không thể sửa!");
				}

				else if (tim != null)
				{
					tim.TenDangNhap = txtTenDN.Text;
					tim.TenNV = txtTenNV.Text;
					tim.SDT = txtSDT.Text;
					tim.ChucVu = txtChucVu.Text;
					tim.MatKhau = txtMK.Text;
					tim.isDeleted = false;
					ql.SaveChanges();

					List<NhanVien> NV = ql.NhanVien.Where(s => s.isDeleted == false).ToList();
					fillDGVNhanVien(NV);
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

				NhanVien nhanvien = ql.NhanVien.FirstOrDefault(p => p.TenDangNhap == txtTenDN.Text);
				if (nhanvien == null)
				{
					MessageBox.Show("Không tìm thấy nhân viên", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if (nhanvien != null && nhanvien.isDeleted == true)
				{
					MessageBox.Show("Không tìm thấy nhân viên", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Thông tin từ hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					nhanvien.isDeleted = true;
					ql.SaveChanges();
					List<NhanVien> nv = ql.NhanVien.Where(p => p.isDeleted == false).ToList();
					fillDGVNhanVien(nv);
					EmptyTexbox();
					MessageBox.Show("Xóa nhân viên thành công", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
}
