using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Helpers.IdentityService;
using Com.Ambassador.Service.Core.Lib.Helpers.ValidateService;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentInsurance; 
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.WebApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-insurances")]
    [Authorize]
    public class GarmentInsuranceController : BaseController<GarmentInsuranceModel, GarmentInsuranceViewModel, IGarmentInsuranceService>
    {
        public GarmentInsuranceController(IIdentityService identityService, IValidateService validateService, IGarmentInsuranceService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {
        }
    }
}
