using HotelManagement.Core.CQRS.Queries;
using MediatR;
using System.Reflection;

namespace Hotel_Management_API.Extensions
{
    public static class CQRSHandlersConfiguration
    {
        public static void RegisterCQRSHandlers(this IServiceCollection services)
        {
            var queryAssembly = typeof(GetRoomByIdQuery).GetTypeInfo().Assembly;
            services.AddMediatR(queryAssembly);
        }
    }
}
