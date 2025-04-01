using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCOSO.Entities
{
    class HoaDonPhatReport
    {
        public int MaCTPhat { get; set; }
        public int MaNV { get; set; } 
        public string BienSo { get; set; }
        public string TenXe { get; set; }
        public string LoaiXe { get; set; }
        public string NoiDung { get; set; }
        public decimal TienThuSua { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
