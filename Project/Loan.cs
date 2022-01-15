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
    public partial class Loan : Form
    {
        User user1;
        public Loan()
        {
            InitializeComponent();
        }
        public Loan(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
            lbl_balance.Text = Convert.ToString(user1.Balance);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Double.Parse(txtbox_askLoan.Text);
                if (user1.AskLoan(val))
                {
                    lbl_balance.Text = Convert.ToString(user1.Balance);
                    askLoan_stat.Text = string.Format("Succesfully added ${0} to your account", val);
                    txtbox_askLoan.Clear();
                }
                else
                {
                    askLoan_stat.Text = "You are not eligble for this loan";
                    txtbox_askLoan.Clear();
                }

            }
            catch (Exception)
            {
                askLoan_stat.Text = "Pleas enter a valid amount";
                txtbox_askLoan.Clear();
            }
        }
    }
}
