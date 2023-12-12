using AutoMapper;
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public class AccountPlanServices : IAccountPlanService
    {
        private readonly MyFinanceDbContext _myFinanceDbContext;
        private readonly IMapper _mapper;

        public AccountPlanServices(MyFinanceDbContext myFinanceDbContext,
                                 IMapper mapper)
        {
            _myFinanceDbContext = myFinanceDbContext;
            _mapper = mapper;
        }

        public IEnumerable<AccountPlanModel> Listar()
        {
            var list = _myFinanceDbContext.AccountPlan.ToList();
            var lista = _mapper.Map<IEnumerable<AccountPlanModel>>(list);
            return lista;
        }

        public AccountPlanModel RetornarRegistro(int id)
        {
            var item = _myFinanceDbContext.AccountPlan.Where(item => item.Id == id).First();
            return _mapper.Map<AccountPlanModel>(item);
        }

        void IAccountPlanService.Salvar(AccountPlanModel model)
        {
            var item = _mapper.Map<AccountPlan>(model);
            if (item.Id == null)
            {
                _myFinanceDbContext.AccountPlan.Add(item);
            }
            else
            {
                _myFinanceDbContext.AccountPlan.Attach(item);
                _myFinanceDbContext.Entry(item).State = EntityState.Modified;
            }
            _myFinanceDbContext.SaveChanges();
        }

        void IAccountPlanService.Excluir(int id)
        {
            var item = _myFinanceDbContext.AccountPlan.Where(item => item.Id == id).First();
            _myFinanceDbContext.Remove(item);
            _myFinanceDbContext.SaveChanges();
        }
    }
}