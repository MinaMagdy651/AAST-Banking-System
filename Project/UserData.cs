using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserData : Form
    {
        User user2;
        public UserData()
        {
            InitializeComponent();
        }
        public UserData(UInt32 account)
        {
            user2 = new User(account);
            InitializeComponent();
            name.Text = user2.Name;
            balance.Text = Convert.ToString(user2.Balance);
            email.Text =  user2.Email;
            phone.Text = user2.Phone; 
            address.Text = user2.Address;
            debt.Text = Convert.ToString(user2.Debt);
            Accnum.Text = Convert.ToString(account);
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TellerForm tellerform = new TellerForm();
            tellerform.Closed += (s, args) => this.Close();
            tellerform.Show();
        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            TellerForm tellerform = new TellerForm();
            tellerform.Closed += (s, args) => this.Close();
            tellerform.Show();
        }
    }
}
