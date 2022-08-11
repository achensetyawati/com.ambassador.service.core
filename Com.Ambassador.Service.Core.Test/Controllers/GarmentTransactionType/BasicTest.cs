using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentTransactionType;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentTransactionType
{
    public class BasicTest : BaseControllerTest<GarmentTransactionTypeController, GarmentTransactionTypeModel, GarmentTransactionTypeViewModel, IGarmentTransactionTypeService>
    {
        public BasicTest()
        {
        }
    }
}
