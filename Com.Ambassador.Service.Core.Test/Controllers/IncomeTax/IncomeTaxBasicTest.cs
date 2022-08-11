using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using System.Collections.Generic;
using Models = Com.Ambassador.Service.Core.Lib.Models;
using Xunit;
using Com.Ambassador.Service.Core.Test.DataUtils;

namespace Com.Ambassador.Service.Core.Test.Controllers.IncomeTax
{
    [Collection("TestFixture Collection")]
    public class IncomeTaxBasicTest : BasicControllerTest<CoreDbContext, IncomeTaxService, Models.IncomeTax, IncomeTaxViewModel, IncomeTaxDataUtil>
    {
        private const string URI = "v1/master/income-taxes";

        private static List<string> CreateValidationAttributes = new List<string> { };
        private static List<string> UpdateValidationAttributes = new List<string> { };

        public IncomeTaxBasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
