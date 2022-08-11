using Com.Ambassador.Service.Core.Lib.Helpers;

namespace Com.Ambassador.Service.Core.Lib.ViewModels
{
    public class OrderTypeViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
    }
}
