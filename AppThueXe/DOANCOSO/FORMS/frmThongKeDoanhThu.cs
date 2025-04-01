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
using DOANCOSO.DATABASE;
using Microsoft.Reporting.WinForms;
using DoAnCoSoQLTX.Entities;
using System.Windows.Forms.DataVisualization.Charting;

namespace DOANCOSO.FORMS
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            List<HoaDon> listhd = context.HoaDon.ToList();
            var doanhthutheotheothang = listhd
            .GroupBy(record => new { Year = record.NgayThanhToan.Year, Month = record.NgayThanhToan.Month })
            .Select(group => new
            {
                Thang = new DateTime(group.Key.Year, group.Key.Month, 1),
                TongTienTheoThang = group.Sum(record => record.TongTienHoaDon)
            })
            .OrderBy(item => item.Thang);
            foreach (var item in doanhthutheotheothang)
            {

                chartDoanhThu.Series["Doanh Thu"].Points.AddXY(item.Thang.ToString("MM/yyyy"), item.TongTienTheoThang);
                chartDoanhThu.Series["Doanh Thu"].IsValueShownAsLabel = true;

            }
          ////  thong kê tiền phạt sửa chuửa
          //  List<HoaDonPhat> listhdp = context.HoaDonPhat.ToList();
          //  var tienphattheothang = listhdp
          //  .GroupBy(record => new { Year = record.NgayLapPhieu.Year, Month = record.NgayLapPhieu.Month })
          //  .Select(group => new
          //  {
          //      Thang = new DateTime(group.Key.Year, group.Key.Month, 1),
          //      TongTienTheoThang = group.Sum(record => record.TongTienPhat)
          //  })
          //  .OrderBy(item => item.Thang);

          //  foreach (var a in tienphattheothang)
          //  {
          //      chartDoanhThu.Series["Sửa Chữa"].Points.AddXY(a.Thang.ToString("MM/yyyy"), a.TongTienTheoThang);
          //      chartDoanhThu.Series["Sửa Chữa"].IsValueShownAsLabel = true;
          //  }
        //    thống kê chi phí bảo dưỡng xe
            List<XeHong> listphibaotrii = context.XeHong.ToList();
            var tienbaotriitheothang = listphibaotrii.Where(s=>s.LyDoHong=="Bảo Trì"&&s.isDeleted==false &&s.NgaySua.Year==DateTime.Now.Year)
            .GroupBy(record => new { Year = record.NgaySua.Year, Month = record.NgaySua.Month })
            .Select(group => new
            {
                Thang = new DateTime(group.Key.Year, group.Key.Month, 1),
                TongTienTheoThang = group.Sum(record => record.TienSua)
            })
            .OrderBy(item => item.Thang);

            foreach (var a in tienbaotriitheothang)
            {
                chartDoanhThu.Series["Sửa Chữa"].Points.AddXY(a.Thang.ToString("MM/yyyy"), a.TongTienTheoThang);
                chartDoanhThu.Series["Sửa Chữa"].IsValueShownAsLabel = true;
            }
            // thống kê số lần thuê xe
            List<ChiTietHopDong> listhopdong = context.ChiTietHopDong.ToList();
            List<Xe> listxe = context.Xe.ToList();
            foreach(var item in listxe)
            {
                Series series = new Series(item.TenXe);
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                var solanthuetheothang = listhopdong.Where(s => s.BienSo_FK.BienSo == item.BienSo && s.MaHD_FK.NgayLapHopDong.Year == DateTime.Now.Year)
               .GroupBy(record => new { Year = record.MaHD_FK.NgayLapHopDong.Year, Month = record.MaHD_FK.NgayLapHopDong.Month })
               .Select(group => new
               {
                   Thang = new DateTime(group.Key.Year, group.Key.Month, 1),
                   TongLanThueTrongThang = group.Count()
               })
            .OrderBy(a => a.Thang);
                foreach (var a in solanthuetheothang)
                {
                    series.Points.AddXY(a.Thang.ToString("MM/yyyy"), a.TongLanThueTrongThang);

                }
                chartThongKeXe.Series.Add(series);
            }

        
        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
