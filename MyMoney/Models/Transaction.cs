using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MyMoney.Models
{
    /// <summary>
    /// Model of a Transaction
    /// </summary>
    public class Transaction
    {
        public enum TransactionType
        {
            Deposit,
            Withdrawal
        }

        public int TransactionID { get; set; }
        public string Account { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType Type { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
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
    }
}