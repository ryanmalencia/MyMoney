using System.Collections.Generic;
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

        /// <summary>
        /// Get names of all accounts
        /// </summary>
        /// <returns>List of names</returns>
        public List<string> GetNames()
        {
            List<string> Names = new List<string>();
            foreach (Account account in DB.Accounts)
            {
                Names.Add(account.Name);
            }
            return Names;
        }

        /// <summary>
        /// Put new account in to database
        /// </summary>
        /// <param name="account">Account to add</param>
        /// <returns>ID of new account</returns>
        public int Put(Account account)
        {
            Account acc = DB.Accounts.Add(account);
            int i = 0;
            i = DB.SaveChanges();
            if (i == 0)
            {
                return 0;
            }
            else
            {
                return acc.AccountID;
            }
        }
    }
}