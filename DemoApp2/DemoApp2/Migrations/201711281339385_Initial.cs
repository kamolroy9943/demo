namespace DemoApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CatagoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Catagory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Catagory_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Catagories", t => t.Catagory_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Catagory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductCatagories", "Catagory_Id", "dbo.Catagories");
            DropForeignKey("dbo.ProductCatagories", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductCatagories", new[] { "Catagory_Id" });
            DropIndex("dbo.ProductCatagories", new[] { "Product_Id" });
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.Products");
            DropTable("dbo.Catagories");
        }
    }
}
