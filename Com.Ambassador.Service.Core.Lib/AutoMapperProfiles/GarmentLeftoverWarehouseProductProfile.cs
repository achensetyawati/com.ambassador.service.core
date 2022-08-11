using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentLeftoverWarehouseProductProfile : Profile
    {
        public GarmentLeftoverWarehouseProductProfile()
        {
            CreateMap<GarmentLeftoverWarehouseProductModel, GarmentLeftoverWarehouseProductViewModel>()
                .ReverseMap();
        }
    }
}
