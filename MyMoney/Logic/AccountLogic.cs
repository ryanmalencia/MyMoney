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
    }
}