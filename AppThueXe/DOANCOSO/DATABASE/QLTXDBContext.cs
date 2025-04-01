using DOANCOSO.Entities;
using DoAnCoSoQLTX.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DOANCOSO.DATABASE
{
    public class QLTXDBContext : DbContext
    {
        // Your context has been configured to use a 'QLTXDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DOANCOSO.DATABASE.QLTXDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLTXDBContext' 
        // connection string in the application configuration file.
        public QLTXDBContext()
            : base("name=QLTXDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Xe> Xe { get; set; }
        public virtual DbSet<LoaiXe> LoaiXe { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<ChiTietHopDong> ChiTietHopDong { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<PhieuNhanXe> PhieuNhanXe { get; set; }
       
        public virtual DbSet<PhieuPhat> PhieuPhat { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<ChiTietPhieuPhat> ChiTietPhieuPhat { get; set; }
        public virtual DbSet<HoaDonPhat> HoaDonPhat { get; set; }
        public virtual DbSet<ChiTietHoaDonPhat> ChiTietHoaDonPhat { get; set; }
        public virtual DbSet<XeHong> XeHong { get; set; }
        public virtual DbSet<DoanhThu> DoanhThu { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}