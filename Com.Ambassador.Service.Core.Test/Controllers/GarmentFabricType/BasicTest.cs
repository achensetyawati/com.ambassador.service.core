using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentFabricType;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentFabricType
{
    public class BasicTest : BaseControllerTest<GarmentFabricTypeController, GarmentFabricTypeModel, GarmentFabricTypeViewModel, IGarmentFabricTypeService>
    {
        public BasicTest()
        {
        }
    }
}
