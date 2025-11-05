using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    public class MoneyMarketAccount : BankAccount
    {
        public MoneyMarketAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        public override decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 10000m)
                return CurrentBalance * 0.05m + 50m;
            return 0m;
        }

        public override string ToString()
        {
            return $"Account Type: {Type}, {base.ToString()}";
        }
    }
}
