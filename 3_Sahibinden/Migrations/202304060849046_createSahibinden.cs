namespace _3_Sahibinden.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSahibinden : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarAdverts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Km = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarAdverts", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.CarAdverts", "BrandId", "dbo.Brands");
            DropIndex("dbo.CarAdverts", new[] { "ColorId" });
            DropIndex("dbo.CarAdverts", new[] { "BrandId" });
            DropTable("dbo.Colors");
            DropTable("dbo.CarAdverts");
            DropTable("dbo.Brands");
        }
    }
}
