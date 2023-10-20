using Microsoft.EntityFrameworkCore;
using Task.DataAccess.DbContexts;
using Task.DataAccess.Interfaces;
using Task.DataAccess.Repositories;
using Task.Domain.Entities.Products;
using Task.Service.Interfaces.Warehouses;
using Task.Service.Services.Warehouses;

namespace Task.WebApi.Configurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            var config = builder;
            string connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionStrings")!;
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IWarehouseProductDetailService , WarehousesProductDetailService>();
        }
    }
}
