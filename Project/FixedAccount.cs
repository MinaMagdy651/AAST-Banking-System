using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class FixedAccount : User
    {
        int IR = 7;

        public FixedAccount(UInt32 accNum) : base(accNum)
        {

        }
        public override double GetBalance()
        {
            return Balance + Balance * (IR/100);
        }

    }
}
