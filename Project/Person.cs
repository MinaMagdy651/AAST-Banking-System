using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    internal class Person
    {
        protected UInt32 account_number;
        private string password;
        private int adminLvl;

        public Person(UInt32 number, string password)
        {
            account_number = number;
            this.password = password;
        }
        public UInt32 Account_Number
        {
            get { return account_number;}
        }
        public string Password
        {
            get { return password;}
            set { password = value; }
        }
        public int AdminLvl
        {
            get { return adminLvl;}
            set { adminLvl = value; }
        }
        
        
    }
}
