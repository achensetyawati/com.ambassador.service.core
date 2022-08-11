using Com.Ambassador.Service.Core.Lib.Interfaces;
using Com.Ambassador.Service.Core.Lib.Models;
using System;
using System.Linq.Expressions;

namespace Com.Ambassador.Service.Core.Lib.Services.GarmentAdditionalCharges
{
    public interface IGarmentAdditionalChargesService : IBaseService<GarmentAdditionalChargesModel>
    {
        bool CheckExisting(Expression<Func<GarmentAdditionalChargesModel, bool>> filter);
    }
}
