using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSoQLTX.Entities
{
    [Table("KHACHHANG")]
    public class KhachHang
    {
        [Key]
        [StringLength(20)]
        public string MaKH { get; set; }

        [StringLength(250)]
        public string TenKH { get; set; }
        [StringLength(250)]
        public string DiaChi { get; set; }
        [StringLength(11)]
        public string SDT { get; set; }
        public string GPLX { get; set; }
        public bool isDeleted { get; set; }

    }
}
