using Com.Ambassador.Service.Core.Lib;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.Services;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using Com.Ambassador.Service.Core.Test.Helpers;
using Com.Ambassador.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Core.Test.DataUtils
{
	public class GarmentDetailCurrencyDataUtil : BasicDataUtil<CoreDbContext, GarmentDetailCurrencyService, GarmentDetailCurrency>, IEmptyData<GarmentDetailCurrencyViewModel>
	{
		public GarmentDetailCurrencyDataUtil(CoreDbContext dbContext, GarmentDetailCurrencyService service) : base(dbContext, service)
		{
		}

		public GarmentDetailCurrencyViewModel GetEmptyData()
		{
			GarmentDetailCurrencyViewModel Data = new GarmentDetailCurrencyViewModel();
			
			return Data;
		}

		public override GarmentDetailCurrency GetNewData()
		{
            GarmentDetailCurrency model = new GarmentDetailCurrency();

			string guid = Guid.NewGuid().ToString();

			model.Code = guid;
			model.Date = DateTime.Now;
			model.Rate = 1;

			return model;
		}

		public override async Task<GarmentDetailCurrency> GetTestDataAsync()
		{
            GarmentDetailCurrency model = GetNewData();
			await this.Service.CreateModel(model);
			return model;
		}

		

		
	}
}
