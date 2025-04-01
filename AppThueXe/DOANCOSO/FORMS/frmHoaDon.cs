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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace DOANCOSO.FORMS
{
    public partial class frmHoaDon : KryptonForm
    {
        public static double thongke;
        
        public frmHoaDon()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        public static int MaXemHoaDon;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDon> dsHoaDon = context.HoaDon.Where(s => s.isDeleted == false).ToList();

            fillDgvHoaDon(dsHoaDon);
        }
        private void fillDgvHoaDon(List<HoaDon> ListHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            decimal tongtien = 0;
            foreach (var item in ListHoaDon)
            {
                if (item.NgayThanhToan.Date == dtpThoiGian.Value.Date)
                {
                    int index = dgvHoaDon.Rows.Add();
                    dgvHoaDon.Rows[index].Cells[0].Value = item.MaHoaDon;
                    dgvHoaDon.Rows[index].Cells[1].Value = item.MaKH_FK.MaKH;
                    dgvHoaDon.Rows[index].Cells[2].Value = item.nvThanhToan;
                    dgvHoaDon.Rows[index].Cells[3].Value = item.NgayThanhToan;
                    dgvHoaDon.Rows[index].Cells[4].Value = item.TongTienHoaDon;
                    tongtien += item.TongTienHoaDon;
                }
                txtTongTienTatCaHd.Text = tongtien.ToString();
                
            }
        }

        List<HoaDon> listHoaDon = new List<HoaDon>();

        private void dtpTimTg_ValueChanged(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            DateTime NgayCanTim = dtpThoiGian.Value.Date;
            List<HoaDon> dsHoaDon = context.HoaDon.Where(s => s.isDeleted == false).ToList();
            var hoadontrongngay = dsHoaDon.Where(hd => hd.NgayThanhToan.Date == NgayCanTim).ToList();
            decimal tongtien = 0;
            foreach (var item in hoadontrongngay)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MaHoaDon;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MaKH_FK.MaKH;
                dgvHoaDon.Rows[index].Cells[2].Value = item.nvThanhToan;
                dgvHoaDon.Rows[index].Cells[3].Value = item.NgayThanhToan;
                dgvHoaDon.Rows[index].Cells[4].Value = item.TongTienHoaDon;
                tongtien += item.TongTienHoaDon;

            }
            txtTongTienTatCaHd.Text = tongtien.ToString();
        }
      
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvHoaDon.CurrentCell.RowIndex;
            if (dgvHoaDon.CurrentCell == null || dgvHoaDon.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            if (index >= 0)
            {
                var dongChon = dgvHoaDon.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string mahd = dongChon.Cells[0].Value.ToString();
                txtXemCTHD.Text = mahd;
                MaXemHoaDon = int.Parse(mahd); 
            }
        }


        private void btnXemCTHoaDon_Click(object sender, EventArgs e)
        {
            if (txtXemCTHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn xem");
            }
            else
            {
                frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                menuForm.XemHDForm();
            }
        }
        public void ExportExcel(DataGridView dataGridView, string duongdan)
        {
            List<HoaDon> dsHoaDon = context.HoaDon.Where(s => s.isDeleted == false).ToList();
            var excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "HoaDon";

            // Đặt tiêu đề cột
            worksheet.Cells[1, 1] = "MaHoaDon";
            worksheet.Cells[1, 2] = "MaKH";
            worksheet.Cells[1, 3] = "NvThanhToan";
            worksheet.Cells[1, 4] = "NgayThanhToan";
            worksheet.Cells[1, 5] = "TongTienHoaDon";

            decimal tongTien = 0;
            int rowIndex = 2; // Bắt đầu từ hàng thứ hai để dành chỗ cho tiêu đề

            foreach (var item in dsHoaDon)
            {
                if (item.NgayThanhToan.Date == dtpThoiGian.Value.Date)
                {
                    worksheet.Cells[rowIndex, 1] = item.MaHoaDon;
                    worksheet.Cells[rowIndex, 2] = item.MaKH_FK.MaKH;
                    worksheet.Cells[rowIndex, 3] = item.nvThanhToan;
                    worksheet.Cells[rowIndex, 4] = item.NgayThanhToan.ToShortDateString();
                    worksheet.Cells[rowIndex, 5] = item.TongTienHoaDon;
                    tongTien += item.TongTienHoaDon;
                    rowIndex++;
                }
            }

            txtTongTienTatCaHd.Text = tongTien.ToString();

            // Lưu tệp Excel
            workbook.SaveAs(duongdan);
            workbook.Saved = true;
            excelApp.Quit();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu tệp Excel";
                saveFileDialog.FileName ="";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDan = saveFileDialog.FileName;
                    ExportExcel(dgvHoaDon, duongDan);
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpThoiGian.Value = DateTime.Now;
            List<HoaDon> dsHoaDon = context.HoaDon.Where(s => s.isDeleted == false).ToList();
            fillDgvHoaDon(dsHoaDon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            List<HoaDon> dsHoaDon = context.HoaDon.Where(s => s.NgayThanhToan.Month == DateTime.Now.Month).ToList();
            var hoadontrongngay = dsHoaDon.ToList();
            decimal tongtien = 0;
            foreach (var item in hoadontrongngay)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MaHoaDon;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MaKH;
                dgvHoaDon.Rows[index].Cells[2].Value = item.nvThanhToan;
                dgvHoaDon.Rows[index].Cells[3].Value = item.NgayThanhToan;
                dgvHoaDon.Rows[index].Cells[4].Value = item.TongTienHoaDon;
                tongtien += item.TongTienHoaDon;

            }
            txtTongTienTatCaHd.Text = tongtien.ToString();
        }
    }
}
