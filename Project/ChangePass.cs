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
    public partial class ChangePass : Form
    {
        User user1;
        public ChangePass()
        {
            InitializeComponent();
        }
        public ChangePass(UInt32 num)
        {
            user1 = new User(num);
            InitializeComponent();
        }


        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {

                if (user1.ChangePassword(TxtOldPass.Text, TxtNewPass.Text))
                {
                    ChangePassStat.Text = "Password changed succesfully";
                }
                else
                {
                    ChangePassStat.Text = "Password doesn't match";
                }
                TxtOldPass.Clear();
                TxtNewPass.Clear();
            }
            catch (Exception ex)
            {
                ChangePassStat.Text = "Password doesn't match";
                TxtOldPass.Clear();
                TxtNewPass.Clear();
            }
        }
    }
}
