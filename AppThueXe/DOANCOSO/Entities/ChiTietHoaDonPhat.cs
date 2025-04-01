using DoAnCoSoQLTX.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    [Table("CHITIETHOADONPHAT")]
    public class ChiTietHoaDonPhat
    {
        [Key]

        public int MaCTHoaDonPhat { get; set; }

        public int MaHoaDonPhat { get; set; }
        [ForeignKey("MaHoaDonPhat")]

        public virtual HoaDonPhat MaHoaDonPhat_FK { get; set; }
        //
        [StringLength(20)]
        public string BienSo { get; set; }
        [ForeignKey("BienSo")]
        public virtual Xe BienSo_FK { get; set; }

        public int MaCTPP { get; set; }
        [ForeignKey("MaCTPP")]
        public virtual ChiTietPhieuPhat MaCTPP_FK { get; set; }

        public decimal TienChiTiet { get; set; }
    }
}
