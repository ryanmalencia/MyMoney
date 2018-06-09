using MyMoney.DAL;
using MyMoney.Models;

namespace MyMoney.DBInteraction
{
    public class AccountDBInteraction
    {
        private DataContext DB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccountDBInteraction()
        {
            DB = new DataContext();
        }

        /// <summary>
        /// Get all accounts
        /// </summary>
        /// <returns>Collection of accounts</returns>
        public AccountCollection Get()
        {
            AccountCollection Accounts = new AccountCollection();
            foreach(Account account in DB.Accounts)
            {
                Accounts.AddAccount(account);
            }
            return Accounts;
        }
    }
}