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
    public partial class AddUser : Form
    {
        teller Teller = new teller();
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TellerForm tellerform = new TellerForm();
            tellerform.Closed += (s, args) => this.Close();
            tellerform.Show();
        }

        private void chck_female_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_female.Checked)
            {
                chck_male.Checked = false;
            }
        }

        private void chck_male_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_male.Checked)
            {
                chck_female.Checked = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                char gender = 'X';
                string name = txt_name.Text;
                string email = txt_email.Text;
                string address = txt_address.Text;
                string phone = txt_Phone.Text;
                double balance = Convert.ToDouble(txt_balance.Text);
 

                if (chck_male.Checked)
                {
                    gender = 'M';
                }
                else if (chck_female.Checked)
                {
                    gender = 'F';
                }
                if (balance <= 0 || gender == 'X')
                {
                    throw new Exception();
                }
                Teller.adddUser(name, balance, email, phone, address, gender);
            }
           
            catch
            {
                txt_name.Clear();
                txt_email.Clear();
                txt_address.Clear();
                txt_Phone.Clear();
                txt_balance.Clear();
                chck_female.Checked = false;
                chck_male.Checked = false;
                MessageBox.Show("Please enter valid data");
                
            }

        }
    }
}
