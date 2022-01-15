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
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Button cButton;
        private Form activeForm;
        private Panel leftpanel;

        UInt32 accNum;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(UInt32 num)
        {

            InitializeComponent();
            accNum = num;
            HomeScreen homeScreen = new HomeScreen(num);
            activeForm = homeScreen;
            homeScreen.TopLevel = false;
            homeScreen.FormBorderStyle = FormBorderStyle.None;
            homeScreen.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Add(homeScreen);
            this.panelDeskTop.Tag = homeScreen;
            homeScreen.BringToFront();
            homeScreen.Show();  
            leftpanel = new Panel();
            leftpanel.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftpanel);

        }

        private Color SelectThemeColor()
        {
            return ColorTranslator.FromHtml("#FFA500");
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void OpenFormChild(Form childForm, object btnSender)
        {
            DisableButton();
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Add(childForm);
            this.panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Deposit(accNum), sender);
        }
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Withdraw(accNum), sender);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Transfer(accNum), sender);
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Loan(accNum), sender);
        }

        private void btn_debt_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Debt(accNum), sender);
        }

        private void btn_changepw_Click(object sender, EventArgs e)
        {
            OpenFormChild(new ChangePass(accNum), sender);
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            lgnfrm newlgn = new lgnfrm();
            newlgn.Closed += (s, args) => this.Close();
            newlgn.Show();
        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            DisableButton();
            OpenFormChild(new HomeScreen(accNum), sender);
            btn_home.BackColor = Color.FromArgb(39, 39, 58);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
       
}
