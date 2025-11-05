using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate) { }

        public override decimal CalculateMinimumBalanceFee()
        {
            decimal baseFee = base.CalculateMinimumBalanceFee();
            if (CurrentBalance < 1000m)
                return baseFee + 15m;
            return baseFee;
        }

        public override string ToString()
        {
            return $"Account Type: {Type}, {base.ToString()}";
        }
    }
}
