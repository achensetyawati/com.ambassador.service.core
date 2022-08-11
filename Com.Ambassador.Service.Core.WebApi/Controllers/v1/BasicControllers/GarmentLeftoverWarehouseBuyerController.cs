using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Helpers.IdentityService;
using Com.Ambassador.Service.Core.Lib.Helpers.ValidateService;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseBuyer;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.WebApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-leftover-warehouse-buyers")]
    [Authorize]
    public class GarmentLeftoverWarehouseBuyerController : BaseController<GarmentLeftoverWarehouseBuyerModel, GarmentLeftoverWarehouseBuyerViewModel, IGarmentLeftoverWarehouseBuyerService>
    {
        public GarmentLeftoverWarehouseBuyerController(IIdentityService identityService, IValidateService validateService, IGarmentLeftoverWarehouseBuyerService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {
        }
    }
}
