using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class lgnfrm : Form
    {
        public lgnfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_lgin_Click(object sender, EventArgs e)
        {

            Person p = new Person(Convert.ToUInt32(usernametxt.Text), passwordtxt.Text);


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\mina aast\Term 5\Advanced programming\Project\Project\DataBase\DB.mdf';Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("There is an error while establishing a connection with the SqlServer");
            }

            string query = "select * from Users where AccountNumber = " + p.Account_Number;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if(p.Password != (string)dataReader.GetValue(1))
                {
                    MessageBox.Show("Wrong Password");
                }
                p.AdminLvl = Convert.ToInt32(dataReader.GetValue(2));
            }
            else
            {
                MessageBox.Show("Account Number not found");
            }
        }
    }
}
