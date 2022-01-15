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
    public partial class Withdraw : Form
    {
        User user1;
        public Withdraw()
        {
            InitializeComponent();
        }
        public Withdraw(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
            lbl_balance.Text = Convert.ToString(user1.Balance);
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Double.Parse(textWithdraw.Text);

                if (user1.Withdraw(val))
                {
                    lbl_WithdrawStat.Text = "Succesful transaction";
                    lbl_bal.Text = Convert.ToString(user1.Balance);
                }
                else
                {
                    lbl_WithdrawStat.Text = "Please enter a valid amount";
                }
                textWithdraw.Clear();
            }
            catch (Exception )
            {
                textWithdraw.Clear();
                lbl_WithdrawStat.Text = "Please enter a valid amount";
            }
        }
    }
}
