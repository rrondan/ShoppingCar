namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("AspNetUsers", "HomeTown", c => c.String(unicode: false));
            AddColumn("AspNetUsers", "BirthDate", c => c.DateTime(precision: 0));
            AddColumn("AspNetUsers", "Street", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("AspNetUsers", "Street");
            DropColumn("AspNetUsers", "BirthDate");
            DropColumn("AspNetUsers", "HomeTown");
        }
    }
}
