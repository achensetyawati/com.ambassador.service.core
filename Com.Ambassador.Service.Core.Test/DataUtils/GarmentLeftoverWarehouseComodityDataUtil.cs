using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseComodity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class GarmentLeftoverWarehouseComodityDataUtil
    {
        private readonly GarmentLeftoverWarehouseComodityService Service;

        public GarmentLeftoverWarehouseComodityDataUtil(GarmentLeftoverWarehouseComodityService service)
        {
            Service = service;
        }

        public GarmentLeftoverWarehouseComodityModel GetNewData()
        {
            Guid guid = Guid.NewGuid();

            GarmentLeftoverWarehouseComodityModel model = new GarmentLeftoverWarehouseComodityModel
            {
                Code = $"Code{guid}",
                Name = $"Name{guid}",
            };

            return model;
        }

        public async Task<GarmentLeftoverWarehouseComodityModel> GetTestData()
        {
            var data = GetNewData();

            await Service.CreateAsync(data);

            return data;
        }
    }
}
