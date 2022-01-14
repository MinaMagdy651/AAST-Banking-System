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
            if (user1.AccountType == 1)
            {
                user1 = new FixedAccount(num);
            }
            else
            {
                user1 = new SavingAccount(num);
            }
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
                    textDeposit.Clear();
                }
            }
            catch (Exception ex)
            {
                textDeposit.Clear();
                lbl_depStat.Text = "Please enter a valid amount";
            }
        }
    }
  
}
