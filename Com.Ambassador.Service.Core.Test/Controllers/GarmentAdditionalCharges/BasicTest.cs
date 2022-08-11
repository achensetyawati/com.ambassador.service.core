using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentAdditionalCharges;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentAdditionalCharges
{
    public class BasicTest : BaseControllerTest<GarmentAdditionalChargesController, GarmentAdditionalChargesModel, GarmentAdditionalChargesViewModel, IGarmentAdditionalChargesService>
    {
        public BasicTest()
        {
        }
    }
}
