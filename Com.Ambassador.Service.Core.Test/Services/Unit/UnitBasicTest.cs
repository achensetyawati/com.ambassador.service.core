using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Helpers;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.Services.UnitTest
{
    [Collection("ServiceProviderFixture Collection")]
    public class UnitBasicTest : BasicServiceTest<CoreDbContext, UnitService, Unit>
    {

        private static readonly string[] createAttrAssertions = { "Name", "Code" };
        private static readonly string[] updateAttrAssertions = { "Name", "Code" };
        private static readonly string[] existAttrCriteria = { "Name", "Code" };

        public UnitBasicTest(ServiceProviderFixture fixture) : base(fixture, createAttrAssertions, updateAttrAssertions, existAttrCriteria)
        {
        }

        public override void EmptyCreateModel(Unit model)
        {
            model.Name = string.Empty;
            model.Code = string.Empty;
        }

        public override void EmptyUpdateModel(Unit model)
        {
            model.Name = string.Empty;
            model.Code = string.Empty;
        }

        public override Unit GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new Unit()
            {
                Name = string.Format("Unit {0}", guid),
                Code = string.Format("TEST {0}", guid),
            };
        }
    }
}
