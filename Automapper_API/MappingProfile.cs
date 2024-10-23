using AutoMapper;
using Automapper_API.Models;

namespace Automapper_API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarRequest, Car>();
        }
    }
}
