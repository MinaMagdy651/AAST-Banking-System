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
            //update 4

            if(!string.IsNullOrEmpty(usernametxt.Text) && usernametxt.Text.All(char.IsNumber) && !string.IsNullOrEmpty(passwordtxt.Text))
            {
                Person p = new Person(Convert.ToUInt32(usernametxt.Text), passwordtxt.Text);
                passwordtxt.Clear();
    
                if (p.loginCheck() )
                {
                    if (p.AdminLvl == 0)
                    {
                        this.Hide();
                        Form1 frm = new Form1(p.Account_Number);
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    }
                    else
                    {
                        this.Hide();
                        TellerForm frm2 = new TellerForm();
                        frm2.Closed += (s, args) => this.Close();
                        frm2.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data");
                usernametxt.Clear();
            }
            
        }

        private void lgnfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
