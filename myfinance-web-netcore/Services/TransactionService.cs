using AutoMapper;
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly MyFinanceDbContext _myFinanceDbContext;
        private readonly IMapper _mapper;

        public TransactionService(MyFinanceDbContext myFinanceDbContext,
                                 IMapper mapper)
        {
            _myFinanceDbContext = myFinanceDbContext;
            _mapper = mapper;
        }

        public IEnumerable<TransactionModel> Listar()
        {
            var list = _myFinanceDbContext.Transaction.ToList();
            var lista = _mapper.Map<IEnumerable<TransactionModel>>(list);
            return lista;
        }

        public TransactionModel RetornarRegistro(int id)
        {
            var item = _myFinanceDbContext.Transaction.Where(item => item.Id == id).First();
            return _mapper.Map<TransactionModel>(item);
        }

        void ITransactionService.Salvar(TransactionModel model)
        {
            var item = _mapper.Map<Transaction>(model);
            if (item.Id == null)
            {
                _myFinanceDbContext.Transaction.Add(item);
            }
            else
            {
                _myFinanceDbContext.Transaction.Attach(item);
                _myFinanceDbContext.Entry(item).State = EntityState.Modified;
            }
            _myFinanceDbContext.SaveChanges();
        }

        void ITransactionService.Excluir(int id)
        {
            var item = _myFinanceDbContext.Transaction.Where(item => item.Id == id).First();
            _myFinanceDbContext.Remove(item);
            _myFinanceDbContext.SaveChanges();
        }
    }
}