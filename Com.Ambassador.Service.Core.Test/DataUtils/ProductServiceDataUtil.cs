using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Test.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class ProductServiceDataUtil : BasicDataUtil<CoreDbContext, ProductService, Product>, IEmptyData<ProductViewModel>
    {

        public ProductServiceDataUtil(CoreDbContext dbContext, ProductService service) : base(dbContext, service)
        {
        }        

        public ProductViewModel GetEmptyData()
        {
            ProductViewModel Data = new ProductViewModel();

            Data.Name = "";
            Data.Code = "";
            Data.Description = "desc";
            Data.Price = 0;
            Data.Tags = "tags";
            return Data;
        }

        public override Product GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            Product TestData = new Product
            {
                Code = string.Format("CODE {0}", guid),
                Name = string.Format("TEST {0}", guid),
                CurrencySymbol = "curr",
                Active = true,
                CurrencyCode = "currcode",
                CurrencyId = 1,
                Description = "desc",
                Price = 0,
                Tags = "tags",
                UomId = 1,
                UomUnit = "uom",
                UId = guid
            };

            return TestData;
        }

        public override async Task<Product> GetTestDataAsync()
        {
            Product Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}