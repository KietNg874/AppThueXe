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
    [Table("CHITIETHOADON")]

    public class ChiTietHoaDon
    {
        [Key]

        public int MaCTHoaDon { get; set; }

        public int MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]

        public virtual HoaDon MaHoaDon_FK { get; set; }
        //
        [StringLength(20)]
        public string BienSo { get; set; }
        [ForeignKey("BienSo")]
        public virtual Xe BienSo_FK { get; set; }
        public string TenXeCT { get; set; }
        //public int MaCTHD { get; set; }
        //[ForeignKey("MaCTHD")]
        //public virtual ChiTietHopDong MaCTHD_FK { get; set; }
        public int MaHD { get; set; }
        [ForeignKey("MaHD")]
        public virtual HopDong MaHD_FK { get; set; }
        public decimal TienChiTiet { get; set; }

    }
}
