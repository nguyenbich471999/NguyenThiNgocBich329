namespace NguyenThiNgocBich329.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable_loaissp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NTNBSanPhan329",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap329", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NTNBSanPhan329", "MaNhaCungCap", "dbo.NhaCungCap329");
            DropIndex("dbo.NTNBSanPhan329", new[] { "MaNhaCungCap" });
            DropTable("dbo.NTNBSanPhan329");
        }
    }
}
