using Database.Learning.DbModels;
using Microsoft.EntityFrameworkCore;

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
    }
}
