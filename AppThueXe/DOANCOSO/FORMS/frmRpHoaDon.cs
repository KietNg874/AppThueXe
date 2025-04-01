using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
using DoAnCoSoQLTX.Entities;
using Microsoft.Reporting.WinForms;
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
    public partial class frmRpHoaDon : Form
    {
        public frmRpHoaDon()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();

        private void frmRpHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonReport> listreport = new List<HoaDonReport>();
            List<ChiTietHoaDon> listct = context.ChiTietHoaDon.ToList();
  
       //     List<ChiTietHopDong> listcthopdong = context.ChiTietHopDong.ToList();
            foreach(var item in listct)
            {
                    if (item.MaHD == frmHopDong.MaXemCT)
                {
         
                       HoaDonReport add = new HoaDonReport();
                         add.BienSo = item.BienSo;
                         add.LoaiXe = item.BienSo_FK.MaLoaiXe_FK.TenLoaiXe;
                         add.TenXe = item.BienSo_FK.TenXe;
                         add.TienThu = item.TienChiTiet;
                         add.NgayThanhToan = dtpTG.Value;
                         listreport.Add(add);
                }
            }
            reportViewer1.LocalReport.ReportPath = "rptHoaDon.rdlc";
           var sc = new ReportDataSource("DataSet2", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sc);
            this.reportViewer1.RefreshReport();
        }
    }
}
