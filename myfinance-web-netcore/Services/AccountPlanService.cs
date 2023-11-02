using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Infrastructure;

namespace myfinance_web_netcore.Services
{
    public class AccountPlanServices : IAccountPlanService
    {

        private readonly MyFinanceDbContext _myFinanceDbContext;

        public AccountPlanServices(MyFinanceDbContext myFinanceDbContext)
        {
            _myFinanceDbContext = myFinanceDbContext;
        }

        public IEnumerable<AccountPlan> ListAccountPlan()
        {
            throw new NotImplementedException();
        }
    }
}