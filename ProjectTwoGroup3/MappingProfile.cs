using Shared.ResponseDtos;
using AutoMapper;
using Entities;

namespace ProjectTwoGroup3
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Device, DeviceDto>();
        }
    }
}
