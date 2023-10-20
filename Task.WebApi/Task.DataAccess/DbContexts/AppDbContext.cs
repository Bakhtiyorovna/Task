using Microsoft.EntityFrameworkCore;
using Task.Domain.Entities.Categories;
using Task.Domain.Entities.Products;
using Task.Domain.Entities.Storages;

namespace Task.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }  
    public DbSet<WarehouseProductDetail> StorageProductDetails { get; set; }
}
