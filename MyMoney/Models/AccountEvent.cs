using MyMoney.Interfaces;

namespace MyMoney.Models
{
    public class AccountEvent : IAccountEvent
    {
        public int AccountEventID { get; set; }
        public bool Deposit { get; set; }
        public bool Withdraw { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccountEvent()
        {
            Deposit = false;
            Withdraw = true;
        }

        /// <summary>
        /// Constructor with ID
        /// </summary>
        /// <param name="id">ID of account event</param>
        public AccountEvent(int id)
        {
            AccountEventID = id;
        }

        /// <summary>
        /// Constructor setting account event type
        /// </summary>
        /// <param name="dep">Bool designating deposit status</param>
        /// <param name="with">Bool designating withdrawal status</param>
        public AccountEvent(bool dep, bool with)
        {
            Deposit = dep;
            Withdraw = with;
        }

        /// <summary>
        /// Get the type of event
        /// </summary>
        /// <returns>String representation of type</returns>
        public string GetEventType()
        {
            return "";
        }

        /// <summary>
        /// Get dollar amount 
        /// </summary>
        /// <returns>Double represenation of the transaction amount</returns>
        public double GetAmount()
        {
            return 0;
        }

        /// <summary>
        /// Get title/name of event
        /// </summary>
        /// <returns>String representation of title/name of event</returns>
        public string GetTitle()
        {
            return "";
        }
    }
}