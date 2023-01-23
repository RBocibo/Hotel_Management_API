using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.Repositories;

namespace Hotel_Management_API.Extensions
{
    public static class RepositoryConfigurations
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRoomInterface, RoomRepository>();
        }
    }
}
