using MyMoney.DAL;
using MyMoney.Models;

namespace MyMoney.DBInteraction
{
    public class TransactionDBInteraction
    {
        private DataContext DB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionDBInteraction()
        {
            DB = new DataContext();
        }

        /// <summary>
        /// Get all accounts
        /// </summary>
        /// <returns>Collection of accounts</returns>
        public TransactionCollection Get()
        {
            TransactionCollection Transactions = new TransactionCollection();
            foreach(Transaction transaction in DB.Transactions)
            {
                Transactions.Add(transaction);
            }
            return Transactions;
        }
    }
}