using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentForwarderProfile : Profile
    {
        public GarmentForwarderProfile()
        {
            CreateMap<GarmentForwarderModel, GarmentForwarderViewModel>()
                .ReverseMap();
        }
    }
}
