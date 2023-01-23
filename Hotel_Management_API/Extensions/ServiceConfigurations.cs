using HotelManagement.Services.ServiceInterfaces;
using HotelManagement.Services.Services;

namespace Hotel_Management_API.Extensions
{
    public static class ServiceConfigurations
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IReservationService, ReservationService>();
        }
    }
}
