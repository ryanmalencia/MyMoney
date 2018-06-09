using System;

namespace MyMoney.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Transaction()
        {

        }

        /// <summary>
        /// Constructor with ID
        /// </summary>
        /// <param name="id">ID of activity</param>
        public Transaction(int id)
        {
            TransactionID = id;
        }

        /// <summary>
        /// Get the type of the transaction
        /// </summary>
        /// <returns>String representation of transaction type</returns>
        public string GetTransactionType()
        {
            return Type;
        }

        /// <summary>
        /// Get the provider of the account
        /// </summary>
        /// <returns>Name of transaction account provider</returns>
        public string GetBank()
        {
            return Bank;
        }
    }
}