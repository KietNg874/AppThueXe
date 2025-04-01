using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    [Table("XEHONG")]
    public class XeHong
    {

         [Key]
         public int MaXeHong { get; set; }
         public string  BienXeHong { get; set; }
         public string TenXeHong { get; set; }
         public string LyDoHong { get; set; }
         public string SuaCaiGi { get; set; }
         public decimal TienSua { get; set; }
        public DateTime NgaySua { get; set; }
        public bool isDeleted { get; set; }
    }
}
