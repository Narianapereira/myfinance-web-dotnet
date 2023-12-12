namespace myfinance_web_netcore.Domain
{

    public class Transaction
    {
        public int? Id { get; set; }
        public required string Descricao { get; set; }
        public required double Valor { get; set; }
        public int AccountPlanId { get; set; }
        public DateTime Data { get; set; }
        public string? FormaPagamentoId { get; set; }
    }
}