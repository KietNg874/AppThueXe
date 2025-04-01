using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    [Table("NHANVIEN")]
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        [Required]
        [StringLength(20)]
        public string TenDangNhap { get; set; }

        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public long Luongcb { get; set; }
        public bool isDeleted { get; set; }

    }
}
