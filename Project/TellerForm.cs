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
    public partial class TellerForm : Form
    {
        teller Teller ;
        public TellerForm()
        {
            InitializeComponent();
        }
        public TellerForm(UInt32 Accountnumber,string pass)
        {
            Teller = new teller();
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(AccNum.Text) && AccNum.Text.All(char.IsNumber))
            {
                UInt32 accountnumber = Convert.ToUInt32(AccNum.Text);
                User user1 = new User(accountnumber);

                if (user1.Found)
                {
                    this.Hide();
                    UserData frm = new UserData(accountnumber);
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    label2.Text = "Account number not found..";
                }
            }
            else
            {
                label2.Text = "The entered data is invalid..";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AccNum.Text) && AccNum.Text.All(char.IsNumber))
            {
                UInt32 accountnumber = Convert.ToUInt32(AccNum.Text);
                User user1 = new User(accountnumber);

                if (user1.Found)
                {
                    this.Hide();
                    UserEdit frm = new UserEdit(accountnumber);
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    label2.Text = "Account number not found..";
                }
            }
            else
            {
                label2.Text = "The entered data is invalid..";
            }
        }

        private void AccNum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lgnfrm newlgn = new lgnfrm();
            newlgn.Closed += (s, args) => this.Close();
            newlgn.Show();
        }

        private void TellerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser adduser = new AddUser();
            adduser.Closed += (s, args) => this.Close();
            adduser.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(AccNum.Text) && AccNum.Text.All(char.IsNumber))
            {
                UInt32 accountnumber = Convert.ToUInt32(AccNum.Text);
                Teller = new teller();

                if (Teller.deleteData(accountnumber))
                    label2.Text = "Account has been deleted";
                else

                    label2.Text = "Account number not found";
            }
            else
            {
                label2.Text = "The entered data is invalid..";
            }
        }
    }
}
