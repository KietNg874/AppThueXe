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
    [Table("CHITIETPHIEUPHAT")]
    public class ChiTietPhieuPhat
    {
        [Key]
        public int MaCTPP { get; set; }
   
        //
        [StringLength(20)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]

        public virtual KhachHang MaKH_FK { get; set; }
        public int MaPhieu { get; set; }
        [ForeignKey("MaPhieu")]
        public virtual PhieuPhat MaPhieu_FK { get; set; }
        public string BienSo { get; set; }
        public virtual Xe BienSo_FK { get; set; }
        //
        public int MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien MaNV_FK { get; set; }
    //    public DateTime NgayLap { get; set; }
        public string NoiDungCT { get; set; }
        public decimal TienPhat { get; set; }
        public decimal TongTienPhat { get; set; }
        public bool isDeleted { get; set; }
    }
}
