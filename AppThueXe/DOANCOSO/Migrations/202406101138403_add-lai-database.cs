namespace DOANCOSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlaidatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHITIETHOADON",
                c => new
                    {
                        MaCTHoaDon = c.Int(nullable: false, identity: true),
                        MaHoaDon = c.Int(nullable: false),
                        BienSo = c.String(maxLength: 128),
                        TenXeCT = c.String(),
                        MaHD = c.Int(nullable: false),
                        TienChiTiet = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaCTHoaDon)
                .ForeignKey("dbo.XE", t => t.BienSo)
                .ForeignKey("dbo.HOPDONG", t => t.MaHD, cascadeDelete: true)
                .ForeignKey("dbo.HOADON", t => t.MaHoaDon, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.BienSo)
                .Index(t => t.MaHD);
            
            CreateTable(
                "dbo.XE",
                c => new
                    {
                        BienSo = c.String(nullable: false, maxLength: 128),
                        MaLoaiXe = c.String(nullable: false, maxLength: 20),
                        TenXe = c.String(),
                        GiaXe = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        ImgXe = c.String(),
                        GiaThue = c.Long(nullable: false),
                        HuHong = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BienSo)
                .ForeignKey("dbo.LOAIXE", t => t.MaLoaiXe, cascadeDelete: true)
                .Index(t => t.MaLoaiXe);
            
            CreateTable(
                "dbo.LOAIXE",
                c => new
                    {
                        MaLoaiXe = c.String(nullable: false, maxLength: 20),
                        TenLoaiXe = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.MaLoaiXe);
            
            CreateTable(
                "dbo.HOPDONG",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        NoiDung = c.String(nullable: false, maxLength: 2000),
                        SdtKH = c.String(),
                        TrangThaiBanDau = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        NgayLapHopDong = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.HOADON",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        MaKH = c.String(maxLength: 20),
                        nvThanhToan = c.String(),
                        NgayThanhToan = c.DateTime(nullable: false),
                        TongTienHoaDon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.KHACHHANG",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 20),
                        TenKH = c.String(maxLength: 250),
                        DiaChi = c.String(maxLength: 250),
                        SDT = c.String(maxLength: 11),
                        GPLX = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.CHITIETHOADONPHAT",
                c => new
                    {
                        MaCTHoaDonPhat = c.Int(nullable: false, identity: true),
                        MaHoaDonPhat = c.Int(nullable: false),
                        BienSo = c.String(maxLength: 128),
                        MaCTPP = c.Int(nullable: false),
                        TienChiTiet = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaCTHoaDonPhat)
                .ForeignKey("dbo.XE", t => t.BienSo)
                .ForeignKey("dbo.CHITIETPHIEUPHAT", t => t.MaCTPP, cascadeDelete: true)
                .ForeignKey("dbo.HOADONPHAT", t => t.MaHoaDonPhat, cascadeDelete: true)
                .Index(t => t.MaHoaDonPhat)
                .Index(t => t.BienSo)
                .Index(t => t.MaCTPP);
            
            CreateTable(
                "dbo.CHITIETPHIEUPHAT",
                c => new
                    {
                        MaCTPP = c.Int(nullable: false, identity: true),
                        MaKH = c.String(maxLength: 20),
                        MaPhieu = c.Int(nullable: false),
                        BienSo = c.String(maxLength: 128),
                        MaNV = c.Int(nullable: false),
                        NoiDungCT = c.String(),
                        TienPhat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TongTienPhat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaCTPP)
                .ForeignKey("dbo.XE", t => t.BienSo)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV, cascadeDelete: true)
                .ForeignKey("dbo.PHIEUPHAT", t => t.MaPhieu, cascadeDelete: true)
                .Index(t => t.MaKH)
                .Index(t => t.MaPhieu)
                .Index(t => t.BienSo)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        TenDangNhap = c.String(nullable: false, maxLength: 20),
                        TenNV = c.String(),
                        SDT = c.String(),
                        ChucVu = c.String(),
                        MatKhau = c.String(),
                        DiaChi = c.String(),
                        Luongcb = c.Long(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.PHIEUPHAT",
                c => new
                    {
                        MaPhieu = c.Int(nullable: false, identity: true),
                        MaKH = c.String(maxLength: 20),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieu)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.HOADONPHAT",
                c => new
                    {
                        MaHoaDonPhat = c.Int(nullable: false, identity: true),
                        MaKH = c.String(maxLength: 20),
                        nvThanhToan = c.String(),
                        NgayLapPhieu = c.DateTime(nullable: false),
                        TongTienPhat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDonPhat)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.CTHOPDONG",
                c => new
                    {
                        MaCTHD = c.Int(nullable: false, identity: true),
                        MaHD = c.Int(nullable: false),
                        BienSo = c.String(maxLength: 128),
                        MaKH = c.String(maxLength: 20),
                        MaNV = c.Int(nullable: false),
                        TienCoc = c.Long(nullable: false),
                        TienThue = c.Long(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaCTHD)
                .ForeignKey("dbo.XE", t => t.BienSo)
                .ForeignKey("dbo.HOPDONG", t => t.MaHD, cascadeDelete: true)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV, cascadeDelete: true)
                .Index(t => t.MaHD)
                .Index(t => t.BienSo)
                .Index(t => t.MaKH)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.DOANHTHU",
                c => new
                    {
                        MaDoanhThu = c.Int(nullable: false, identity: true),
                        TongTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ngay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaDoanhThu);
            
            CreateTable(
                "dbo.PHIEUNHANXE",
                c => new
                    {
                        MaPhieuNX = c.String(nullable: false, maxLength: 20),
                        BienSo = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(nullable: false, maxLength: 20),
                        MaNV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNX)
                .ForeignKey("dbo.XE", t => t.BienSo, cascadeDelete: true)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH, cascadeDelete: true)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV, cascadeDelete: true)
                .Index(t => t.BienSo)
                .Index(t => t.MaKH)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.XEHONG",
                c => new
                    {
                        MaXeHong = c.Int(nullable: false, identity: true),
                        BienXeHong = c.String(),
                        TenXeHong = c.String(),
                        LyDoHong = c.String(),
                        SuaCaiGi = c.String(),
                        TienSua = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NgaySua = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaXeHong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHIEUNHANXE", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.PHIEUNHANXE", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.PHIEUNHANXE", "BienSo", "dbo.XE");
            DropForeignKey("dbo.CTHOPDONG", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.CTHOPDONG", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.CTHOPDONG", "MaHD", "dbo.HOPDONG");
            DropForeignKey("dbo.CTHOPDONG", "BienSo", "dbo.XE");
            DropForeignKey("dbo.CHITIETHOADONPHAT", "MaHoaDonPhat", "dbo.HOADONPHAT");
            DropForeignKey("dbo.HOADONPHAT", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.CHITIETHOADONPHAT", "MaCTPP", "dbo.CHITIETPHIEUPHAT");
            DropForeignKey("dbo.CHITIETPHIEUPHAT", "MaPhieu", "dbo.PHIEUPHAT");
            DropForeignKey("dbo.PHIEUPHAT", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.CHITIETPHIEUPHAT", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.CHITIETPHIEUPHAT", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.CHITIETPHIEUPHAT", "BienSo", "dbo.XE");
            DropForeignKey("dbo.CHITIETHOADONPHAT", "BienSo", "dbo.XE");
            DropForeignKey("dbo.CHITIETHOADON", "MaHoaDon", "dbo.HOADON");
            DropForeignKey("dbo.HOADON", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.CHITIETHOADON", "MaHD", "dbo.HOPDONG");
            DropForeignKey("dbo.CHITIETHOADON", "BienSo", "dbo.XE");
            DropForeignKey("dbo.XE", "MaLoaiXe", "dbo.LOAIXE");
            DropIndex("dbo.PHIEUNHANXE", new[] { "MaNV" });
            DropIndex("dbo.PHIEUNHANXE", new[] { "MaKH" });
            DropIndex("dbo.PHIEUNHANXE", new[] { "BienSo" });
            DropIndex("dbo.CTHOPDONG", new[] { "MaNV" });
            DropIndex("dbo.CTHOPDONG", new[] { "MaKH" });
            DropIndex("dbo.CTHOPDONG", new[] { "BienSo" });
            DropIndex("dbo.CTHOPDONG", new[] { "MaHD" });
            DropIndex("dbo.HOADONPHAT", new[] { "MaKH" });
            DropIndex("dbo.PHIEUPHAT", new[] { "MaKH" });
            DropIndex("dbo.CHITIETPHIEUPHAT", new[] { "MaNV" });
            DropIndex("dbo.CHITIETPHIEUPHAT", new[] { "BienSo" });
            DropIndex("dbo.CHITIETPHIEUPHAT", new[] { "MaPhieu" });
            DropIndex("dbo.CHITIETPHIEUPHAT", new[] { "MaKH" });
            DropIndex("dbo.CHITIETHOADONPHAT", new[] { "MaCTPP" });
            DropIndex("dbo.CHITIETHOADONPHAT", new[] { "BienSo" });
            DropIndex("dbo.CHITIETHOADONPHAT", new[] { "MaHoaDonPhat" });
            DropIndex("dbo.HOADON", new[] { "MaKH" });
            DropIndex("dbo.XE", new[] { "MaLoaiXe" });
            DropIndex("dbo.CHITIETHOADON", new[] { "MaHD" });
            DropIndex("dbo.CHITIETHOADON", new[] { "BienSo" });
            DropIndex("dbo.CHITIETHOADON", new[] { "MaHoaDon" });
            DropTable("dbo.XEHONG");
            DropTable("dbo.PHIEUNHANXE");
            DropTable("dbo.DOANHTHU");
            DropTable("dbo.CTHOPDONG");
            DropTable("dbo.HOADONPHAT");
            DropTable("dbo.PHIEUPHAT");
            DropTable("dbo.NHANVIEN");
            DropTable("dbo.CHITIETPHIEUPHAT");
            DropTable("dbo.CHITIETHOADONPHAT");
            DropTable("dbo.KHACHHANG");
            DropTable("dbo.HOADON");
            DropTable("dbo.HOPDONG");
            DropTable("dbo.LOAIXE");
            DropTable("dbo.XE");
            DropTable("dbo.CHITIETHOADON");
        }
    }
}
