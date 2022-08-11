using Com.Ambassador.Service.Core.Lib.Helpers;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Ambassador.Service.Core.Test.Helpers
{
  public  class PropertyCopierTest
    {
        [Fact]
        public void should_success_Copy()
        {
            MachineSpinningModel origin = new MachineSpinningModel();
            MachineSpinningViewModel destination = new MachineSpinningViewModel();

            PropertyCopier<MachineSpinningModel, MachineSpinningViewModel>.Copy(origin, destination);
        }
    }
}
