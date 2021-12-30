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
            MessageBox.Show(Convert.ToString(account_number));
            User user1 = new User(account_number);
            
            if (user1.Found)
            {
                string query2 = "DELETE FROM Users WHERE AccountNumber = " + account_number;
                SqlCommand command2 = new SqlCommand(query2, connect2);
                //MessageBox.Show(Convert.ToString(user1.Name));

                command2.ExecuteNonQuery();
                command2.Dispose();
               
               string query = "DELETE FROM tbl_accounts_data WHERE AccountNumber = " + account_number;
               
                SqlCommand command = new SqlCommand(query, connect2);
                command.ExecuteNonQuery();
                command.Dispose();
     

                return true;
            }
            return false;
        }
        public void adddUser(/*string name, double balance, string email, string phone_number, string address, char gender*/)
        {
            string query = "select max(AccountNumber) from tbl_accounts_data";
            SqlCommand Command = new SqlCommand(query, connect2);
            SqlDataReader DataReader = Command.ExecuteReader();

            UInt32 new_accNumber = 0;
            if (DataReader.Read())
            {
                new_accNumber = UInt32.Parse("" + DataReader.GetValue(0)) + 1;
                MessageBox.Show(Convert.ToString(new_accNumber));
            }
            string password = passwordGen();
            DataReader.Close();
            Command.Dispose();

            string query2 = "INSERT INTO Users (AccountNumber, Password, AdminLvL) VALUES('5', 'test', '0')";
            SqlCommand command2 = new SqlCommand(query2, connect2);
         //   command2.Parameters.AddWithValue("@AccountNumber", new_accNumber);
           // command2.Parameters.AddWithValue("@Password", password);
            command2.ExecuteNonQuery();

          /*  string query3 = "INSERT INTO tbl_accounts_data (AccountNumber, Name, Address, Phone, Email, AccountType, Balance, Debt, Gender) VALUES(@AccountNumber, @Name, @Address, @Phone, @Email, '0', @Balance, '0', @Gender)";
            SqlCommand command3 = new SqlCommand(query3, connect2);
            command3.Parameters.AddWithValue("@AccountNumber", new_accNumber);
            command3.Parameters.AddWithValue("@Name", name);
            command3.Parameters.AddWithValue("@Address", address);
            command3.Parameters.AddWithValue("@Phone", phone_number);
            command3.Parameters.AddWithValue("@Email", email);
            command3.Parameters.AddWithValue("@Balance", balance);
            command3.Parameters.AddWithValue("@Gender", gender);
            command3.ExecuteNonQuery();*/



        }

        private string passwordGen()
        {
            Random generator = new Random();
            string password = generator.Next(100000, 1000000).ToString();
            return password;
        }

    }
}
