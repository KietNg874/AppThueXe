using Aspose.Words;
using Aspose.Words.Tables;
using ComponentFactory.Krypton.Toolkit;
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
using ThuVienWinform.Report.AsposeWordExtension;

namespace DOANCOSO.FORMS
{
    public partial class frmChonXe : KryptonForm
    {

		public frmChonXe()
        {
            InitializeComponent();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			this.Dock = DockStyle.Fill;
			this.Scale(new SizeF((float)1, (float)1));
		}
        QLTXDBContext ql = new QLTXDBContext();
		public static string CCCD;
		string TenKhachHang;
        private void frmChonXe_Load(object sender, EventArgs e)
		{
            List<Xe> XE = ql.Xe.Where(s => s.isDeleted == false).ToList();
			List<KhachHang> KH = ql.KhachHang.Where(s => s.isDeleted == false).ToList();
			fillDGVKH(KH);
			fillDGVXe(XE);
		}
		public void fillDGVXe(List<Xe> listXe)
		{
			dgvChonXe.Rows.Clear();
			foreach (var xe in listXe)
			{
				int index = dgvChonXe.Rows.Add();
				dgvChonXe.Rows[index].Cells[0].Value = xe.BienSo;
				dgvChonXe.Rows[index].Cells[1].Value = xe.TenXe;
				dgvChonXe.Rows[index].Cells[2].Value = xe.GiaXe;
				dgvChonXe.Rows[index].Cells[3].Value = xe.MaLoaiXe_FK.TenLoaiXe;
				if (xe.TrangThai == true)
				{
					dgvChonXe.Rows[index].Cells[4].Value = "Đã thuê";
				}
				else
				{
					dgvChonXe.Rows[index].Cells[4].Value = "Chưa thuê";
				}
				dgvChonXe.Rows[index].Cells[5].Value = xe.ImgXe;


			}
		}
		public void fillDGVKH(List<KhachHang> listKH)
		{
			dgvLoadKhachHang.Rows.Clear();
			foreach (var kh in listKH)
			{
				int index = dgvLoadKhachHang.Rows.Add();
				dgvLoadKhachHang.Rows[index].Cells[0].Value = kh.MaKH;
				dgvLoadKhachHang.Rows[index].Cells[1].Value = kh.TenKH;
				dgvLoadKhachHang.Rows[index].Cells[2].Value = kh.DiaChi;
				dgvLoadKhachHang.Rows[index].Cells[3].Value = kh.SDT;
				dgvLoadKhachHang.Rows[index].Cells[4].Value = kh.GPLX;


			}
		}
		List<Xe> XeDaChon = new List<Xe>();
		private void dgvChonXe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            //Lấy ra dòng dữ liệu mà user chọn
            //Lấy ra row selected trên datagridview
            var index = dgvChonXe.CurrentCell.RowIndex;
			if (dgvChonXe.CurrentCell == null || dgvChonXe.CurrentCell.Value == null || e.RowIndex == -1)
			{
				return;
			}
			if (index >= 0)
            {
                var dongChon = dgvChonXe.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string bienso = dongChon.Cells[0].Value.ToString();
                string tenxe = dongChon.Cells[1].Value.ToString();
                string giathue = dongChon.Cells[2].Value.ToString();
                string loaixe = dongChon.Cells[3].Value.ToString();
				string anhxe = dongChon.Cells[5].Value.ToString();
				Xe chonXe = new Xe();// tao kieu du lieu xe co ten chon xe
				
				chonXe.BienSo = bienso;
				chonXe.TenXe = tenxe;
				chonXe.GiaXe = int.Parse(giathue);
				if(dongChon.Cells[4].Value.ToString() == "Đã thuê")
				{
					chonXe.TrangThai = true;
					MessageBox.Show("Xe đã thuê không thể cho thuê!");
					return;

				}
				else if(dongChon.Cells[4].Value.ToString() == "Chưa thuê"){
					chonXe.TrangThai = false;
				}
				chonXe.ImgXe = anhxe;
				chonXe.MaLoaiXe_FK = new LoaiXe();//tạo đối tượng MaLoaiXe_FK
				chonXe.MaLoaiXe_FK.TenLoaiXe = loaixe;
				if (!XeDaChon.Any(xe => xe.BienSo == bienso)) // KT xe đã chọn chưa
				{
					XeDaChon.Add(chonXe);
					ql.SaveChanges();
					fillDGVDaChon(XeDaChon);
				}
				else
				{
					MessageBox.Show("Xe đã chọn");
				}

			}
        }

		public void fillDGVDaChon(List<Xe> listDaChon)
		{
			dgvDaChon.Rows.Clear();
			foreach (var xe in listDaChon)
			{
				int index = dgvDaChon.Rows.Add();
				dgvDaChon.Rows[index].Cells[0].Value = xe.BienSo;
				dgvDaChon.Rows[index].Cells[1].Value = xe.TenXe;
				dgvDaChon.Rows[index].Cells[2].Value = xe.GiaXe;
				dgvDaChon.Rows[index].Cells[3].Value = xe.MaLoaiXe_FK.TenLoaiXe;
				dgvDaChon.Rows[index].Cells[5].Value = xe.ImgXe;
				
				picAnh.Image = Bitmap.FromFile(xe.ImgXe);

				if (xe.TrangThai == true)
				{
					dgvDaChon.Rows[index].Cells[4].Value = "Đã thuê";
				}
				else
				{
					dgvDaChon.Rows[index].Cells[4].Value = "Chưa thuê";
				}
			}
		}


		List<KhachHang> dsKhachHangDaCHon = new List<KhachHang>();
        private void dgvLoadKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			//Lấy ra dòng dữ liệu mà user chọn
			//Lấy ra row selected trên datagridview
			var index = dgvLoadKhachHang.CurrentCell.RowIndex;
			if (dgvLoadKhachHang.CurrentCell == null || dgvLoadKhachHang.CurrentCell.Value == null || e.RowIndex == -1)
			{
				return;
			}
			if (index >= 0)
			{
				KhachHang chonkh = new KhachHang();
				var dongChon = dgvLoadKhachHang.Rows[index];
				//Đi vào từng cột để lấy dữ liệu
				string cccd = dongChon.Cells[0].Value.ToString();
				string tenkh = dongChon.Cells[1].Value.ToString();
				string diachi = dongChon.Cells[2].Value.ToString();
				string sdt = dongChon.Cells[3].Value.ToString();
				string gplx = dongChon.Cells[4].Value.ToString();
				chonkh.MaKH = cccd;

				CCCD = cccd;
				TenKhachHang = txtTenKH.Text;
				chonkh.TenKH = tenkh;
				chonkh.DiaChi = diachi;
				chonkh.SDT = sdt;
				chonkh.GPLX = gplx;
				dsKhachHangDaCHon.Add(chonkh);
			}

		}

        private void txtTimXe_TextChanged(object sender, EventArgs e)
        {
			string matimxe = txtTimXe.Text;
			List<Xe> listXe = ql.Xe.Where(s => s.isDeleted == false).ToList();
			var listTim = listXe.Where(s => s.BienSo.StartsWith(matimxe)).ToList();
			fillDGVXe(listTim);
		}

        private void txtTimCCCD_TextChanged(object sender, EventArgs e)
        {
			string matimkh = txtTimCCCD.Text;
			List<KhachHang> listKH = ql.KhachHang.Where(s => s.isDeleted == false).ToList();
			var listTim = listKH.Where(s => s.MaKH.StartsWith(matimkh)).ToList();
			fillDGVKH(listTim);
		}

        private void dgvDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgvChonXe.CurrentCell == null || dgvChonXe.CurrentCell.Value == null || e.RowIndex == -1)
			{
				return;
			}
			var index = dgvDaChon.CurrentCell.RowIndex;

			Xe XoaXeDC = XeDaChon[index];
			XeDaChon.RemoveAt(index);

			dgvDaChon.Rows.RemoveAt(index);

			ql.SaveChanges();
		}

        private void btnLapHD_Click(object sender, EventArgs e)
        {
			string tinhtrang = txtTinhTrangXe.Text;
            if (tinhtrang == "")
            {
				MessageBox.Show("Vui lòng thêm tình trạng xe");
				return;
			}
			if (dsKhachHangDaCHon.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn khách hàng");
			}
			else if(XeDaChon.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn xe thuê");
			}
			else
			{
				this.Hide();
				this.Close();
				HopDong hopdong = new HopDong();
				
				foreach (var item in XeDaChon)
				{
					ChiTietHopDong cthd = new ChiTietHopDong();
					// load tat ca cac se da chonn trong list xedachon ra
					cthd.BienSo_FK = ql.Xe.FirstOrDefault(x => x.BienSo == item.BienSo);
					cthd.MaKH_FK = new KhachHang();
					cthd.MaKH_FK = ql.KhachHang.FirstOrDefault(a => a.MaKH == CCCD);
					hopdong.NoiDung = cthd.MaKH_FK.TenKH;
					hopdong.NgayLapHopDong = DateTime.Now;
					hopdong.TrangThaiBanDau = tinhtrang;
					hopdong.SdtKH = cthd.MaKH_FK.SDT;
					cthd.MaNV_FK = new NhanVien();

					cthd.MaNV_FK = ql.NhanVien.FirstOrDefault(a => a.MaNV == frmDangNhap.manv);
				
					cthd.TienThue = item.GiaXe;
					//chuyen Xe thanh True (Da thue)
					Xe xe = ql.Xe.FirstOrDefault(x => x.BienSo == item.BienSo);
					if (xe != null)
					{
						xe.TrangThai = true;
					}

					ql.ChiTietHopDong.Add(cthd);
				}
			
				DialogResult result = MessageBox.Show("Bạn có chắc lập hợp đồng không"," Xac nhan", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					ql.HopDong.Add(hopdong);
					ql.SaveChanges();
					// Bước 1: Nạp file mẫu
					Document baoCao = new Document("In\\mau-hop-dong-thue-xe.docx");
				

					//Bước 2: Điền các thông tin cố định


					baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Hồ Chí Minh, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) });


					baoCao.MailMerge.Execute(new[] { "Ma_Hop_Dong" }, new[] { hopdong.MaHD.ToString() });
					foreach (var item in dsKhachHangDaCHon)
					{
						baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { item.TenKH });
						baoCao.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { item.DiaChi });
						baoCao.MailMerge.Execute(new[] { "Dien_Thoai_KH" }, new[] {item.SDT});
					}									
					baoCao.MailMerge.Execute(new[] { "Ngay_Thue" }, new[] { string.Format("ngày {0}", DateTime.Now.Date.Month) });
					// Điền thông tin lên bảng
					Table bangThongTinXe = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
					int dongHienTai = 1;
					int dem = 0;
					bangThongTinXe.InsertRows(dongHienTai, dongHienTai, XeDaChon.Count - 1);
					foreach (var item in XeDaChon)
					{
						dem++;
						//	baoCao.MailMerge.Execute(new[] { "Bien_So" }, new[] { item.BienSo.ToString() });
						bangThongTinXe.PutValue(dongHienTai, 0, dem.ToString());//Cột STT
						bangThongTinXe.PutValue(dongHienTai, 1, item.BienSo.ToString());//Cột Biển số xe
						bangThongTinXe.PutValue(dongHienTai, 2, item.TenXe.ToString());//Cột tên xe
						bangThongTinXe.PutValue(dongHienTai, 3, item.MaLoaiXe_FK.TenLoaiXe.ToString());//Cột loại xe
						bangThongTinXe.PutValue(dongHienTai, 4, item.GiaXe.ToString());//Cột gia thuê
						dongHienTai++;
					}
					List<NhanVien> listnv = ql.NhanVien.ToList();
					foreach (var item in listnv)
					{
						if (item.TenDangNhap == frmDangNhap.nvname)
						{
							baoCao.MailMerge.Execute(new[] { "Ten_NV" }, new[] { item.TenNV });
							baoCao.MailMerge.Execute(new[] { "Dien_Thoai_NV" }, new[] { item.SDT });
							baoCao.MailMerge.Execute(new[] { "Dia_Chi_NV" }, new[] {item.DiaChi});
						}
					}
					baoCao.MailMerge.Execute(new[] { "Tinh_Trang" }, new[] { tinhtrang });
					//Bước 3: Lưu và mở file
					baoCao.SaveAndOpenFile("BaoCao.doc");
					frmMeNu3 menuForm= new frmMeNu3();
					menuForm.OpenHopDongForm();
				}
			}
		}

        private void txtAnhXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTGBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimTenXe_TextChanged(object sender, EventArgs e)
        {
			string matimxe = txtTimTenXe.Text;
			List<Xe> listxe = ql.Xe.Where(s => s.isDeleted == false).ToList();
			var tim = listxe.Where(s => s.TenXe.StartsWith(matimxe)).ToList();
			fillDGVXe(tim);
		}
    }
}
