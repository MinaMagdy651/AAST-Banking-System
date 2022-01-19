    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class teller
    {
        private SqlConnection connect2;

        public teller ()
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
            
               string query2 = "UPDATE tbl_accounts_data SET Phone = '" + phone_number + "',   Email  = '" + email + "' , Address = '" +address +"'  WHERE AccountNumber = " + account_number;

            
                SqlCommand command = new SqlCommand(query2, connect2);
                command.ExecuteNonQuery();
                command.Dispose();

            return true;
        }

        public bool deleteData(UInt32 account_number)
        {
            User user1 = new User(account_number);
            if (user1.Found && user1.AdminLvl != 1)
            {
                string query = "DELETE FROM tbl_accounts_data WHERE AccountNumber = " + account_number;
                SqlCommand command = new SqlCommand(query, connect2);
                command.ExecuteNonQuery();
                command.Dispose();

                string query2 = "DELETE FROM Users WHERE AccountNumber = " + account_number;
                SqlCommand command2 = new SqlCommand(query2, connect2);
                command2.ExecuteNonQuery();
                command2.Dispose();


                string query3 = "DELETE FROM TransactionRecords WHERE ID = " + account_number;
                SqlCommand command3 = new SqlCommand(query3, connect2);
                command3.ExecuteNonQuery();
                command3.Dispose();
                return true;
            }
            return false;
        }
        public void adddUser(string name, double balance, string email, string phone_number, string address, char gender, int accountType)
        {
            string query = "select max(AccountNumber) from tbl_accounts_data";
            SqlCommand Command = new SqlCommand(query, connect2);
            SqlDataReader DataReader = Command.ExecuteReader();

            int new_accNumber = 0;
            if(DataReader.Read())
                new_accNumber =  Int32.Parse("" + DataReader.GetValue(0)) + 1;
            else
            {
                new_accNumber = 1;
            }

            string password = passwordGen();
            DataReader.Close();
            Command.Dispose();

            string query2 = "INSERT INTO Users (AccountNumber, Password, AdminLvL) VALUES(@AccountNumber, @Password, '0')";
            SqlCommand command2 = new SqlCommand(query2, connect2);
            command2.Parameters.AddWithValue("@AccountNumber", new_accNumber);
            command2.Parameters.AddWithValue("@Password", password);
            command2.ExecuteNonQuery();


            string query3 = "INSERT INTO tbl_accounts_data (AccountNumber, Name, Address, Phone, Email, AccountType, Balance, Debt, Gender) VALUES(@AccountNumber, @Name, @Address, @Phone, @Email, @AccountType, @Balance, '0', @Gender)";
            SqlCommand command3 = new SqlCommand(query3, connect2);
            command3.Parameters.AddWithValue("@AccountNumber", new_accNumber);
            command3.Parameters.AddWithValue("@Name", name);
            command3.Parameters.AddWithValue("@Address", address);
            command3.Parameters.AddWithValue("@Phone", phone_number);
            command3.Parameters.AddWithValue("@Email", email);
            command3.Parameters.AddWithValue("@Balance", balance);
            command3.Parameters.AddWithValue("@Gender", gender);
            command3.Parameters.AddWithValue("@AccountType", accountType);

            command3.ExecuteNonQuery();
            string res = string.Format("\tAccount Created Successfully! \n\nAccount Number: {0}\nPassword: {1}", new_accNumber, password);
            MessageBox.Show(res);
            
        }

        private string passwordGen()
        {
            Random generator = new Random();
            string password = generator.Next(100000, 1000000).ToString();
            return password;
        }

    }
}
