using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class SavingAccount : User
    {
        private int IR = 15;
        public SavingAccount(UInt32 accNum) : base(accNum)
        {

        }
        public override double GetBalance()
        {
            return Balance + Balance * (IR / 100.0);
        }
        public override string GetType()
        {
            return "Saving";
        }
    }
}
