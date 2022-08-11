using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class GarmentUnitDataUtil : BasicDataUtil<CoreDbContext, GarmentUnitService, Unit>, IEmptyData<UnitViewModel>
    {
        public GarmentUnitDataUtil(CoreDbContext dbContext, GarmentUnitService service) : base(dbContext, service)
        {
        }

        public UnitViewModel GetEmptyData()
        {
            return new UnitViewModel
            {
                Division = new DivisionViewModel()
            };
        }

        public override Unit GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            return new Unit
            {
                Code = string.Format("UnitCode {0}", guid),
                Name = string.Format("UnitName {0}", guid),
            };
        }

        public override async Task<Unit> GetTestDataAsync()
        {
            var data = GetNewData();
            await Service.CreateModel(data);
            return data;
        }
    }
}
