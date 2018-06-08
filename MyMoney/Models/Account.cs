﻿using System.Collections.Generic;
using MyMoney.Interfaces;

namespace MyMoney.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Bank { get; set; }
        public string Type { get; set; }
        //public List<IAccountEvent> AccountEvents;


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
            return Type;
        }

        /// <summary>
        /// Get the provider of the account
        /// </summary>
        /// <returns>Name of account provider</returns>
        public string GetBank()
        {
            return Bank;
        }

        /// <summary>
        /// Get the name of the account
        /// </summary>
        /// <returns>Name of account</returns>
        public string GetName()
        {
            return Name;
        }

    }
}