using Shared.ResponseDtos;
using AutoMapper;
using Entities;
using Shared.CreationDtos;

namespace ProjectTwoGroup3
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Device, DeviceDto>();
            CreateMap<UserCreationDto, User>();
        }
    }
}
