using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace DOANCOSO.FORMS
{
    public partial class frmXeHongTrongThang : Form
    {
        public frmXeHongTrongThang()
        {
            InitializeComponent();
        }
        QLTXDBContext context = new QLTXDBContext();
        private void frmXeHongTrongThang_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            List<XeHong> listxehong = context.XeHong.Where(s => s.NgaySua.Month == DateTime.Now.Month).ToList();
            filldgvXeHongTrongThang(listxehong);
        }
        private void filldgvXeHongTrongThang(List<XeHong> listXeHong)
        {
            dgvXeHongTrongThang.Rows.Clear();

            foreach (var item in listXeHong)
            {
                int index = dgvXeHongTrongThang.Rows.Add();
                dgvXeHongTrongThang.Rows[index].Cells[0].Value = item.BienXeHong;
                dgvXeHongTrongThang.Rows[index].Cells[1].Value = item.TenXeHong;
                dgvXeHongTrongThang.Rows[index].Cells[2].Value = item.LyDoHong;
                dgvXeHongTrongThang.Rows[index].Cells[3].Value = item.SuaCaiGi;
                dgvXeHongTrongThang.Rows[index].Cells[4].Value = item.TienSua;
            }
            dgvXeHongTrongThang.Refresh();
        }

        public void ExportExcel(DataGridView dataGridView, string duongdan)
        {
            // Get data to export
            List<XeHong> dsxe = context.XeHong.Where(s => s.NgaySua.Month == DateTime.Now.Month).ToList();
            var excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "HoaDon";

            // Set column titles
            worksheet.Cells[1, 1] = "Biển số xe";
            worksheet.Cells[1, 2] = "Tên xe";
            worksheet.Cells[1, 3] = "Lý do hỏng";
            worksheet.Cells[1, 4] = "Sửa";
            worksheet.Cells[1, 5] = "Tiền sửa";

            decimal tongTien = 0;
            int rowIndex = 2; // Start from the second row for data

            // Populate the worksheet with data
            foreach (var item in dsxe)
            {
                if (item.NgaySua.Month == DateTime.Now.Month)
                {
                    worksheet.Cells[rowIndex, 1] = item.BienXeHong;
                    worksheet.Cells[rowIndex, 2] = item.TenXeHong;
                    worksheet.Cells[rowIndex, 3] = item.LyDoHong;
                    worksheet.Cells[rowIndex, 4] = item.SuaCaiGi;
                    worksheet.Cells[rowIndex, 5] = item.TienSua;
                    
                    rowIndex++;
                }
            }

   

            // Save the Excel file
            workbook.SaveAs(duongdan);
            workbook.Saved = true;
            excelApp.Quit();
        }

        private void btnChuyenxe_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu tệp Excel";
                saveFileDialog.FileName = "";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDan = saveFileDialog.FileName;
                    ExportExcel(dgvXeHongTrongThang, duongDan);
                }
            }
        }
    }
}
