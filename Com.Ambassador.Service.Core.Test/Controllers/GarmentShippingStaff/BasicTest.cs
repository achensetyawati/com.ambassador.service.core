using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentShippingStaff;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentShippingStaff
{
    public class BasicTest : BaseControllerTest<GarmentShippingStaffController, GarmentShippingStaffModel, GarmentShippingStaffViewModel, IGarmentShippingStaffService>
    {
        public BasicTest()
        {
        }
    }
}
