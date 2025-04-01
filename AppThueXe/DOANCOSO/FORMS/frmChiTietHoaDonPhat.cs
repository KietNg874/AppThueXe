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
    public partial class frmChiTietHoaDonPhat : Form
    {
        QLTXDBContext context = new QLTXDBContext();
        public frmChiTietHoaDonPhat()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }

        private void frmChiTietHoaDonPhat_Load(object sender, EventArgs e)
        {
            List<ChiTietHoaDonPhat> ChiTiet = context.ChiTietHoaDonPhat.ToList();
            fillDGVChiTietHoaDon(ChiTiet);
        }
        private void fillDGVChiTietHoaDon(List<ChiTietHoaDonPhat> listCTHoaDon)
        {
            dgvHoaDonPhat.Rows.Clear();
            decimal tongtien = 0;
            foreach (var item in listCTHoaDon)
            {
                if (item.MaHoaDonPhat_FK.MaHoaDonPhat == frmHoaDonPhieuPhat.MaXemHoaDonPhat)
                {

                    int index = dgvHoaDonPhat.Rows.Add();
                    dgvHoaDonPhat.Rows[index].Cells[0].Value = item.BienSo;
                    dgvHoaDonPhat.Rows[index].Cells[1].Value = item.BienSo_FK.TenXe;
                    dgvHoaDonPhat.Rows[index].Cells[2].Value = item.BienSo_FK.MaLoaiXe_FK.TenLoaiXe;
                    dgvHoaDonPhat.Rows[index].Cells[3].Value = item.TienChiTiet;
                    tongtien += item.TienChiTiet;
                    txtTongTien.Text = tongtien.ToString();

                }
            }
        }
    }
}
