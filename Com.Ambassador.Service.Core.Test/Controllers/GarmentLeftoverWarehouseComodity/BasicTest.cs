using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseComodity;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Utils;
using Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Core.Test.Controllers.GarmentLeftoverWarehouseComodity
{
    public class BasicTest : BaseControllerTest<GarmentLeftoverWarehouseComodityController, GarmentLeftoverWarehouseComodityModel, GarmentLeftoverWarehouseComodityViewModel, IGarmentLeftoverWarehouseComodityService>
    {
        public BasicTest()
        {
        }
    }
}
