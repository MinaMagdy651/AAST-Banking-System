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
            command.Dispose();
            dataReader.Close();
        }
        public User(UInt32 accountNumber) : base(accountNumber)
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
            command.Dispose();
            dataReader.Close();
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
        public bool Withdraw(double val)
        {
            if (val <= Balance && val > 0)
            {
                Balance -= val;
                string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            return false;
        }
        public bool Deposit(double val)
        {

            if (val > 0)
            {
                Balance += val;
                string query = "UPDATE tbl_accounts_data SET Balance = " + Balance + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            return false;
        }

        public bool ChangePassword(string oldpass, string newpass)
        {
            if (base.Password == oldpass)
            {
                base.Password = newpass;

                string query = "UPDATE Users SET Password = '" + base.Password + "' WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            return false;
        }

        public bool AskLoan(double amount)
        {
            if (amount * (double)(0.14) <= (Balance - Debt))
            {
                Debt += amount + amount * (double)(0.14);
                Balance += amount;
                string query = "UPDATE tbl_accounts_data SET Debt = " + Debt + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);

                query = "UPDATE tbl_accounts_data SET Debt = " + Balance + " WHERE AccountNumber = " + Account_Number;
                command = new SqlCommand(query, connect);

                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            return false;
        }

        public bool Transfer(User user2, double val)
        {
            string query = "select * from tbl_accounts_data where AccountNumber = " + user2.Account_Number;
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader dataReader = command.ExecuteReader();

            //datareader has to be closed twice in case of success transfer
            if (dataReader.Read() && val > 0)
            {
                dataReader.Close();
                if (Withdraw(val))
                {
                    user2.Deposit(val);
                    return true;
                }
            }
            dataReader.Close();
            return false;
        }
        public bool paydebt(double val)
        {
            if(val > 0 && Balance >= val && debt >= val)
            {
                Balance -= val;
                debt -= val;
                string query = "UPDATE tbl_accounts_data SET  Balance = " + Balance + " , Debt = " + Debt + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            else if(val > 0 && Balance >= val && val > debt)
            {
                double exceed = val - debt;
                Balance -= debt;
                Balance += exceed;
                string query = "UPDATE tbl_accounts_data SET  Balance = " + Balance + " , Debt = " + 0 + " WHERE AccountNumber = " + Account_Number;
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            
            return false;
        }

        public bool UserFound(UInt32 accountNumber)
        {
            string query = "select * from tbl_accounts_data where AccountNumber = " + accountNumber;
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                dataReader.Close();
                return true;
            }
            dataReader.Close();
            return false;
        }
    }
}