using Microsoft.EntityFrameworkCore;
using RetailApp.Entities;

namespace RetailApp.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base (dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone>  Phones { get; set; }
        public DbSet<SupplierAdress> SupplierAdresses { get; set; }
        public DbSet<SupplierPhone> SupplierPhones { get; set;}
    }
}
