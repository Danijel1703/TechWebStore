using Microsoft.EntityFrameworkCore;
using TWS.DAL.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TWS.DAL
{
    public class TWSContext : DbContext
    {
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<ManufacturerEntity> Manufacturer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .HasOne<ManufacturerEntity>()
                .WithMany(e => e.Products)
                .HasForeignKey("ManufacturerId").OnDelete(DeleteBehavior.Cascade);
        }
    }
}