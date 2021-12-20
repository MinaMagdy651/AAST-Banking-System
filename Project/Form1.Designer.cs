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
            this.SuspendLayout();
            // 
            // Message1Lab
            // 
            this.Message1Lab.AutoSize = true;
            this.Message1Lab.Location = new System.Drawing.Point(24, 16);
            this.Message1Lab.Name = "Message1Lab";
            this.Message1Lab.Size = new System.Drawing.Size(41, 15);
            this.Message1Lab.TabIndex = 0;
            this.Message1Lab.Text = "Hello, ";
            this.Message1Lab.Click += new System.EventHandler(this.label1_Click);
            // 
            // BalanceLab
            // 
            this.BalanceLab.AutoSize = true;
            this.BalanceLab.Location = new System.Drawing.Point(24, 58);
            this.BalanceLab.Name = "BalanceLab";
            this.BalanceLab.Size = new System.Drawing.Size(57, 15);
            this.BalanceLab.TabIndex = 1;
            this.BalanceLab.Text = "Balance : ";
            // 
            // UserBalanceLab
            // 
            this.UserBalanceLab.AutoSize = true;
            this.UserBalanceLab.Location = new System.Drawing.Point(78, 58);
            this.UserBalanceLab.Name = "UserBalanceLab";
            this.UserBalanceLab.Size = new System.Drawing.Size(0, 15);
            this.UserBalanceLab.TabIndex = 2;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSignOut.Location = new System.Drawing.Point(633, 325);
            this.BtnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(88, 28);
            this.BtnSignOut.TabIndex = 3;
            this.BtnSignOut.Text = "Sign Out";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // UserNameLab
            // 
            this.UserNameLab.AutoSize = true;
            this.UserNameLab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLab.Location = new System.Drawing.Point(61, 16);
            this.UserNameLab.Name = "UserNameLab";
            this.UserNameLab.Size = new System.Drawing.Size(0, 15);
            this.UserNameLab.TabIndex = 4;
            // 
            // DepositLab
            // 
            this.DepositLab.AutoSize = true;
            this.DepositLab.Location = new System.Drawing.Point(24, 116);
            this.DepositLab.Name = "DepositLab";
            this.DepositLab.Size = new System.Drawing.Size(56, 15);
            this.DepositLab.TabIndex = 6;
            this.DepositLab.Text = "Deposit : ";
            // 
            // AccountLab
            // 
            this.AccountLab.AutoSize = true;
            this.AccountLab.Location = new System.Drawing.Point(348, 216);
            this.AccountLab.Name = "AccountLab";
            this.AccountLab.Size = new System.Drawing.Size(28, 15);
            this.AccountLab.TabIndex = 7;
            this.AccountLab.Text = "To : ";
            // 
            // DateLab
            // 
            this.DateLab.AutoSize = true;
            this.DateLab.Location = new System.Drawing.Point(547, 16);
            this.DateLab.Name = "DateLab";
            this.DateLab.Size = new System.Drawing.Size(40, 15);
            this.DateLab.TabIndex = 8;
            this.DateLab.Text = "Date : ";
            this.DateLab.Click += new System.EventHandler(this.DateLab_Click);
            // 
            // transferstat
            // 
            this.transferstat.AutoSize = true;
            this.transferstat.Location = new System.Drawing.Point(323, 254);
            this.transferstat.Name = "transferstat";
            this.transferstat.Size = new System.Drawing.Size(81, 15);
            this.transferstat.TabIndex = 10;
            this.transferstat.Text = "transfer status";
            // 
            // AmountLab
            // 
            this.AmountLab.AutoSize = true;
            this.AmountLab.Location = new System.Drawing.Point(24, 216);
            this.AmountLab.Name = "AmountLab";
            this.AmountLab.Size = new System.Drawing.Size(57, 15);
            this.AmountLab.TabIndex = 11;
            this.AmountLab.Text = "Transfer : ";
            // 
            // WithdrawLab
            // 
            this.WithdrawLab.AutoSize = true;
            this.WithdrawLab.Location = new System.Drawing.Point(24, 161);
            this.WithdrawLab.Name = "WithdrawLab";
            this.WithdrawLab.Size = new System.Drawing.Size(64, 15);
            this.WithdrawLab.TabIndex = 12;
            this.WithdrawLab.Text = "Withdraw :";
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(105, 113);
            this.textDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDeposit.Multiline = true;
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(234, 27);
            this.textDeposit.TabIndex = 13;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnDeposit.Location = new System.Drawing.Point(361, 113);
            this.BtnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(90, 27);
            this.BtnDeposit.TabIndex = 16;
            this.BtnDeposit.Text = "Deposit ";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // textWithdraw
            // 
            this.textWithdraw.Location = new System.Drawing.Point(105, 161);
            this.textWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWithdraw.Multiline = true;
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(234, 27);
            this.textWithdraw.TabIndex = 15;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnWithdraw.Location = new System.Drawing.Point(361, 161);
            this.BtnWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(90, 27);
            this.BtnWithdraw.TabIndex = 16;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // TxtTranUser
            // 
            this.TxtTranUser.Location = new System.Drawing.Point(382, 216);
            this.TxtTranUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTranUser.Multiline = true;
            this.TxtTranUser.Name = "TxtTranUser";
            this.TxtTranUser.Size = new System.Drawing.Size(234, 27);
            this.TxtTranUser.TabIndex = 17;
            // 
            // TxtTranAmount
            // 
            this.TxtTranAmount.Location = new System.Drawing.Point(105, 216);
            this.TxtTranAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTranAmount.Multiline = true;
            this.TxtTranAmount.Name = "TxtTranAmount";
            this.TxtTranAmount.Size = new System.Drawing.Size(234, 27);
            this.TxtTranAmount.TabIndex = 18;
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnTransfer.Location = new System.Drawing.Point(631, 216);
            this.BtnTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(90, 27);
            this.BtnTransfer.TabIndex = 19;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            // 
            // dep_with_stat
            // 
            this.dep_with_stat.AutoSize = true;
            this.dep_with_stat.Location = new System.Drawing.Point(469, 145);
            this.dep_with_stat.Name = "dep_with_stat";
            this.dep_with_stat.Size = new System.Drawing.Size(0, 15);
            this.dep_with_stat.TabIndex = 20;
            this.dep_with_stat.Click += new System.EventHandler(this.dep_with_stat_Click);
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnChangePass.Location = new System.Drawing.Point(490, 325);
            this.BtnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(126, 28);
            this.BtnChangePass.TabIndex = 21;
            this.BtnChangePass.Text = "Change Password ";
            this.BtnChangePass.UseVisualStyleBackColor = false;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ask For Loan";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbox_askLoan
            // 
            this.txtbox_askLoan.Location = new System.Drawing.Point(105, 275);
            this.txtbox_askLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_askLoan.Multiline = true;
            this.txtbox_askLoan.Name = "txtbox_askLoan";
            this.txtbox_askLoan.Size = new System.Drawing.Size(234, 27);
            this.txtbox_askLoan.TabIndex = 23;
            // 
            // btn_askLoan
            // 
            this.btn_askLoan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_askLoan.Location = new System.Drawing.Point(350, 275);
            this.btn_askLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_askLoan.Name = "btn_askLoan";
            this.btn_askLoan.Size = new System.Drawing.Size(88, 28);
            this.btn_askLoan.TabIndex = 24;
            this.btn_askLoan.Text = "Ask";
            this.btn_askLoan.UseVisualStyleBackColor = false;
            // 
            // askLoan_stat
            // 
            this.askLoan_stat.AutoSize = true;
            this.askLoan_stat.Location = new System.Drawing.Point(469, 282);
            this.askLoan_stat.Name = "askLoan_stat";
            this.askLoan_stat.Size = new System.Drawing.Size(55, 15);
            this.askLoan_stat.TabIndex = 25;
            this.askLoan_stat.Text = "Loan stat";
            this.askLoan_stat.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Location = new System.Drawing.Point(213, 58);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(0, 15);
            this.lbl_debt.TabIndex = 27;
            this.lbl_debt.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Debt:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}