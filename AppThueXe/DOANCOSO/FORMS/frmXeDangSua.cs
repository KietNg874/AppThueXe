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
    public partial class frmXeDangSua : Form
    {
        public frmXeDangSua()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            this.Scale(new SizeF((float)1.3, (float)1.3));
        }
        QLTXDBContext context = new QLTXDBContext();
        private void frmXeDangSua_Load(object sender, EventArgs e)
        {
            List<XeHong> dsxehong = context.XeHong.Where(s=>s.isDeleted==true).ToList();
            filldgvXeDangSua(dsxehong);
        }
        private void filldgvXeDangSua(List<XeHong> listXeHong)
        {
            dgvXeDangSua.Rows.Clear();

            foreach (var item in listXeHong)
            {
                int index = dgvXeDangSua.Rows.Add();
                dgvXeDangSua.Rows[index].Cells[0].Value = item.BienXeHong;
                dgvXeDangSua.Rows[index].Cells[1].Value = item.TenXeHong;
                dgvXeDangSua.Rows[index].Cells[2].Value = item.LyDoHong;
            }
            dgvXeDangSua.Refresh();
        }

    
        private void dgvXeDangSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvXeDangSua.CurrentCell.RowIndex;
            if (dgvXeDangSua.CurrentCell == null || dgvXeDangSua.CurrentCell.Value == null || e.RowIndex == -1)
            {
                return;
            }
            var dongChon = dgvXeDangSua.Rows[index];
            if (index >= 0)
            {
                string bienso = dongChon.Cells[0].Value.ToString();
                string tenxe = dongChon.Cells[1].Value.ToString();
                txtBienSo.Text = bienso;
                txtTenXe.Text = tenxe;
            }
        }

      

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {

        }
        private void btnChuyenxe_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "" || txtTenXe.Text == "")
            {
                MessageBox.Show("Vui lòng chọn xe cần sửa");
            }
            else
            {
                // true la bị hỏng
                List<XeHong> dsxe = context.XeHong.Where(s => s.isDeleted == true).ToList();
                List<Xe> dsxebthg = context.Xe.ToList();
                foreach (var item in dsxe)
                {
                    foreach (var kt in dsxebthg)
                    {
                        if (item.BienXeHong == txtBienSo.Text && kt.BienSo == txtBienSo.Text)
                        {
                            if (txtTienPhat.Text == "")
                            {
                                MessageBox.Show("Nhập tiền sửa");
                                return;
                            }
                            item.TienSua = decimal.Parse(txtTienPhat.Text);
                            kt.TrangThai = false;
                            item.isDeleted = false;
                            item.NgaySua = DateTime.Now;
                            item.SuaCaiGi = rtbNDPhat.Text;
                            MessageBox.Show("sửa thành công");
                        }
                    }

                }
                context.SaveChanges();
                filldgvXeDangSua(dsxe);
            }
        }
    }
}
