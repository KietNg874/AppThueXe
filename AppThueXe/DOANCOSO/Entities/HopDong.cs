using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSoQLTX.Entities
{
    [Table("HOPDONG")]
    public class HopDong
    {
        [Key]
        public int MaHD { get; set; }
        [Required]
        [StringLength(2000)]
        public string NoiDung { get; set; }
      public string SdtKH { get; set; }
        public string TrangThaiBanDau { get; set; }
        public bool isDeleted { get; set; }
        public DateTime NgayLapHopDong { get; set; }
    }
}
