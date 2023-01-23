using AutoMapper;
using HotelManagement.Domain.UnitOfWorkInterface;

namespace HotelManagement.Services.Services
{
    public class BaseService
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    }
}
