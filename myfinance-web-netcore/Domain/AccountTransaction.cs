namespace myfinance_web_netcore.Domain
{

    public class AccountTransaction
    {
        public int Id { get; set;}
        
        public string History { get; set;}

        public string Type { get; set;}
        
        public double Value { get; set;}

        public int AccountPlanId { get; set;}

        public DateTime Date { get; set;}

        public AccountPlan AccountPlan { get; set;}

    }
}