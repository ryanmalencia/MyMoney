using System.Collections.Generic;

namespace MyMoney.Models
{
    public class TransactionCollection
    {
        public List<Transaction> Transactions;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionCollection()
        {
            Transactions = new List<Transaction>();
        }

        /// <summary>
        /// Add account to collection
        /// </summary>
        /// <param name="account">Account object</param>
        /// <returns>Status boolean</returns>
        public bool Add(Transaction transaction)
        {
            Transactions.Add(transaction);
            return true;
        }

        /// <summary>
        /// Add account to collection
        /// </summary>
        /// <param name="account">Account object</param>
        /// <returns>Status boolean</returns>
        public bool AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            return true;
        }
    }
}