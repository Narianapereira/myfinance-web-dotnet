
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Infrastructure
{
    public class MyFinanceDbContext : DbContext
    {

        public DbSet<AccountPlan> AccountPlan {get; set;}

        public DbSet<AccountTransaction> AccountTransaction {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost:1433;Database=myfinanceweb;User Id=sa;Password=Nari3714#;"; 
            optionsBuilder.UseSqlServer(connectionString);
        }



    }
}