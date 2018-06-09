using System.Data.Entity;
using MyMoney.Models;

namespace MyMoney.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountEvent> AccountEvents { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}