using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentInsurance;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentInsurance
{
    public class BasicTest : BaseControllerTest<GarmentInsuranceController, GarmentInsuranceModel, GarmentInsuranceViewModel, IGarmentInsuranceService>
    {
        public BasicTest()
        {
        }
    }
}
