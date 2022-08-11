using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.DataUtils;
using Com.Ambassador.Service.Core.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.Controllers.StorageTests
{
    [Collection("TestFixture Collection")]
    public class BasicTest : BasicControllerTestOldVM<CoreDbContext, StorageService, Storage, StorageViewModel, StorageDataUtil>
    {
        private const string URI = "v1/master/storages";

        private static List<string> CreateValidationAttributes = new List<string> { };
        private static List<string> UpdateValidationAttributes = new List<string> { };

        public BasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }

        [Fact]
        public async Task GetStorageByName()
        {
            var Model = await DataUtil.GetTestDataAsync();
            var response = await this.Client.GetAsync(string.Concat(URI, "/by-storage-name?", $"keyword={Model.Name}"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
