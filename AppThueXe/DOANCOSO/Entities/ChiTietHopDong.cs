using DOANCOSO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSoQLTX.Entities
{
    [Table("CTHOPDONG")]
    public class ChiTietHopDong
    {
        [Key]
     
        public int MaCTHD { get; set; }
    
        public int MaHD { get; set; }
        [ForeignKey("MaHD")]

        public virtual HopDong MaHD_FK { get; set; }
        //
        [StringLength(20)]
        public string BienSo { get; set; }
        [ForeignKey("BienSo")]

        public virtual Xe BienSo_FK { get; set; }
        //
        [StringLength(20)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]

        public virtual KhachHang MaKH_FK { get; set; }
        //
        public int MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien MaNV_FK { get; set; }
        public long TienCoc { get; set; }
        public long TienThue { get; set; }
        public bool isDeleted { get; set; }
    }
}
