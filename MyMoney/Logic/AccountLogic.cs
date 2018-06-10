using System.Collections.Generic;
using MyMoney.Models;
using MyMoney.DBInteraction;

namespace MyMoney.Logic
{
    public class AccountLogic
    {
        private AccountDBInteraction AccountDB = new AccountDBInteraction();

        /// <summary>
        /// Get all accounts 
        /// </summary>
        /// <returns>Collection of accounts</returns>
        public AccountCollection Get()
        {
            return AccountDB.Get();
        }

        /// <summary>
        /// Get all account names
        /// </summary>
        /// <returns>List of account names</returns>
        public List<string> GetNames()
        {
            return AccountDB.GetNames();
        }

        /// <summary>
        /// Put new account
        /// </summary>
        /// <param name="account">Account to add</param>
        /// <returns>ID of new account</returns>
        public int Put(Account account)
        {
            return AccountDB.Put(account);
        }
    }
}