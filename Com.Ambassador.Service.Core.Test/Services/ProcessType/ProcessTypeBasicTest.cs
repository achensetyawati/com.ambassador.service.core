using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.Services.ProcessTypeTest
{
    [Collection("ServiceProviderFixture Collection")]
    public class ProcessTypeBasicTest : BasicServiceTest<CoreDbContext, ProcessTypeService, ProcessType>
    {
        private static readonly string[] createAttrAssertions = { "Name", "Unit", "SPPCode" };
        private static readonly string[] updateAttrAssertions = { "Name", "Unit", "SPPCode", "Code" };
        private static readonly string[] existAttrCriteria = { "Name" };

        public ProcessTypeBasicTest(ServiceProviderFixture fixture) : base(fixture, createAttrAssertions, updateAttrAssertions, existAttrCriteria)
        {
        }

        public override void EmptyCreateModel(ProcessType model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
            model.Unit = string.Empty;
            model.SPPCode = string.Empty;
        }

        public override void EmptyUpdateModel(ProcessType model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
            model.Unit = string.Empty;
            model.SPPCode = string.Empty;
        }

        public override ProcessType GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new ProcessType()
            {
                Name = string.Format("TEST {0}", guid),
                Code = string.Format("TEST {0}", guid),
                Unit = string.Format("TEST {0}", guid),
                SPPCode = string.Format("TEST {0}", guid)

            };
        }
    }
}
