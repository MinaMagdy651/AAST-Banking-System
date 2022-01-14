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
    public partial class HomeScreen : Form
    {
        User user1;
        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen(UInt32 num)
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
            UserNameLab.Text = user1.Name;
            UserBalanceLab.Text = Convert.ToString(user1.Balance);
            lbl_debt.Text = Convert.ToString(user1.Debt);
            lbl_expBal.Text = Convert.ToString(user1.GetBalance());
            lbl_accType.Text = user1.GetType();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
