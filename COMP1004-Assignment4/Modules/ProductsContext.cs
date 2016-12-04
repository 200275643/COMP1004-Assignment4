namespace COMP1004_Assignment4.Modules
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsConnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
