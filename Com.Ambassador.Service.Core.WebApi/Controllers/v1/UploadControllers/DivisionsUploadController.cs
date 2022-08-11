using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-divisions")]
    public class DivisionsUploadController : BasicUploadController<DivisionService, Division, DivisionViewModel, DivisionService.DivisionMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public DivisionsUploadController(DivisionService service) : base(service, ApiVersion)
        {
        }
    }
}