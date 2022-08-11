using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentFabricTypeProfile : Profile
    {
        public GarmentFabricTypeProfile()
        {
            CreateMap<GarmentFabricTypeModel, GarmentFabricTypeViewModel>()
                .ReverseMap();
        }
    }
}
