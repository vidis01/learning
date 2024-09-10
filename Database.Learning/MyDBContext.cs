using Database.Learning.DbModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Database.Learning
{
    public class MyDBContext : DbContext
    {
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-0B6P97H\SQLEXPRESS;Database=MyTestDB;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipper>().HasData(new Shipper { ShipperName = "Speedy Express", Phone = "(503) 555-9831" });
            modelBuilder.Entity<Shipper>().HasData(new Shipper { ShipperName = "United Package", Phone = "(503) 555-3199" });
            modelBuilder.Entity<Shipper>().HasData(new Shipper { ShipperName = "Federal Shipping", Phone = "(503) 555-9931" });
        }
    }
}
