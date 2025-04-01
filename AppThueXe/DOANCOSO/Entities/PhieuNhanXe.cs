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
    [Table("PHIEUNHANXE")]

    public class PhieuNhanXe
    {
        [Key]
        [StringLength(20)]
        public string MaPhieuNX { get; set; }
        //

        [Required]
        [StringLength(20)]
        public string BienSo { get; set; }
        [ForeignKey("BienSo")]
        public virtual Xe BienSo_FK { get; set; }
        //
        [Required]
        [StringLength(20)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang MaKH_FK { get; set; }
        //
        public int MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien MaNV_FK { get; set; }
        
    }
}
