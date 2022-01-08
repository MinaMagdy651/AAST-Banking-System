using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class SavingAccount : User
    {
        public SavingAccount(UInt32 accNum) : base(accNum)
        {

        }
        public override double GetBalance()
        {
            return Balance;
        }
    }
}
