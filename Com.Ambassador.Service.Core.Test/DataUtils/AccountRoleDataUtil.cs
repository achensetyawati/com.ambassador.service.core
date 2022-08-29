//using Com.Ambassador.Service.Core.Lib;
//using Com.Ambassador.Service.Core.Lib.Models.Account_and_Roles;
//using Com.Ambassador.Service.Core.Lib.Services.Account_and_Roles;
//using Com.Ambassador.Service.Core.Lib.ViewModels.Account_and_Roles;
//using Com.Ambassador.Service.Core.Test.Helpers;
//using Com.Ambassador.Service.Core.Test.Interface;
//using System.Threading.Tasks;

//namespace Com.Ambassador.Service.Core.Test.DataUtils
//{
//    public class AccountRoleDataUtil : BasicDataUtil<CoreDbContext, AccountRoleService, AccountRole>, IEmptyData<AccountRoleViewModel>
//    {
//        public AccountRoleDataUtil(CoreDbContext dbContext, AccountRoleService service) : base(dbContext, service)
//        {
//        }

//        public AccountRoleViewModel GetEmptyData()
//        {
//            return new AccountRoleViewModel();
//        }

//        public override AccountRole GetNewData()
//        {
//            return new AccountRole{
                
//            };
//        }

//        public override async Task<AccountRole> GetTestDataAsync()
//        {
//            var model = GetNewData();
//            await Service.CreateModel(model);
//            return model;
//        }
//    }
//}
