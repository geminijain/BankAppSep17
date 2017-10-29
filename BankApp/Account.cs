﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    public enum TypeOfAccount
    {
        Checking,
        Savings,
        Loan,
        CD
    }

    /// <summary>
    /// This is about a bank account
    /// </summary>
    public class Account
    {

        #region Properties
        /// <summary>
        /// This holds the account number
        /// </summary>
        [Key]
        public int AccountNumber { get; private set; }

        /// <summary>
        /// This is the email address of the user
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage ="Email address cannot be more than 50 characters in length.")]
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        [Required]
        public TypeOfAccount AccountType { get; set; }
        public DateTime CreatedDate { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        #endregion


        #region Constructors

        public Account()
        {
            CreatedDate = DateTime.UtcNow;
        }

        #endregion

        #region Methods

        public decimal Deposit(decimal amount)
        {
            Balance += amount; //Balance = Balance + amount
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new ArgumentOutOfRangeException("amount", "Insufficient funds.");

            Balance -= amount;
        }
        #endregion
    }
}
