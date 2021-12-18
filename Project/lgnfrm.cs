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
            //MessageBox.Show("Testing push COMMAND");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='K:\AAST\Terme 5\Advanced Programming\Project\Project 7\Project\DataBase\DB.mdf';Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("There is an error while establishing a connection with the SqlServer");
                Console.ReadKey();
            }
            string query = "select * from Users where AccountNumber = " + 1;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show((string)dataReader.GetValue(1));
            }
        }
    }
}
