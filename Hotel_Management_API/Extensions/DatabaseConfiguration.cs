using HotelManagement.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_API.Extensions
{
    public static class DatabaseConfiguration
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelManagementDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HotelManagementConnStr"));
            });
        }
    }
}
