using HotelManagement.Models.DTOs;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetAllRoomsQuery : IRequest<IEnumerable<GetAllRoomsDTO>>
    {
    }
}
