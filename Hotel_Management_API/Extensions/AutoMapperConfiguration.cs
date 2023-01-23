using System.Reflection;

namespace Hotel_Management_API.Extensions
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load("HotelManagement.Models"));
        }
    }
}
