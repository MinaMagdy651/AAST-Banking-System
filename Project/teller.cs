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

        public teller (UInt32 accountNumber) : base(accountNumber)
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

        public User? ShowData(UInt32 account_number)
        {
            User user1 = new User(account_number);
            if (user1.Found)
            {
                return user1;
            }
            return null;
        }

        public bool EditData(UInt32 account_number, string name, string email, string phone_number, string address)
        {
            
               string query2 = "UPDATE tbl_accounts_data SET Phone = '" + phone_number + "',   Email  = '" + email + "' , Address = '" +address +"'  WHERE AccountNumber = " + Account_Number;

                string query = "UPDATE tbl_accounts_data Phone = '" + phone_number + "' WHERE AccountNumber = " + Account_Number;
                _ = "UPDATE tbl_accounts_data Address = '" + address + "' WHERE AccountNumber = " + Account_Number;
                _ = "UPDATE tbl_accounts_data Email = '" + email + "' WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query2, connect2);
                command.ExecuteNonQuery();
                command.Dispose();

            return true;
        }

        public bool deleteData(UInt32 account_number)
        {
            User user1 = new User(account_number);
            if (user1.Found)
            {
                string query = "DELETE FROM tbl_accounts_data WHERE AccountNumber = " + Account_Number;
                
                SqlCommand command = new SqlCommand(query, connect2);
                string query2 = "DELETE FROM USERS WHERE AccountNumber = " + Account_Number;
                SqlCommand command2 = new SqlCommand(query2, connect2);
                command.ExecuteNonQuery();
                command.Dispose();

                return true;
            }
            return false;
        }



    }
}
