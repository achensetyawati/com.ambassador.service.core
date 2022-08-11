using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.DataUtils;
using Com.Ambassador.Service.Core.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.Controllers.CurrencyTests
{
    [Collection("TestFixture Collection")]
    public class BasicTest : BasicControllerTest<CoreDbContext, CurrencyService, Currency, CurrencyViewModel, CurrencyDataUtil>
    {
        private const string URI = "v1/master/currencies";

        private static List<string> CreateValidationAttributes = new List<string> { "Code", "Symbol", "Rate" };
        private static List<string> UpdateValidationAttributes = new List<string> { "Code", "Symbol", "Rate" };

        public BasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
