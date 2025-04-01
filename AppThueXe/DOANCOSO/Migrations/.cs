namespace DOANCOSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themclv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CALAMVIEC",
                c => new
                    {
                        MaCa = c.Int(nullable: false, identity: true),
                        TenCa = c.String(),
                        MaNV = c.Int(nullable: false),
                        SDT = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaCa)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV, cascadeDelete: true)
                .Index(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CALAMVIEC", "MaNV", "dbo.NHANVIEN");
            DropIndex("dbo.CALAMVIEC", new[] { "MaNV" });
            DropTable("dbo.CALAMVIEC");
        }
    }
}
