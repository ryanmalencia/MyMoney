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