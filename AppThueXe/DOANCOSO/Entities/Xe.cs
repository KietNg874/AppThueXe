using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSoQLTX.Entities
{
    [Table("XE")]

    public class Xe
    {
        /* [Key]
        [Column(Order = 0)]
        [StringLength(20)]

        public string MaCa { get; set; }
        public virtual CaLamViec MaCa_FK { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(20)]*/

        [Key]
  
        public string BienSo { get; set; }
        [Required]
        public string MaLoaiXe { get; set; }
        [ForeignKey("MaLoaiXe")]
        public virtual LoaiXe MaLoaiXe_FK { get; set; }
        public string TenXe { get; set; }
        [Required]
        public int GiaXe { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public string ImgXe { get; set; }
        public long GiaThue { get; set; }
        public string HuHong { get; set; }
        public bool isDeleted { get; set; }
    }
}
