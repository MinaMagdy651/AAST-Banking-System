namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message1Lab = new System.Windows.Forms.Label();
            this.BalanceLab = new System.Windows.Forms.Label();
            this.UserBalanceLab = new System.Windows.Forms.Label();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.UserNameLab = new System.Windows.Forms.Label();
            this.DepositLab = new System.Windows.Forms.Label();
            this.AccountLab = new System.Windows.Forms.Label();
            this.DateLab = new System.Windows.Forms.Label();
            this.transferstat = new System.Windows.Forms.Label();
            this.AmountLab = new System.Windows.Forms.Label();
            this.WithdrawLab = new System.Windows.Forms.Label();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.TxtTranUser = new System.Windows.Forms.TextBox();
            this.TxtTranAmount = new System.Windows.Forms.TextBox();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.dep_with_stat = new System.Windows.Forms.Label();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_askLoan = new System.Windows.Forms.TextBox();
            this.btn_askLoan = new System.Windows.Forms.Button();
            this.askLoan_stat = new System.Windows.Forms.Label();
            this.lbl_debt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payDebt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_expBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_accType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message1Lab
            // 
            this.Message1Lab.AutoSize = true;
            this.Message1Lab.Location = new System.Drawing.Point(27, 21);
            this.Message1Lab.Name = "Message1Lab";
            this.Message1Lab.Size = new System.Drawing.Size(52, 20);
            this.Message1Lab.TabIndex = 0;
            this.Message1Lab.Text = "Hello, ";
            // 
            // BalanceLab
            // 
            this.BalanceLab.AutoSize = true;
            this.BalanceLab.Location = new System.Drawing.Point(27, 77);
            this.BalanceLab.Name = "BalanceLab";
            this.BalanceLab.Size = new System.Drawing.Size(72, 20);
            this.BalanceLab.TabIndex = 1;
            this.BalanceLab.Text = "Balance : ";
            // 
            // UserBalanceLab
            // 
            this.UserBalanceLab.AutoSize = true;
            this.UserBalanceLab.Location = new System.Drawing.Point(89, 77);
            this.UserBalanceLab.Name = "UserBalanceLab";
            this.UserBalanceLab.Size = new System.Drawing.Size(0, 20);
            this.UserBalanceLab.TabIndex = 2;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSignOut.Location = new System.Drawing.Point(772, 447);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(101, 37);
            this.BtnSignOut.TabIndex = 3;
            this.BtnSignOut.Text = "Sign Out";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // UserNameLab
            // 
            this.UserNameLab.AutoSize = true;
            this.UserNameLab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLab.Location = new System.Drawing.Point(70, 21);
            this.UserNameLab.Name = "UserNameLab";
            this.UserNameLab.Size = new System.Drawing.Size(0, 20);
            this.UserNameLab.TabIndex = 4;
            // 
            // DepositLab
            // 
            this.DepositLab.AutoSize = true;
            this.DepositLab.Location = new System.Drawing.Point(27, 141);
            this.DepositLab.Name = "DepositLab";
            this.DepositLab.Size = new System.Drawing.Size(72, 20);
            this.DepositLab.TabIndex = 6;
            this.DepositLab.Text = "Deposit : ";
            // 
            // AccountLab
            // 
            this.AccountLab.AutoSize = true;
            this.AccountLab.Location = new System.Drawing.Point(395, 274);
            this.AccountLab.Name = "AccountLab";
            this.AccountLab.Size = new System.Drawing.Size(36, 20);
            this.AccountLab.TabIndex = 7;
            this.AccountLab.Text = "To : ";
            // 
            // DateLab
            // 
            this.DateLab.AutoSize = true;
            this.DateLab.Location = new System.Drawing.Point(625, 21);
            this.DateLab.Name = "DateLab";
            this.DateLab.Size = new System.Drawing.Size(52, 20);
            this.DateLab.TabIndex = 8;
            this.DateLab.Text = "Date : ";
            // 
            // transferstat
            // 
            this.transferstat.AutoSize = true;
            this.transferstat.Location = new System.Drawing.Point(369, 339);
            this.transferstat.Name = "transferstat";
            this.transferstat.Size = new System.Drawing.Size(0, 20);
            this.transferstat.TabIndex = 10;
            // 
            // AmountLab
            // 
            this.AmountLab.AutoSize = true;
            this.AmountLab.Location = new System.Drawing.Point(27, 274);
            this.AmountLab.Name = "AmountLab";
            this.AmountLab.Size = new System.Drawing.Size(72, 20);
            this.AmountLab.TabIndex = 11;
            this.AmountLab.Text = "Transfer : ";
            // 
            // WithdrawLab
            // 
            this.WithdrawLab.AutoSize = true;
            this.WithdrawLab.Location = new System.Drawing.Point(27, 203);
            this.WithdrawLab.Name = "WithdrawLab";
            this.WithdrawLab.Size = new System.Drawing.Size(80, 20);
            this.WithdrawLab.TabIndex = 12;
            this.WithdrawLab.Text = "Withdraw :";
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(120, 138);
            this.textDeposit.Multiline = true;
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.PlaceholderText = "Enter the amount..";
            this.textDeposit.Size = new System.Drawing.Size(267, 35);
            this.textDeposit.TabIndex = 13;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnDeposit.Location = new System.Drawing.Point(413, 137);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(103, 36);
            this.BtnDeposit.TabIndex = 16;
            this.BtnDeposit.Text = "Deposit ";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // textWithdraw
            // 
            this.textWithdraw.Location = new System.Drawing.Point(120, 200);
            this.textWithdraw.Multiline = true;
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.PlaceholderText = "Enter the amount..";
            this.textWithdraw.Size = new System.Drawing.Size(267, 35);
            this.textWithdraw.TabIndex = 15;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnWithdraw.Location = new System.Drawing.Point(413, 203);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(103, 36);
            this.BtnWithdraw.TabIndex = 16;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // TxtTranUser
            // 
            this.TxtTranUser.Location = new System.Drawing.Point(437, 274);
            this.TxtTranUser.Multiline = true;
            this.TxtTranUser.Name = "TxtTranUser";
            this.TxtTranUser.PlaceholderText = "Account Number..";
            this.TxtTranUser.Size = new System.Drawing.Size(267, 35);
            this.TxtTranUser.TabIndex = 17;
            // 
            // TxtTranAmount
            // 
            this.TxtTranAmount.Location = new System.Drawing.Point(125, 271);
            this.TxtTranAmount.Multiline = true;
            this.TxtTranAmount.Name = "TxtTranAmount";
            this.TxtTranAmount.PlaceholderText = "Enter the amount..";
            this.TxtTranAmount.Size = new System.Drawing.Size(267, 35);
            this.TxtTranAmount.TabIndex = 18;
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnTransfer.Location = new System.Drawing.Point(721, 274);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(103, 36);
            this.BtnTransfer.TabIndex = 19;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // dep_with_stat
            // 
            this.dep_with_stat.AutoSize = true;
            this.dep_with_stat.Location = new System.Drawing.Point(536, 193);
            this.dep_with_stat.Name = "dep_with_stat";
            this.dep_with_stat.Size = new System.Drawing.Size(0, 20);
            this.dep_with_stat.TabIndex = 20;
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnChangePass.Location = new System.Drawing.Point(606, 447);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(144, 37);
            this.BtnChangePass.TabIndex = 21;
            this.BtnChangePass.Text = "Change Password ";
            this.BtnChangePass.UseVisualStyleBackColor = false;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ask For Loan";
            // 
            // txtbox_askLoan
            // 
            this.txtbox_askLoan.Location = new System.Drawing.Point(120, 367);
            this.txtbox_askLoan.Multiline = true;
            this.txtbox_askLoan.Name = "txtbox_askLoan";
            this.txtbox_askLoan.PlaceholderText = "Enter the amount..";
            this.txtbox_askLoan.Size = new System.Drawing.Size(267, 35);
            this.txtbox_askLoan.TabIndex = 23;
            // 
            // btn_askLoan
            // 
            this.btn_askLoan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_askLoan.Location = new System.Drawing.Point(400, 367);
            this.btn_askLoan.Name = "btn_askLoan";
            this.btn_askLoan.Size = new System.Drawing.Size(101, 37);
            this.btn_askLoan.TabIndex = 24;
            this.btn_askLoan.Text = "Ask";
            this.btn_askLoan.UseVisualStyleBackColor = false;
            this.btn_askLoan.Click += new System.EventHandler(this.btn_askLoan_Click);
            // 
            // askLoan_stat
            // 
            this.askLoan_stat.AutoSize = true;
            this.askLoan_stat.Location = new System.Drawing.Point(536, 376);
            this.askLoan_stat.Name = "askLoan_stat";
            this.askLoan_stat.Size = new System.Drawing.Size(0, 20);
            this.askLoan_stat.TabIndex = 25;
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Location = new System.Drawing.Point(243, 77);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(0, 20);
            this.lbl_debt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Debt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pay Debt: ";
            // 
            // payDebt
            // 
            this.payDebt.Location = new System.Drawing.Point(120, 447);
            this.payDebt.Name = "payDebt";
            this.payDebt.PlaceholderText = "Enter the amount..";
            this.payDebt.Size = new System.Drawing.Size(272, 27);
            this.payDebt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(407, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Expected Balance: ";
            // 
            // lbl_expBal
            // 
            this.lbl_expBal.AutoSize = true;
            this.lbl_expBal.Location = new System.Drawing.Point(675, 77);
            this.lbl_expBal.Name = "lbl_expBal";
            this.lbl_expBal.Size = new System.Drawing.Size(0, 20);
            this.lbl_expBal.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Account Type:";
            // 
            // lbl_accType
            // 
            this.lbl_accType.AutoSize = true;
            this.lbl_accType.Location = new System.Drawing.Point(427, 77);
            this.lbl_accType.Name = "lbl_accType";
            this.lbl_accType.Size = new System.Drawing.Size(0, 20);
            this.lbl_accType.TabIndex = 38;
            this.lbl_accType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 526);
            this.Controls.Add(this.lbl_accType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_expBal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payDebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_debt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.askLoan_stat);
            this.Controls.Add(this.btn_askLoan);
            this.Controls.Add(this.txtbox_askLoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.dep_with_stat);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.TxtTranAmount);
            this.Controls.Add(this.TxtTranUser);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.textDeposit);
            this.Controls.Add(this.WithdrawLab);
            this.Controls.Add(this.AmountLab);
            this.Controls.Add(this.transferstat);
            this.Controls.Add(this.DateLab);
            this.Controls.Add(this.AccountLab);
            this.Controls.Add(this.DepositLab);
            this.Controls.Add(this.UserNameLab);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.UserBalanceLab);
            this.Controls.Add(this.BalanceLab);
            this.Controls.Add(this.Message1Lab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Message1Lab;
        private Label BalanceLab;
        private Label UserBalanceLab;
        private Button BtnSignOut;
        private Label UserNameLab;
        private Label DepositLab;
        private Label AccountLab;
        private Label DateLab;
        private Label transferstat;
        private Label AmountLab;
        private Label WithdrawLab;
        private TextBox textDeposit;
        private Button BtnDeposit;
        private TextBox textWithdraw;
        private Button BtnWithdraw;
        private TextBox TxtTranUser;
        private TextBox TxtTranAmount;
        private Button BtnTransfer;
        private Label dep_with_stat;
        private Button BtnChangePass;
        private Label label1;
        private TextBox txtbox_askLoan;
        private Button btn_askLoan;
        private Label askLoan_stat;
        private Label lbl_debt;
        private Label label3;
        private Label label2;
        private TextBox payDebt;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label lbl_expBal;
        private Label label5;
        private Label lbl_accType;
    }
}