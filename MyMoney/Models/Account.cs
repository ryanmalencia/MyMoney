using System.Collections.Generic;
using MyMoney.Interfaces;

namespace MyMoney.Models
{
    public class Account : IAccount
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }
        public string AccountType { get; set; }
        public List<IAccountEvent> AccountEvents;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Account()
        {
            AccountEvents = new List<IAccountEvent>();
        }

        /// <summary>
        /// Constructor with ID
        /// </summary>
        /// <param name="id">ID of account</param>
        public Account(int id)
        {
            AccountID = id;
        }

        /// <summary>
        /// Get the type of the account
        /// </summary>
        /// <returns>String representation of account type</returns>
        public string GetAccountType()
        {
            return AccountType;
        }

        /// <summary>
        /// Get the provider of the account
        /// </summary>
        /// <returns>Name of account provider</returns>
        public string GetProvider()
        {
            return Provider;
        }

        /// <summary>
        /// Get the name of the account
        /// </summary>
        /// <returns>Name of account</returns>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// Add new account event to this account
        /// </summary>
        /// <param name="Event">Event to add</param>
        /// <returns>Status of add</returns>
        public bool AddEvent(IAccountEvent Event)
        {
            AccountEvents.Add(Event);
            return true;
        }
    }
}