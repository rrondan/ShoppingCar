namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using WebApplication1.Models.Portal;

    public partial class PortalModel : DbContext
    {
        public DbSet<Item> Item { get; set; } 
        public PortalModel()
            : base("name=PortalEntities")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
