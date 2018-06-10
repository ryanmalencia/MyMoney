using System;
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
        /// Put new account
        /// </summary>
        /// <param name="account">Account to add</param>
        /// <returns>Success/failure</returns>
        public int Put(Account account)
        {
            return AccountDB.Put(account);
        }
    }
}