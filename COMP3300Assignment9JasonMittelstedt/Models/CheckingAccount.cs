using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    /// <summary>
    /// Represents a checking account that inherits from the <see cref="BankAccount"/> class.
    /// Provides specialized behavior for calculating minimum balance fees.
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the class with the specified account details.
        /// </summary>
        /// <param name="ownerName">The name of the account owner.</param>
        /// <param name="currentBalance">The current balance of the checking account.</param>
        /// <param name="monthOpened">The month when the account was opened.</param>
        /// <param name="type">The account type (typically "Checking").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate for the account.</param>
        public CheckingAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        /// <summary>
        /// Calculates the minimum balance fee for the checking account.
        /// </summary>
        /// <returns>
        /// A decimal value representing the total minimum balance fee.
        /// If the balance is below $1,200, a base 7.3% fee is applied from the parent class.
        /// If the balance is also below $1,000, an additional flat $15 fee is added.
        /// </returns>
        public override decimal CalculateMinimumBalanceFee()
        {
            decimal baseFee = base.CalculateMinimumBalanceFee();
            if (CurrentBalance < 1000m)
                return baseFee + 15m;
            return baseFee;
        }

        /// <summary>
        /// Returns a string representation of the checking account details.
        /// </summary>
        /// <returns>
        /// A formatted string that includes the account type and base account information.
        /// </returns>
        public override string ToString()
        {
            return $"Account Type: {Type}, {base.ToString()}";
        }
    }
}
