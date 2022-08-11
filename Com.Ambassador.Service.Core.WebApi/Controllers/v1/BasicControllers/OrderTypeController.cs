using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/order-types")]
    public class OrderTypeController : BasicController<OrderTypeService, OrderType, OrderTypeViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public OrderTypeController(OrderTypeService service) : base(service, ApiVersion)
        {
        }
    }
}
