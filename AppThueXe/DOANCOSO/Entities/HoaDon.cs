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
    [Table("HOADON")]
    public  class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
    
        [StringLength(20)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang MaKH_FK { get; set; }
        //
        public string nvThanhToan { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTienHoaDon { get; set; }
        public bool isDeleted { get; set; }
    }
}
