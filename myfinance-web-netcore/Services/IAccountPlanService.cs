using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Services
{
    public interface IAccountPlanService
    {
        IEnumerable<AccountPlan> ListAccountPlan();
    }
}