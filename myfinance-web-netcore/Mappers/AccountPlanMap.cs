using AutoMapper;
using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Mappers
{
    public class AccountPlanMap : Profile
    {
        public AccountPlanMap()
        {
            CreateMap<AccountPlan, AccountPlanModel>().ReverseMap();
        }
    }
}