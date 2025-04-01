using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSoQLTX.Entities
{
    [Table("LOAIXE")]

    public class LoaiXe
    {
        [Key]
        [StringLength(20)]
        public string MaLoaiXe { get; set; }
        [Required]
        [StringLength(250)]
        public string TenLoaiXe { get; set; }
        
    }
}
