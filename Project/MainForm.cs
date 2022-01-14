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
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
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
            OpenFormChild(new Deposit(1), sender);
        }
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            OpenFormChild(new lgnfrm(), sender);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_debt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_changepw_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

    }
}
