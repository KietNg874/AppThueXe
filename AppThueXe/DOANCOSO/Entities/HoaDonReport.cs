using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    class HoaDonReport
    {
     
        public int MaCTHoaDon { get; set; }
    
        public string BienSo { get; set; }
        public string TenXe { get; set; }
        public string LoaiXe { get; set; }
        public decimal TienThu { get; set; }
        public DateTime NgayThanhToan { get; set; }
    }
}
