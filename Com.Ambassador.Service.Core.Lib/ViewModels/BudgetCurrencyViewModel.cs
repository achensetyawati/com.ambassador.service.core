using Com.Ambassador.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Core.Lib.ViewModels
{
    public class BudgetCurrencyViewModel : BasicViewModel
    {
		public string code { get; set; }

		public DateTime date { get; set; }

		/* Double */
		public dynamic rate { get; set; }

		public string remark { get; set; }
	}
}
