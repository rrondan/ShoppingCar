namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musica2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Cart",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(unicode: false),
                        AlbumId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.RecordId)                
                .ForeignKey("Album", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "OrderDetail",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailId)                
                .ForeignKey("Album", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Username = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        City = c.String(unicode: false),
                        State = c.String(unicode: false),
                        PostalCode = c.String(unicode: false),
                        Country = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.OrderId)                ;
            
        }
        
        public override void Down()
        {
            DropForeignKey("OrderDetail", "OrderId", "Order");
            DropForeignKey("OrderDetail", "AlbumId", "Album");
            DropForeignKey("Cart", "AlbumId", "Album");
            DropIndex("OrderDetail", new[] { "AlbumId" });
            DropIndex("OrderDetail", new[] { "OrderId" });
            DropIndex("Cart", new[] { "AlbumId" });
            DropTable("Order");
            DropTable("OrderDetail");
            DropTable("Cart");
        }
    }
}
