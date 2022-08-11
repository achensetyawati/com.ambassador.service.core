using Com.Ambassador.Service.Core.Lib.Helpers;
using Com.Ambassador.Service.Core.Lib.Models;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Core.Lib.ViewModels
{
    public class DivisionGroupViewModel : BasicViewModel
    {
        public string Name { get; set; }
        public List<string> DivisionCodes { get; set; }
    }
}
