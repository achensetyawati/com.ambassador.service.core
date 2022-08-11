using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentAdditionalChargesProfile : Profile
    {
        public GarmentAdditionalChargesProfile()
        {
            CreateMap<GarmentAdditionalChargesModel, GarmentAdditionalChargesViewModel>()
                .ReverseMap();
        }
    }
}
