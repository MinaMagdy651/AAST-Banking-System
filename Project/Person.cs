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
        private SqlConnection con;


        public Person(UInt32 number, string password)
        {
            account_number = number;
            this.password = password;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\mina aast\Term 5\Advanced programming\Project\Project\DataBase\DB.mdf';Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error while connection to SQL server");
            }

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
        public void loginCheck()
        {
            string query = "select * from Users where AccountNumber = " + Account_Number;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if (Password != (string)dataReader.GetValue(1))
                {
                    MessageBox.Show("Wrong Password");
                }
                AdminLvl = Convert.ToInt32(dataReader.GetValue(2));
            }
            else
            {
                MessageBox.Show("Account Number not found");
            }
        }
        
    }
}
