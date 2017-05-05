namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models.Portal;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            CodeGenerator = new MySql.Data.Entity.MySqlMigrationCodeGenerator();
    
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {

            context.Item.AddOrUpdate(x => x.id
                , new Item { id = 1, stock = 10, nombre = "pc", descripcion = "des" }
                , new Item { id = 1, stock = 40, nombre = "as", descripcion = "dess" }
                , new Item { id = 1, stock = 15, nombre = "p3", descripcion = "dses" });
        }
    }
}
