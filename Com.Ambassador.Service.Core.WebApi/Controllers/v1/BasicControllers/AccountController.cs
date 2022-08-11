//using Com.Ambassador.Service.Core.Lib;
//using Com.Ambassador.Service.Core.Lib.Models.Account_and_Roles;
//using Com.Ambassador.Service.Core.Lib.Services.Account_and_Roles;
//using Com.Ambassador.Service.Core.Lib.ViewModels.Account_and_Roles;
//using Com.Ambassador.Service.Core.WebApi.Helpers;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
//{
//    [Produces("application/json")]
//    [ApiVersion("1.0")]
//    [Route("v{version:apiVersion}/master/accounts")]
//    public class AccountController : BasicController<AccountService, Account, AccountViewModel, CoreDbContext>
//    {
//        private static readonly string ApiVersion = "1.0";

//        public AccountController(AccountService service) : base(service, ApiVersion)
//        {
//        }
//    }
//}
