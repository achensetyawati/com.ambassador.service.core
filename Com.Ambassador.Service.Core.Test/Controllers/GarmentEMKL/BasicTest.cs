using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentEMKL;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentEMKL
{
    public class BasicTest : BaseControllerTest<GarmentEMKLController, GarmentEMKLModel, GarmentEMKLViewModel, IGarmentEMKLService>
    {
        public BasicTest()
        {
        }
    }
}
