using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentShippingStaffProfile : Profile
    {
        public GarmentShippingStaffProfile()
        {
            CreateMap<GarmentShippingStaffModel, GarmentShippingStaffViewModel>()
                .ReverseMap();
        }
    }
}
