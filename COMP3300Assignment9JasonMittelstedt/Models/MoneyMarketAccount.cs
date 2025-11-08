using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    /// <summary>
    /// Represents a money market account that inherits from the class.
    /// Provides a specialized implementation for calculating minimum balance fees specific
    /// to money market accounts.
    /// </summary>
    public class MoneyMarketAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyMarketAccount"/> class
        /// with the specified account details.
        /// </summary>
        /// <param name="ownerName">The name of the account owner.</param>
        /// <param name="currentBalance">The current balance of the money market account.</param>
        /// <param name="monthOpened">The month when the account was opened.</param>
        /// <param name="type">The account type (typically "Money Market").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate for the account.</param>
        public MoneyMarketAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        /// <summary>
        /// Calculates the minimum balance fee for the money market account.
        /// </summary>
        /// <returns>
        /// A decimal value representing the minimum balance fee.
        /// If the current balance is below $10,000, a 5% fee of the balance plus a $50 flat fee is applied.
        /// Otherwise, returns 0.
        /// </returns>
        public override decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 10000m)
                return CurrentBalance * 0.05m + 50m;
            return 0m;
        }


        /// <summary>
        /// Returns a string representation of the money market account details.
        /// </summary>
        /// <returns>
        /// A formatted string containing the account type and the base account details.
        /// </returns>
        public override string ToString()
        {
            return $"Account Type: {Type}, {base.ToString()}";
        }
    }
}
