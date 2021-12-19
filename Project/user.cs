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

            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\BankSystem\Project\DataBase\DB.mdf;Integrated Security=True");
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

            name =  (string)dataReader.GetValue(1);
            address =  (string)(dataReader.GetValue(2));
            phone = (string)(dataReader.GetValue(3));
            email = (string)(dataReader.GetValue(4));
            account_type = (int)(dataReader.GetValue(5));
            balance = (decimal)dataReader.GetValue(6);
            debt = (decimal)dataReader.GetValue(7);
            gender =   (char)dataReader.GetValue(8);

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
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }
    }
}
