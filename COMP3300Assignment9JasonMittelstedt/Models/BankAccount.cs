using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9JasonMittelstedt.Models
{
    public class BankAccount
    {
        public string OwnerName { get; set; }
        public decimal CurrentBalance { get; set; }
        public string MonthOpened { get; set; }
        public string Type { get; set; }
        public double MonthlyInterestRate { get; set; }

        public BankAccount(string ownerName, decimal currentBalance, string monthOpened, string type, double monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;
        }

        public virtual decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200m)
                return CurrentBalance * 0.073m;
            return 0m;
        }

        public override string ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance:C}, Month Opened: {MonthOpened}, Monthly Interest Rate: {MonthlyInterestRate:P}";
        }
    }
}
