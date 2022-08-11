using Com.Ambassador.Service.Core.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.ViewModels.Account_and_Roles
{
  public  class PackingDetailModelTest
    {
        [Fact]
        public void Should_Throws_NotImplementedException()
        {
            PackingDetailModel model = new PackingDetailModel();

            Assert.Throws<NotImplementedException>(() => model.Validate(null));
        }
        }
}
