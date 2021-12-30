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
    public partial class UserEdit : Form
    {
        User user1;
        teller Teller;
        public UserEdit()
        {
            InitializeComponent();
        }
        public UserEdit(UInt32 accountnumber)
        {
            user1 = new User(accountnumber);
            Teller = new teller(accountnumber);
            InitializeComponent();
            name.Text = user1.Name;
            balance.Text = Convert.ToString(user1.Balance);
            debt.Text = Convert.ToString(user1.Debt);
            AccNum.Text = Convert.ToString(accountnumber);
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TellerForm tellerform = new TellerForm();
            tellerform.Closed += (s, args) => this.Close();
            tellerform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(phonenumber.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(address.Text))
            {
                label4.Text = "Please enter the valid data!!";
            }
            else if (phonenumber.Text.All(char.IsNumber) && !string.IsNullOrEmpty(phonenumber.Text) 
                && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(address.Text))
            {
                if (Teller.EditData(user1.Account_Number, user1.Name, email.Text, phonenumber.Text, address.Text))
                {
                    label4.Text = "New data has been updated..";
                }
                else
                    label4.Text = "Please, Try again..";
                
            }
        }
    }
}
