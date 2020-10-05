using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount(double interestRate, string accountOwner, string accountNumber)
            : base(accountOwner, accountNumber)
        {
            InterestRate = interestRate;
        }

        public double CalculateInterestRate()
        {
            //Amount är protected, så vi kommer åt den här eftersom SavingsAccount ärver från Account
            Amount = Amount * InterestRate;

            return Amount;
        }
    }
}
