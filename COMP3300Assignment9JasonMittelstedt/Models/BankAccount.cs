using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    /// <summary>
    /// Represents a customer's bank account with details such as owner name,
    /// current balance, account type, and interest rate.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Gets or sets the name of the account owner.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Gets or sets the month the account was opened.
        /// </summary>
        public string MonthOpened { get; set; }

        /// <summary>
        /// Gets or sets the type of the account (e.g., Checking or Savings).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the monthly interest rate for the account.
        /// </summary>
        public double MonthlyInterestRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the class with specified values.
        /// </summary>
        /// <param name="ownerName">The name of the account owner.</param>
        /// <param name="currentBalance">The current balance of the account.</param>
        /// <param name="monthOpened">The month when the account was opened.</param>
        /// <param name="type">The type of the account (e.g., Checking, Savings).</param>
        /// <param name="monthlyInterestRate">The monthly interest rate for the account.</param>
        public BankAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;
        }

        /// <summary>
        /// Calculates the minimum balance fee based on the current balance.
        /// </summary>
        /// <returns>
        /// A decimal value representing the minimum balance fee.
        /// If the balance is below $1,200, a 7.3% fee is applied;
        /// otherwise, returns 0.
        /// </returns>
        public virtual decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200m)
                return CurrentBalance * 0.073m;
            return 0m;
        }

        /// <summary>
        /// Returns a string representation of the account details.
        /// </summary>
        /// <returns>
        /// A formatted string containing the owner name, balance,
        /// month opened, and monthly interest rate.
        /// </returns>
        public override string ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance:C}, Month Opened: {MonthOpened}, Monthly Interest Rate: {MonthlyInterestRate:P}";
        }
    }
}
