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
    public partial class Deposit : Form
    {
        User user1;
        public Deposit()
        {
            InitializeComponent();
        }
        public Deposit(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
            lbl_balance.Text = Convert.ToString(user1.Balance);
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Double.Parse(textDeposit.Text);

                if (user1.Deposit(val))
                {
                    lbl_depStat.Text = "Succesful transaction";
                    lbl_bal.Text = Convert.ToString(user1.Balance);
                }
                else
                {
                    lbl_depStat.Text = "Please enter a valid amount";
                }
                textDeposit.Clear();
            }
            catch (Exception ex)
            {
                textDeposit.Clear();
                lbl_depStat.Text = "Please enter a valid amount";
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void textDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_balance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_depStat_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bal_Click(object sender, EventArgs e)
        {

        }
    }
  
}
