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

        private void button1_Click(object sender, EventArgs e)
        {


            try
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
                    AccNum.Clear();
           
                }
            }
            catch (Exception)
            {
                label2.Text = "The entered data is invalid";
                AccNum.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
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
                    label2.ForeColor = Color.Black;
                    AccNum.Clear();
                }
            }
            catch(Exception)
            {
                label2.Text = "The entered data is invalid..";
                label2.ForeColor = Color.Black;
                AccNum.Clear();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lgnfrm newlgn = new lgnfrm();
            newlgn.Closed += (s, args) => this.Close();
            newlgn.Show();
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

            try
            {
                UInt32 accountnumber = Convert.ToUInt32(AccNum.Text);
                Teller = new teller();

                if (Teller.deleteData(accountnumber))
                    label2.Text = "Account has been deleted";
                else

                    label2.Text = "Account number not found";
                AccNum.Clear();
            }
            catch (Exception)
            {
                label2.Text = "The entered data is invalid..";
                AccNum.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
