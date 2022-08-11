using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Helpers.IdentityService;
using Com.Ambassador.Service.Core.Lib.Helpers.ValidateService;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.BankCashReceiptType;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.WebApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/bank-cash-receipt-types")]
    [Authorize]
    public class BankCashReceiptTypeController : BaseController<BankCashReceiptTypeModel, BankCashReceiptTypeViewModel, IBankCashReceiptTypeService>
    {
        public BankCashReceiptTypeController(IIdentityService identityService, IValidateService validateService, IBankCashReceiptTypeService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {
        }
    }
}

