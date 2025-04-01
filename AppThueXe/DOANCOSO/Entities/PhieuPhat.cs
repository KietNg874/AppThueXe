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
    [Table("PHIEUPHAT")]

    public class PhieuPhat
    {
        [Key]
        public int MaPhieu { get; set; }
        [StringLength(20)]    
       
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang MaKH_FK { get; set; }
      //  public DateTime NgayPhat { get; set; }
        public bool isDeleted { get; set; }
    }
}
