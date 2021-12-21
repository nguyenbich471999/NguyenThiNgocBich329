namespace NguyenThiNgocBich329.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_ncc_nguyenthingocbich0329 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap329",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCap329");
        }
    }
}
