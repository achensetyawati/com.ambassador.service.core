using Com.Ambassador.Service.Core.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Com.Moonlay.Models;
using Com.Ambassador.Service.Core.Lib.Models;
using System.Linq.Expressions;

namespace Com.Ambassador.Service.Core.Lib.Services.BankCashReceiptType
{
    public interface IBankCashReceiptTypeService : IBaseService<BankCashReceiptTypeModel>
    {
        bool CheckExisting(Expression<Func<BankCashReceiptTypeModel, bool>> filter);
    }

}
