using Com.Ambassador.Service.Core.Lib.Interfaces;
using Com.Ambassador.Service.Core.Lib.Models;
using System;
using System.Linq.Expressions;

namespace Com.Ambassador.Service.Core.Lib.Services.GarmentEMKL
{
    public interface IGarmentEMKLService : IBaseService<GarmentEMKLModel>
    {
        bool CheckExisting(Expression<Func<GarmentEMKLModel, bool>> filter);
    }
}
