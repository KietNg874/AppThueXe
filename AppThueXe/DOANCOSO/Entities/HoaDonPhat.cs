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
    [Table("HOADONPHAT")]
    public class HoaDonPhat
    {
        [Key]
        public int MaHoaDonPhat { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang MaKH_FK { get; set; }
        //
        public string nvThanhToan { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public decimal TongTienPhat { get; set; }
        public bool isDeleted { get; set; }
    }
}
