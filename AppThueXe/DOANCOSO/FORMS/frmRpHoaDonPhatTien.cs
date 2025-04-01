using DOANCOSO.DATABASE;
using DOANCOSO.Entities;
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
    public partial class frmRpHoaDonPhatTien : Form
    {
        public frmRpHoaDonPhatTien()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        private void frmRpHoaDonPhatTien_Load(object sender, EventArgs e)
        {
            List<HoaDonPhatReport> listReport = new List<HoaDonPhatReport>();
            List<ChiTietPhieuPhat> listct = context.ChiTietPhieuPhat.ToList();
            foreach (var item in listct)
            {
                if (item.MaPhieu_FK.MaPhieu == int.Parse(frmPhieuPhat.xemct))
                {
                    HoaDonPhatReport add = new HoaDonPhatReport();
                 
                    add.MaCTPhat = item.MaCTPP;
                    add.BienSo = item.BienSo;
                    add.TenXe = item.BienSo_FK.TenXe;
                    add.MaNV = item.MaNV;
                    add.TienThuSua = item.TienPhat;
                    add.NgayLap = DateTime.Now;
                    listReport.Add(add);
                }
            }
            rpHoaDonPT.LocalReport.ReportPath = "rptHoaDonPhatTien.rdlc";
            var sc = new ReportDataSource("DataSet1", listReport);
            rpHoaDonPT.LocalReport.DataSources.Clear();
            rpHoaDonPT.LocalReport.DataSources.Add(sc);
            this.rpHoaDonPT.RefreshReport(); 
        }
    }
}
