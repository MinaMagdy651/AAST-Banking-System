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
    public partial class Debt : Form
    {
        User user1;
        public Debt(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
            lbl_balance.Text = Convert.ToString(user1.Balance);
            lbl_debt.Text = Convert.ToString(user1.Debt);
        }
        public Debt()
        {
            InitializeComponent();
        }

        private void btn_debt_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Double.Parse(txtbox_debt.Text);
                if (user1.Debt == 0)
                {
                    debt_stat.Text = "You Don't Have Any Debt";
                    txtbox_debt.Clear();
                }

                else if (user1.paydebt(val))
                {
                    lbl_balance.Text = Convert.ToString(user1.Balance);
                    lbl_debt.Text = Convert.ToString(user1.Debt);
                    debt_stat.Text = "Completed Successfully";
                }
                else
                {
                    debt_stat.Text = "Please Enter A Valid Amount";
                }
                txtbox_debt.Clear();

            }
            catch (Exception)
            {
                debt_stat.Text = "Please Enter A Valid Amount";
                txtbox_debt.Clear();
            }
        }

    }
}
