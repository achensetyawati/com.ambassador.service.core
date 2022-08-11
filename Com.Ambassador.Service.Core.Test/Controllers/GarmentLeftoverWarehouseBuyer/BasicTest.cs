using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseBuyer;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentLeftoverWarehouseBuyer
{
    public class BasicTest : BaseControllerTest<GarmentLeftoverWarehouseBuyerController, GarmentLeftoverWarehouseBuyerModel, GarmentLeftoverWarehouseBuyerViewModel, IGarmentLeftoverWarehouseBuyerService>
    {
        public BasicTest()
        {
        }
    }
}
