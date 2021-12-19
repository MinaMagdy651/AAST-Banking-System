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
        double balance;
        private double debt;
        private char gender;

        private SqlConnection connect;

        

       



        public User(UInt32 accountNumber, string pass) : base(accountNumber, pass) 
        {
            string path = System.Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "DataBase" + "\\DB.mdf";


            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path2 + ";Integrated Security=True");
            try
            {
                connect.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error while connection to SQL server");
            }

            string query = "select * from tbl_accounts_data where AccountNumber = " + Account_Number;

            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                name = (string)dataReader.GetValue(1);
                address = (string)(dataReader.GetValue(2));
                phone = (string)(dataReader.GetValue(3));
                email = (string)(dataReader.GetValue(4));
                AccountType = Int32.Parse("" + dataReader.GetValue(5));
                balance = Double.Parse("" + dataReader.GetValue(6));
                debt = Double.Parse("" + dataReader.GetValue(7));
                gender = Convert.ToChar("" + dataReader.GetValue(8));
            }
            else
            {
                Console.WriteLine("Error while parsing data from SQL tables");
            }

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
        /// <summary>
        /// changes may apply
        /// </summary>
      
        public double Debt
        {
            get { return debt; }
            set { debt = value; }
        }
        public char Gender
        {
                get { return gender; }
                set { gender = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Withdraw(double val)
        {
            
            if (val <= Balance)
            {
                Balance -= val;
                string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
            }
         return Balance;
        }
        public double Deposit(double val)
        {

            if (val > 0)
                Balance += val;
            string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
            SqlCommand command = new SqlCommand(query, connect);

            return Balance;
        }

        public void ChangePassword(string oldpass , string newpass)
        {
            string query1 = "select * from Users where AccountNumber = " + Account_Number;
            SqlCommand command1 = new SqlCommand(query1, connect);
            SqlDataReader dataReader = command1.ExecuteReader();

            string pass = (string)dataReader.GetValue(1);
            if (pass == oldpass)
            {
                string query = "UPDATE Users SET Password = " + newpass + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
            }
        }
        public bool AskLoan(double amount)
        {
           

            if (Balance >= (amount + (amount * (double)0.10)) && debt == 0)
                //debt = amount + (amount * (decimal)0.10);
                return true;
            
        return false;
        }
        
        public static void Transfer(User user1, User user2, double val)
        {
            UInt32 account2 = user2.Account_number;
            string query1 = "select * from tbl_accounts_data where AccountNumber = " + account2;
            SqlCommand command1 = new SqlCommand(query1, user2.connect);
            SqlDataReader dataReader = command1.ExecuteReader();

            
            if (dataReader.Read() && val > 0)
            {   
                double bal = user1.Balance;
                double newbal1 = user1.Withdraw(val);
                if (bal != newbal1)
                {
                    double newbal2 = user2.Balance + val;
                    string query = "UPDATE tbl_accounts_data SET Balance = " + newbal2 + " WHERE AccountNumber = " + user2.Account_Number;
                    SqlCommand command = new SqlCommand(query, user2.connect);
                }
            }
        }







    }
}
