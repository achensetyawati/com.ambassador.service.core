using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Core.WebApi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseComodity;
using Com.Ambassador.Service.Core.Lib.Helpers.IdentityService;
using Com.Ambassador.Service.Core.Lib.Helpers.ValidateService;
using AutoMapper;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-leftover-warehouse-comodities")]
    [Authorize]
    public class GarmentLeftoverWarehouseComodityController : BaseController<GarmentLeftoverWarehouseComodityModel, GarmentLeftoverWarehouseComodityViewModel, IGarmentLeftoverWarehouseComodityService>
    {
        public GarmentLeftoverWarehouseComodityController(IIdentityService identityService, IValidateService validateService, IGarmentLeftoverWarehouseComodityService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {
        }
    }
}
