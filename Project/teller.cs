using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class teller : Person
    {
        private SqlConnection connect2;

        public teller (UInt32 accountNumber, string pass) : base(accountNumber, pass)
        {
            string path = System.Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "DataBase" + "\\DB.mdf";


            connect2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path2 + ";Integrated Security=True");
            try
            {
                connect2.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error while connection to SQL server");
            }
            
        }

        public User ShowData(UInt32 account_number)
        {
            User user1 = new User(account_number);
            
            return user1;
        }



    }
}
