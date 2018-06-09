using System;
using MyMoney.Models;
using MyMoney.DBInteraction;

namespace MyMoney.Logic
{
    public class TransactionLogic
    {
        private TransactionDBInteraction TransactionDB = new TransactionDBInteraction();

        /// <summary>
        /// Get all activity
        /// </summary>
        /// <returns>Collection of activity</returns>
        public TransactionCollection Get()
        {
            return TransactionDB.Get();
        }
    }
}