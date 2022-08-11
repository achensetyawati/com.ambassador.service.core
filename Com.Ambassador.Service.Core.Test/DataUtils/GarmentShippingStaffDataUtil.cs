using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services.GarmentShippingStaff;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
    public class GarmentShippingStaffDataUtil
    {
        private readonly GarmentShipingStaffService Service;

        public GarmentShippingStaffDataUtil(GarmentShipingStaffService service)
        {
            Service = service;
        }

        public GarmentShippingStaffModel GetNewData()
        {
            Guid guid = Guid.NewGuid();

            GarmentShippingStaffModel model = new GarmentShippingStaffModel
            {
                Name = $"Name{guid}",
            };

            return model;
        }

        public async Task<GarmentShippingStaffModel> GetTestData()
        {
            var data = GetNewData();

            await Service.CreateAsync(data);

            return data;
        }
    }
}
