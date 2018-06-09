using System.Collections.Generic;

namespace MyMoney.Models
{
    public class AccountCollection
    {
        public List<Account> Accounts;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccountCollection()
        {
            Accounts = new List<Account>();
        }

        /// <summary>
        /// Add account to collection
        /// </summary>
        /// <param name="account">Account object</param>
        /// <returns>Status boolean</returns>
        public bool AddAccount(Account account)
        {
            Accounts.Add(account);
            return true;
        }
    }
}