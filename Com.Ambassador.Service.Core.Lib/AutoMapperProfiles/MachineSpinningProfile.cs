using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class MachineSpinningProfile : Profile
    {
        public MachineSpinningProfile()
        {
            CreateMap<MachineSpinningModel, MachineSpinningViewModel>()
                .ReverseMap();
            CreateMap<MachineSpinningProcessType, MachineSpinningProcessTypeViewModel>()
                .ReverseMap();
        }
    }
}
