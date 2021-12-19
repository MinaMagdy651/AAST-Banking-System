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
        private lgnfrm frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Form1(UInt32 account, string pass)
        {
            Account = account;
            password = pass;
        }
        public UInt32 Account;
        public string password;

        public void load()
        {
            User u = new User(Account, password);
            label1.Text = u.getName();
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
           
        }



    }
}
