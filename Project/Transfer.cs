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
    public partial class Transfer : Form
    {
        User user1;
        public Transfer()
        {
            InitializeComponent();
        }
        public Transfer(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
            lbl_balance.Text = Convert.ToString(user1.Balance);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Double.Parse(TxtTranAmount.Text);
                UInt32 user2_acc_num = UInt32.Parse(TxtTranUser.Text);
                User user2 = new User(user2_acc_num);
                if (user1.Account_Number == user2.Account_Number)
                {
                    transferstat.Text = "Can not transfer money to your own account";
                    TxtTranUser.Clear();
                    TxtTranAmount.Clear();
                }
                else if (user1.Transfer(user2, val))
                {
                    transferstat.Text = string.Format("Transfered ${0} to: {1}", val, user2.Name);
                    lbl_balance.Text = Convert.ToString(user1.Balance);
                    TxtTranUser.Clear();
                    TxtTranAmount.Clear();
                }
                else
                {
                    transferstat.Text = "Insufficient amount or account doesn't exist";
                    TxtTranUser.Clear();
                    TxtTranAmount.Clear();
                }

            }
            catch (Exception )
            {
                TxtTranUser.Clear();
                TxtTranAmount.Clear();
                transferstat.Text= "Pleanser Enter valid data";
            }
        }
    }
}
