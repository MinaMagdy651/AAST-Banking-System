using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    internal class User : Person
    {
        private string name;
        private string address;
        private string phone;
        private string email;
        private int account_type;
        private decimal balance;
        private decimal debt;
        private char gender;

        private SqlConnection connect;

        

        public User( UInt32 number, string password) : base(number, password)
        {
            
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\BankSystem4\Project\DataBase\DB.mdf;Integrated Security=True");
            try
            {
                connect.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error while connection to SQL server");
            }

            string query = "select * from tbl_accounts_data where AccountNumber = " + base.Account_number;
            
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader dataReader = command.ExecuteReader();
            
            name =  (string)dataReader.GetValue(1);
            address =  (string)(dataReader.GetValue(2));
           /* phone = (string)(dataReader.GetValue(3));
            email = (string)(dataReader.GetValue(4));
            account_type = (int)(dataReader.GetValue(5));
            balance = (decimal)dataReader.GetValue(6);
            debt = (decimal)dataReader.GetValue(7);
            gender =   (char)dataReader.GetValue(8);*/

        }



        public User(UInt32 account) : base(account) 
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\BankSystem4\Project\DataBase\DB.mdf;Integrated Security=True");
            try
            {
                connect.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error while connection to SQL server");
            }

            string query = "select * from tbl_accounts_data where AccountNumber = " + base.Account_Number;

            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader dataReader = command.ExecuteReader();

            name = (string)dataReader.GetValue(1);
            address = (string)(dataReader.GetValue(2));
          /*  phone = (string)(dataReader.GetValue(3));
            email = (string)(dataReader.GetValue(4));
            account_type = (int)(dataReader.GetValue(5));
            balance = (decimal)dataReader.GetValue(6);
            debt = (decimal)dataReader.GetValue(7);
            gender = (char)dataReader.GetValue(8);*/
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int AccountType
        {
            get { return account_type; }
            set { account_type = value; }
        }
        public decimal Balance
        {
            get {
                string query1 = "select * from tbl_accounts_data where AccountNumber = " + Account_Number;

                SqlCommand command1 = new SqlCommand(query1, connect);
                SqlDataReader dataReader = command1.ExecuteReader();
                return (decimal)dataReader.GetValue(6);
            }
            set
            {
               balance = value;
            }
        }
        public decimal Debt
        {
            get { return debt; }
            set { debt = value; }
        }
        public char Gender
        {
                get { return gender; }
                set { gender = value; }
        }

        public decimal withdraw(decimal val)
        {
            
            if (val >= Balance)
            {
                Balance -= val;
                string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
            }
         return Balance;
        }
        public decimal deposit(decimal val)
        {

            if (val > 0)
                Balance += val;
            string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
            SqlCommand command = new SqlCommand(query, connect);

            return Balance;
        }

        public void changePassword(string oldpass , string newpass)
        {
            string query1 = "select * from Users where AccountNumber = " + Account_Number;
            SqlCommand command1 = new SqlCommand(query1, connect);
            SqlDataReader dataReader = command1.ExecuteReader();

            String pass = (string)dataReader.GetValue(1);
            if (pass == oldpass)
            {
                string query = "UPDATE Users SET Password = " + newpass + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
            }
        }
        public bool askLoan(decimal amount)
        {
           

            if (Balance >= (amount + (amount * (decimal)0.10)) && debt == 0)
                //debt = amount + (amount * (decimal)0.10);
                return true;
            
        return false;
        }
        
        public static void Transfer(User user1  , User user2, decimal val)
        {
            UInt32 account2 = user2.Account_number;
            string query1 = "select * from tbl_accounts_data where AccountNumber = " + account2;
            SqlCommand command1 = new SqlCommand(query1, user2.connect);
            SqlDataReader dataReader = command1.ExecuteReader();

            
            if (dataReader.Read() && val > 0)
            {   
                decimal bal = user1.Balance;
                decimal newbal1 = user1.withdraw(val);
                if (bal != newbal1)
                {
                    decimal newbal2 = user2.Balance + val;
                    string query = "UPDATE tbl_accounts_data SET Balance = " + newbal2 + " WHERE AccountNumber = " + user2.Account_Number;
                    SqlCommand command = new SqlCommand(query, user2.connect);
                }
            }
        }







    }
}
