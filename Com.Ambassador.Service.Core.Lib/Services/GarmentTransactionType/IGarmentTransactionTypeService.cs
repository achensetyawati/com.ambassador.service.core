using Com.Ambassador.Service.Core.Lib.Interfaces;
using Com.Ambassador.Service.Core.Lib.Models;
using System;
using System.Linq.Expressions;

namespace Com.Ambassador.Service.Core.Lib.Services.GarmentTransactionType
{
    public interface IGarmentTransactionTypeService : IBaseService<GarmentTransactionTypeModel>
    {
        bool CheckExisting(Expression<Func<GarmentTransactionTypeModel, bool>> filter);
    }
}
