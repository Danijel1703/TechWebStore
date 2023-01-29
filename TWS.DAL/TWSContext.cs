using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using TWS.DAL.Entities;
using TWS.DAL.Migrations;
using TWS.Model;
using TWS.Model.Common;
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
            List<IManufacturer> manufacturerList = new List<IManufacturer>();
            Random rand = new Random();
            for(int i = 0; i < 30; i++)
            {
                Guid manufacturerId = Guid.NewGuid();
                var manufacturer = new Manufacturer { Id = manufacturerId, Name = $"Manufacturer {i}", Abrv = $"manufacturer-{i}" };
                manufacturerList.Append(manufacturer);
                modelBuilder.Entity<ManufacturerEntity>().HasData(manufacturer);
                for(int j = 0; j < 10; j++)
                {
                    var product = new Product { Id = Guid.NewGuid(), Name = $"Product {j} - Manufacturer {i}", Abrv = $"product-{j}", Description = "", Price = rand.Next(100, 3000), SKU = $"p{i + rand.Next(100, 1000)}", ManufacturerId = manufacturerId };
                    modelBuilder.Entity<ProductEntity>().HasData(product);
                }
            }
        }
    }
}