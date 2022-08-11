using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentInsuranceProfile : Profile
    {
        public GarmentInsuranceProfile()
        {
            CreateMap<GarmentInsuranceModel, GarmentInsuranceViewModel>()
                .ReverseMap();
        }
    }
}
