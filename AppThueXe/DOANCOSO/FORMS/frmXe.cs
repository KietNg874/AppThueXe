using ComponentFactory.Krypton.Toolkit;
using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
using DoAnCoSoQLTX.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCOSO.FORMS
{
	public partial class frmXe : KryptonForm
	{
		public frmXe()
		{
			InitializeComponent();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			this.Dock = DockStyle.Fill;
			this.Scale(new SizeF((float)1.2, (float)1.2));
		}
		QLTXDBContext qlxe = new QLTXDBContext();
		private void frmXe_Load(object sender, EventArgs e)
		{
			List<Xe> XE = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
			List<LoaiXe> listLX = qlxe.LoaiXe.ToList();
			cbChuaThue.Checked = true;
			FillLoaiCombobox(listLX);
			fillDGVXe(XE);
		}
		private void FillLoaiCombobox(List<LoaiXe> listLX)
		{
			this.cbbLoaixe.DataSource = listLX;
			this.cbbLoaixe.DisplayMember = "TenLoaiXe";
			this.cbbLoaixe.ValueMember = "MaLoaiXe";
		}
		public void fillDGVXe(List<Xe> listXe)
		{
			dgvXe.Rows.Clear();
			foreach (var xe in listXe)
			{
				int index = dgvXe.Rows.Add();
				dgvXe.Rows[index].Cells[0].Value = xe.BienSo;
				dgvXe.Rows[index].Cells[1].Value = xe.TenXe;
				dgvXe.Rows[index].Cells[2].Value = xe.GiaXe;
				dgvXe.Rows[index].Cells[3].Value = xe.MaLoaiXe_FK.TenLoaiXe;
                if(xe.TrangThai == true){
					dgvXe.Rows[index].Cells[4].Value = "Đã thuê";
				}
                else
                {
					dgvXe.Rows[index].Cells[4].Value = "Chưa thuê";
				}
				
				dgvXe.Rows[index].Cells[5].Value = xe.ImgXe;
			}
		}

		private void cbDaThue_CheckedChanged(object sender, EventArgs e)
		{
			if (cbDaThue.Checked == true)
			{
				cbChuaThue.Checked = false;
			}
		}
		private void cbChuaThue_CheckedChanged(object sender, EventArgs e)
		{
			if (cbChuaThue.Checked == true)
			{
				cbDaThue.Checked = false;
			}

		}
		private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var index = dgvXe.CurrentCell.RowIndex;
			if (dgvXe.CurrentCell == null || dgvXe.CurrentCell.Value == null || e.RowIndex == -1) { 
				return;
			}
			else if (index >= 0)
			{

				var dongchon = dgvXe.Rows[index];

				string MaXe = dongchon.Cells[0].Value.ToString();
				string TenXe = dongchon.Cells[1].Value.ToString();
				string GiaThue = dongchon.Cells[2].Value.ToString();
				string LoaiXe = dongchon.Cells[3].Value.ToString();
				if (dongchon.Cells[4].Value.ToString() == "Đã thuê")
				{
					cbChuaThue.Checked = true;
				}
				else
				{
					cbDaThue.Checked = false;
				}
				//	string s = System.Text.Encoding.UTF8.GetString(ImgXe, 0, ImgXe.Length);
				string AnhXe = dongchon.Cells[5].Value.ToString();
				txtMaXe.Text = MaXe;
				txtTenXe.Text = TenXe;
				txtGiaThue.Text = GiaThue;
				cbbLoaixe.Text = LoaiXe;
				txtLinkAnh.Text = AnhXe;
				// doc link ảnh
				
				picXe.Image = Bitmap.FromFile(txtLinkAnh.Text);
			}
		}
		private void EmptyTexbox()
		{
			txtMaXe.Text = txtTenXe.Text = txtGiaThue.Text = cbbLoaixe.Text = txtLinkAnh.Text = string.Empty;
		}

        private void txtTimXe_TextChanged(object sender, EventArgs e)
        {
			string matim = txtTimXe.Text;
			List<Xe> listXe = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
			var listTim = listXe.Where(s => s.BienSo.StartsWith(matim)).ToList();
			fillDGVXe(listTim);
		}

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				picXe.ImageLocation = openFileDialog1.FileName;
				txtLinkAnh.Text = openFileDialog1.FileName;
			}
		}

        private void btnThemXe_Click(object sender, EventArgs e)
        {
			try
			{
				if (txtMaXe.Text == "" || txtTenXe.Text == "" || txtGiaThue.Text == "" || txtLinkAnh.Text == "")
				{
					throw new Exception("Vui lòng nhập đầy đủ thông tin xe!");
				}
				Xe tim = qlxe.Xe.FirstOrDefault(x => x.BienSo == txtMaXe.Text);
				if (tim == null)
				{
					Xe xe = new Xe();
					xe.BienSo = txtMaXe.Text;
					xe.GiaXe = Int32.Parse(txtGiaThue.Text); // Ep kieu tu string sang int
					xe.TenXe = txtTenXe.Text;
					xe.MaLoaiXe = cbbLoaixe.SelectedValue.ToString();
					xe.ImgXe = txtLinkAnh.Text;
					xe.isDeleted = false;
					if (cbChuaThue.Checked == true)
					{
						xe.TrangThai = false;
					}
					else
					{
						xe.TrangThai = true;
					}

					qlxe.Xe.Add(xe);
					qlxe.SaveChanges();
					List<Xe> XE = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
					fillDGVXe(XE);
					MessageBox.Show("Thêm thành công");

				}
				else if (tim != null && tim.isDeleted == true)
				{
					if (tim.isDeleted == true)
					{
						tim.BienSo = txtMaXe.Text;
					}
					tim.BienSo = txtMaXe.Text;
					tim.GiaXe = Int32.Parse(txtGiaThue.Text); // Ep kieu tu string sang int
					tim.TenXe = txtTenXe.Text;
					tim.MaLoaiXe = cbbLoaixe.SelectedValue.ToString();
					tim.ImgXe = txtLinkAnh.Text;
					tim.isDeleted = false;
					if (cbChuaThue.Checked == true)
					{
						tim.TrangThai = true;
					}
					else
					{
						tim.TrangThai = false;
					}

					qlxe.SaveChanges();

					List<Xe> XE = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
					fillDGVXe(XE);
					MessageBox.Show("Thêm thành công");
					{
						tim.isDeleted = false;
					}
				}
				else
				{
					throw new Exception("Mã xe đã tồn tại, không thể thêm!");
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
				if (txtMaXe.Text == "" || txtTenXe.Text == "" || txtGiaThue.Text == "" || txtLinkAnh.Text == "")
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				}
				Xe tim = qlxe.Xe.FirstOrDefault(x => x.BienSo == txtMaXe.Text);
				if (tim == null)
				{

					throw new Exception("Mã xe không tồn tại, không thể sửa!");

				}
				else if (tim != null && tim.isDeleted == true)
				{
					throw new Exception("Mã xe không tồn tại, không thể sửa!");
				}

				else if (tim != null)
				{
					tim.BienSo = txtMaXe.Text;
					tim.GiaXe = Int32.Parse(txtGiaThue.Text); // Ep kieu tu string sang int
					tim.TenXe = txtTenXe.Text;
					tim.MaLoaiXe = cbbLoaixe.SelectedValue.ToString();
					if (cbChuaThue.Checked == true)
					{
						tim.TrangThai = false;
					}
					else
					{
						tim.TrangThai = true;
					}
					tim.ImgXe = txtLinkAnh.Text;
					tim.isDeleted = false;
					qlxe.SaveChanges();
					List<Xe> XE = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
					fillDGVXe(XE);
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

				Xe xe = qlxe.Xe.FirstOrDefault(p => p.BienSo == txtMaXe.Text);
				if (xe == null)
				{
					MessageBox.Show("Không tìm xe", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if (xe != null && xe.isDeleted == true)
				{
					MessageBox.Show("Không tìm thấy xe", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var result = MessageBox.Show("Bạn có chắc muốn xóa xe này không?", "Thông tin từ hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					xe.isDeleted = true;
					qlxe.SaveChanges();
					List<Xe> XE = qlxe.Xe.Where(p => p.isDeleted == false).ToList();
					fillDGVXe(XE);
					EmptyTexbox();
					MessageBox.Show("Xóa xe thành công", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại", "Thông tin từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btnBaoTri_Click(object sender, EventArgs e)
        {

			try
			{
				// Kiểm tra xem các trường bắt buộc có bị trống không
				if (txtMaXe.Text == "" || txtTenXe.Text == "" || txtGiaThue.Text == "" || txtLinkAnh.Text == "")
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
					return;
				}

				// Tìm kiếm xe dựa vào biển số
				Xe tim = qlxe.Xe.FirstOrDefault(x => x.BienSo == txtMaXe.Text);
				if (tim == null || tim.isDeleted == true)
				{
					throw new Exception("Mã xe không tồn tại, không thể bảo trì!");
				}

				// Kiểm tra xem check chưa bảo trì
				if (cbBaoTri.Checked == false)
				{
					MessageBox.Show("Phải thêm nội dung bảo trì");
					return;
				}

				// Tạo danh sách tạm để lưu các mục cần thêm
				
				XeHong xe = new XeHong();
				xe.BienXeHong = tim.BienSo;
				xe.TenXeHong = tim.TenXe;
				xe.LyDoHong = "Bảo Trì";
				xe.NgaySua = DateTime.Now;
				xe.isDeleted = true;
				qlxe.XeHong.Add(xe);
			
	

				// Cập nhật trạng thái và isDeleted của xe
				tim.TrangThai = true;
				tim.isDeleted = false;
				qlxe.SaveChanges();
				// Cập nhật DataGridView với các xe không bị xóa
				List<Xe> XE = qlxe.Xe.Where(s => s.isDeleted == false).ToList();
				fillDGVXe(XE);

				MessageBox.Show("Thêm thành công");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
