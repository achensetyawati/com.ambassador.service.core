using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentForwarder;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentForwarder
{
    public class BasicTest : BaseControllerTest<GarmentForwarderController, GarmentForwarderModel, GarmentForwarderViewModel, IGarmentForwarderService>
    {
        public BasicTest()
        {
        }
    }
}
