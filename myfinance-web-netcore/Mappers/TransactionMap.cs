using AutoMapper;
using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Mappers
{
    public class TransactionMap : Profile
    {
        public TransactionMap()
        {
            CreateMap<Transaction, TransactionModel>().ReverseMap();
        }
    }
}