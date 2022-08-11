using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Lib;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/suppliers")]
    public class SuppliersController : BasicController<SupplierService, Supplier, SupplierViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public SuppliersController(SupplierService service) : base(service, ApiVersion)
        {
        }
    }
}
