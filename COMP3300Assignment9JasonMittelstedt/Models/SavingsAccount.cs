using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        public override decimal CalculateMinimumBalanceFee()
        {
            // Full override (no call to base)
            if (CurrentBalance < 2000m)
                return 25m;
            return 0m;
        }

        public override string ToString()
        {
            return $"Account Type: {Type}, {base.ToString()}";
        }
    }
}
