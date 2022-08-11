using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Test.Interface;
using System;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class SupplierDataUtil : BasicDataUtil<CoreDbContext, SupplierService, Supplier>, IEmptyData<SupplierViewModel>
    {
        public SupplierDataUtil(CoreDbContext dbContext, SupplierService service) : base(dbContext, service)
        {
        }

        public SupplierViewModel GetEmptyData()
        {
            return new SupplierViewModel();
        }

        public override Supplier GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            return new Supplier
            {
                Code = string.Format("SupplierCode {0}", guid),
                Name = string.Format("SupplierName {0}", guid),
            };
        }

        public override async Task<Supplier> GetTestDataAsync()
        {
            var data = GetNewData();
            await Service.CreateModel(data);
            return data;
        }
    }
}
