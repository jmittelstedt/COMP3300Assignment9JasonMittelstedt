using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    /// <summary>
    /// Represents a savings account that inherits from the class.
    /// Provides a specialized implementation for calculating minimum balance fees
    /// specific to savings accounts.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavingsAccount"/> class
        /// with the specified account details.
        /// </summary>
        /// <param name="ownerName">The name of the account owner.</param>
        /// <param name="currentBalance">The current balance of the savings account.</param>
        /// <param name="monthOpened">The month when the account was opened.</param>
        /// <param name="type">The account type (typically "Savings").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate for the account.</param>
        public SavingsAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        /// <summary>
        /// Calculates the minimum balance fee for the savings account.
        /// </summary>
        /// <returns>
        /// A decimal value representing the minimum balance fee.
        /// If the current balance is below $2,000, a flat $25 fee is charged.
        /// Otherwise, returns 0.
        /// </returns>
        public override decimal CalculateMinimumBalanceFee()
        {
            // Full override (no call to base)
            if (CurrentBalance < 2000m)
                return 25m;
            return 0m;
        }

        /// <summary>
        /// Returns a string representation of the savings account details.
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
