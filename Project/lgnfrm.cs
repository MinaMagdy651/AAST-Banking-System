using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class lgnfrm : Form
    {
        public lgnfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_lgin_Click(object sender, EventArgs e)
        {
            //update 3
            Person p = new Person(Convert.ToUInt32(usernametxt.Text), passwordtxt.Text);
            p.loginCheck();
            if (p.found)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }
    }
}
