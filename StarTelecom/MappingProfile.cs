using AutoMapper;
using Entities;
using Shared.AuthenticationDtos;
using Shared.ResponseDtos;

namespace StarTelecom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Device, DeviceResponseDto>();
            CreateMap<PhonePlan, PhonePlanResponseDto>();
            CreateMap<UserRegistrationDto, User>();
            CreateMap<User, UserResponseDto>();
            CreateMap<UserPlan, UserPlanResponseDto>();
            CreateMap<Billing, BillingResponseDto>();
            CreateMap<UserDevice, UserDeviceResponseDto>();
        }
    }
}
