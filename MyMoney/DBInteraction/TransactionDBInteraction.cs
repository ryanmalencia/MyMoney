using System.Linq;
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

        /// <summary>
        /// Put new transaction
        /// Alter balance of associated account
        /// </summary>
        /// <param name="transaction">Transaction to add</param>
        /// <returns>ID of new transaction</returns>
        public int Put(Transaction transaction)
        {
            Transaction trans = DB.Transactions.Add(transaction);
            var Account = DB.Accounts.FirstOrDefault(a => a.Name == transaction.Account);
            int i = 0;
            Account.Balance += transaction.Amount;
            i = DB.SaveChanges();
            if (i == 0)
            {
                return 0;
            }
            else
            {
                return trans.TransactionID;
            }
        }
    }
}