namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musica3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Order", "FirstName", c => c.String(nullable: false, maxLength: 160, storeType: "nvarchar"));
            AlterColumn("Order", "LastName", c => c.String(nullable: false, maxLength: 160, storeType: "nvarchar"));
            AlterColumn("Order", "Address", c => c.String(nullable: false, maxLength: 70, storeType: "nvarchar"));
            AlterColumn("Order", "City", c => c.String(nullable: false, maxLength: 40, storeType: "nvarchar"));
            AlterColumn("Order", "State", c => c.String(nullable: false, maxLength: 40, storeType: "nvarchar"));
            AlterColumn("Order", "PostalCode", c => c.String(nullable: false, maxLength: 10, storeType: "nvarchar"));
            AlterColumn("Order", "Country", c => c.String(nullable: false, maxLength: 40, storeType: "nvarchar"));
            AlterColumn("Order", "Phone", c => c.String(nullable: false, maxLength: 24, storeType: "nvarchar"));
            AlterColumn("Order", "Email", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("Order", "Email", c => c.String(unicode: false));
            AlterColumn("Order", "Phone", c => c.String(unicode: false));
            AlterColumn("Order", "Country", c => c.String(unicode: false));
            AlterColumn("Order", "PostalCode", c => c.String(unicode: false));
            AlterColumn("Order", "State", c => c.String(unicode: false));
            AlterColumn("Order", "City", c => c.String(unicode: false));
            AlterColumn("Order", "Address", c => c.String(unicode: false));
            AlterColumn("Order", "LastName", c => c.String(unicode: false));
            AlterColumn("Order", "FirstName", c => c.String(unicode: false));
        }
    }
}
