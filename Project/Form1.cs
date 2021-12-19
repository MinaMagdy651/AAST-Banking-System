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
        User user1;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(UInt32 num, string pass)
        {
            user1 = new User(num, pass);
            InitializeComponent();
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLab.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass chng = new ChangePass();
            chng.Show();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            lgnfrm newlgn = new lgnfrm();
            newlgn.Closed += (s, args) => this.Close();
            newlgn.Show();
        }

        private void DateLab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user1.Name);
        }
    }
}
