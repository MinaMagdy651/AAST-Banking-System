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
    public partial class Form1 : Form
    {
        User user1;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(UInt32 num, string pass)
        {
            user1 = new User(num, pass);
            InitializeComponent();
            UserNameLab.Text = user1.Name;
            UserBalanceLab.Text = Convert.ToString(user1.Balance);
            lbl_debt.Text = Convert.ToString(user1.Debt);
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLab.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass chng = new ChangePass(user1.Account_Number, user1.Password);
            chng.Show();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            lgnfrm newlgn = new lgnfrm();
            newlgn.Closed += (s, args) => this.Close();
            newlgn.Show();
        }

        private void DateLab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDeposit.Text) && textDeposit.Text.All(char.IsNumber))
            {
                double val = Double.Parse(textDeposit.Text);
           
                if (user1.Deposit(val))
                {
                    dep_with_stat.Text = "Succesful transaction";
                    UserBalanceLab.Text = Convert.ToString(user1.Balance);
                    textDeposit.Clear();
                }
                else
                {
                    textDeposit.Clear();
                    dep_with_stat.Text = "Please enter a valid amount";
                }
            }
            else
            {
                textDeposit.Clear();
                dep_with_stat.Text = "Please enter a valid amount";
            }
                
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textWithdraw.Text) && textWithdraw.Text.All(char.IsNumber))
            {
                double val = Double.Parse(textWithdraw.Text);
                if (user1.Withdraw(val))
                {
                    dep_with_stat.Text = "Succesful transaction";
                    UserBalanceLab.Text = Convert.ToString(user1.Balance);
                    textWithdraw.Clear();
                }
                else
                {
                    dep_with_stat.Text = "Please enter a valid amount";
                    textWithdraw.Clear();
                }
            }
            else
            {
                dep_with_stat.Text = "Please enter a valid amount";
                textWithdraw.Clear();
            }

        }

        private void dep_with_stat_Click(object sender, EventArgs e)
        {

        }

        private void transferstat_Click(object sender, EventArgs e)
        {

        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
