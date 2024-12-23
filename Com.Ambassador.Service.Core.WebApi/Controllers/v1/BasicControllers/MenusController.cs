﻿using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.WebApi.Helpers;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.WebApi;
using System.Collections.Generic;
using System;
using System.Linq;
using Com.Ambassador.Service.Core.Lib.Models.Account_and_Roles;

namespace Com.Ambassador.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/menus")]
    public class MenusController : BasicController<MenuService, Menus, MenuViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        private readonly MenuService service;
        public MenusController(MenuService service) : base(service, ApiVersion)
        {
            this.service = service;
        }

        [HttpGet("download")]
        public IActionResult DownloadTemplate()
        {
            try
            {
                byte[] csvInBytes;
                var csv = Service.DownloadTemplate();

                string fileName = "Menu Template.csv";

                csvInBytes = csv.ToArray();

                var file = File(csvInBytes, "text/csv", fileName);
                return file;
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                  new Utils.ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                  .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }
    }
}
