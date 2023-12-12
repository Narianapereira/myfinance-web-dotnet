using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public interface IAccountPlanService
    {
        IEnumerable<AccountPlanModel> Listar();
        AccountPlanModel RetornarRegistro(int id);
        void Salvar(AccountPlanModel model);
        void Excluir(int id);
    }
}