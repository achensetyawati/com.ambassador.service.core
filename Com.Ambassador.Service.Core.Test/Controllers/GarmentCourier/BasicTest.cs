using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentCourier;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentCourier
{
    public class BasicTest : BaseControllerTest<GarmentCourierController, GarmentCourierModel, GarmentCourierViewModel, IGarmentCourierService>
    {
        public BasicTest()
        {
        }
    }
}
