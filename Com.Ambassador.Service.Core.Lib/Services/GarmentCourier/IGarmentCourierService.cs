using Com.Ambassador.Service.Core.Lib.Interfaces;
using Com.Ambassador.Service.Core.Lib.Models;
using System;
using System.Linq.Expressions;

namespace Com.Ambassador.Service.Core.Lib.Services.GarmentCourier
{
    public interface IGarmentCourierService : IBaseService<GarmentCourierModel>
    {
        bool CheckExisting(Expression<Func<GarmentCourierModel, bool>> filter);
    }
}
