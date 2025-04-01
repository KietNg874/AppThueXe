using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    [Table("DOANHTHU")]
   public class DoanhThu
    {
        [Key]
        public int MaDoanhThu { get; set; }

        public decimal TongTien { get; set; }

        public DateTime Ngay { get; set; }
    }
}
