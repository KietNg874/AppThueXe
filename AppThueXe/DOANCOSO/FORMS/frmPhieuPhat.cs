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

namespace DOANCOSO.FORMS
{
    public partial class frmPhieuPhat : Form
    {
        public frmPhieuPhat()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        public static string xemct;
        private void frmXeHu_Load(object sender, EventArgs e)
        {
            List<PhieuPhat> pp = context.PhieuPhat.Where(s => s.isDeleted == false).ToList();

            filldgvXeHong(pp);
        }
        private void filldgvXeHong(List<PhieuPhat> listPhieuPhat)
        {
            dgvXeHong.Rows.Clear();

            foreach (var item in listPhieuPhat)
            {
                int index = dgvXeHong.Rows.Add();

                dgvXeHong.Rows[index].Cells[0].Value = item.MaPhieu;

                dgvXeHong.Rows[index].Cells[1].Value = item.MaKH_FK.TenKH;


            }
        }

        private void dgvXeHong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvXeHong.CurrentCell.RowIndex;
            if (dgvXeHong.CurrentCell == null || dgvXeHong.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            if (index >= 0)
            {
                Xe xehong = new Xe();
                var dongChon = dgvXeHong.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string maphieu = dongChon.Cells[0].Value.ToString();
                txtBienSo.Text = maphieu;
                xemct = txtBienSo.Text;
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Phiếu phạt");
            }
            else
            {
                frmMeNu3 menuForm = (frmMeNu3)this.ParentForm;
                menuForm.XemCTPPForm();
            }
        }
    }
}
    

