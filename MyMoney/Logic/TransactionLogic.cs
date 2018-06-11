using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Get transaction types
        /// </summary>
        /// <returns>List of transaction types</returns>
        public List<string> GetTypes()
        {
            List<string> Types = new List<string>();
            foreach (string type in Enum.GetNames(typeof(Transaction.TransactionType)))
            {
                Types.Add(type);
            }
            return Types;
        }

        /// <summary>
        /// Put new transaction
        /// </summary>
        /// <param name="transaction">Transaction to add</param>
        /// <returns>ID of new transaction</returns>
        public int Put(Transaction transaction)
        {
            return TransactionDB.Put(transaction);
        }
    }
}