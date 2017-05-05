namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerCambio : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "Items", newName: "Item");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            AlterColumn("dbo.AspNetRoles", "Name", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false, maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.AspNetRoles", "Name", c => c.String(nullable: false, maxLength: 256, storeType: "nvarchar"));
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            RenameTable(name: "Item", newName: "Items");
        }
    }
}
