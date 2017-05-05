namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Album",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 160, storeType: "nvarchar"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AlbumArtUrl = c.String(maxLength: 1024, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.AlbumId)                
                .ForeignKey("Artist", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("Genre", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "Artist",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ArtistId)                ;
            
            CreateTable(
                "Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.GenreId)                ;
            
        }
        
        public override void Down()
        {
            DropForeignKey("Album", "GenreId", "Genre");
            DropForeignKey("Album", "ArtistId", "Artist");
            DropIndex("Album", new[] { "ArtistId" });
            DropIndex("Album", new[] { "GenreId" });
            DropTable("Genre");
            DropTable("Artist");
            DropTable("Album");
        }
    }
}
