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
        User u1;
        public ChangePass()
        {
            InitializeComponent();
        }
        public ChangePass(UInt32 accNumber, string pass)
        {
            u1 = new User(accNumber, pass);
            InitializeComponent();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrEmpty(TxtOldPass.Text) && !string.IsNullOrEmpty(TxtNewPass.Text))
            {
                if (u1.ChangePassword(TxtOldPass.Text, TxtNewPass.Text))
                {
                    ChangePassStat.Text = "Password changed succesfully";
                }
                else
                {
                    ChangePassStat.Text = "Password doesn't match";
                    TxtOldPass.Clear();
                    TxtNewPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data");
                TxtOldPass.Clear();
                TxtNewPass.Clear();
            } */
            u1.ChangePassword("mina", "a7a");

        }
    }
}
