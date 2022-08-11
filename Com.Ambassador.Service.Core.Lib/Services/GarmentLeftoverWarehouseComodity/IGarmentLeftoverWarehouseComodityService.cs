using Com.Ambassador.Service.Core.Lib.Interfaces;
using Com.Ambassador.Service.Core.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Com.Ambassador.Service.Core.Lib.Services.GarmentLeftoverWarehouseComodity
{
    public interface IGarmentLeftoverWarehouseComodityService : IBaseService<GarmentLeftoverWarehouseComodityModel>
    {
        bool CheckExisting(Expression<Func<GarmentLeftoverWarehouseComodityModel, bool>> filter);
    }
}
