using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public interface ITransactionService
    {
        IEnumerable<TransactionModel> Listar();
        TransactionModel RetornarRegistro(int id);
        void Salvar(TransactionModel model);
        void Excluir(int id);
    }
}