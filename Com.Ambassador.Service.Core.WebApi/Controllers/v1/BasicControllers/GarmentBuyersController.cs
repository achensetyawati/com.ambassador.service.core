using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Lib;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-buyers")]
    public class GarmentBuyersController : BasicController<GarmentBuyerService, GarmentBuyer, GarmentBuyerViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        GarmentBuyerService service;

        public GarmentBuyersController(GarmentBuyerService service) : base(service, ApiVersion)
        {
            this.service = service;
        }

        [HttpGet("all")]
        public IActionResult GetSimple()
        {
            try
            {
                List<GarmentBuyer> Data = service.GetSimple();
                var result = Data.Select(x => service.MapToViewModel(x));
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                    .Ok(result);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }
    }
}
