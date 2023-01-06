using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.DataAccess.DbContexts;
using OnlineMarket.DataAccess.Interfaces;
using OnlineMarket.DataAccess.Repositories;

namespace OnlineMarket.Api.Configurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
