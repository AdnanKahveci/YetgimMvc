using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Contexts;

public class BaseDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString: "Server=DESKTOP-JH4RF0R\\SQLEXPRESS;Initial Catalog=ECommerceDB;Integrated Security=True;TrustServerCertificate=True;");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
}