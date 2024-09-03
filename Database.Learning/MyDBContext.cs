using Microsoft.EntityFrameworkCore;

namespace Database.Learning
{
    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-0B6P97H\SQLEXPRESS;Database=MyTestDB;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }
    }
}
