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
            this.WithdrawStat = new System.Windows.Forms.Label();
            this.AmountLab = new System.Windows.Forms.Label();
            this.WithdrawLab = new System.Windows.Forms.Label();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.TxtTranUser = new System.Windows.Forms.TextBox();
            this.TxtTranAmount = new System.Windows.Forms.TextBox();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.TranStat = new System.Windows.Forms.Label();
            this.BtnChangePass = new System.Windows.Forms.Button();
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
            this.UserBalanceLab.Location = new System.Drawing.Point(93, 58);
            this.UserBalanceLab.Name = "UserBalanceLab";
            this.UserBalanceLab.Size = new System.Drawing.Size(38, 15);
            this.UserBalanceLab.TabIndex = 2;
            this.UserBalanceLab.Text = "label3";
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSignOut.Location = new System.Drawing.Point(621, 314);
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
            this.UserNameLab.Location = new System.Drawing.Point(95, 16);
            this.UserNameLab.Name = "UserNameLab";
            this.UserNameLab.Size = new System.Drawing.Size(38, 15);
            this.UserNameLab.TabIndex = 4;
            this.UserNameLab.Text = "label4";
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
            this.AccountLab.Location = new System.Drawing.Point(422, 180);
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
            // WithdrawStat
            // 
            this.WithdrawStat.AutoSize = true;
            this.WithdrawStat.Location = new System.Drawing.Point(348, 148);
            this.WithdrawStat.Name = "WithdrawStat";
            this.WithdrawStat.Size = new System.Drawing.Size(72, 15);
            this.WithdrawStat.TabIndex = 10;
            this.WithdrawStat.Text = "Emtpy Lable";
            // 
            // AmountLab
            // 
            this.AmountLab.AutoSize = true;
            this.AmountLab.Location = new System.Drawing.Point(24, 180);
            this.AmountLab.Name = "AmountLab";
            this.AmountLab.Size = new System.Drawing.Size(57, 15);
            this.AmountLab.TabIndex = 11;
            this.AmountLab.Text = "Transfer : ";
            // 
            // WithdrawLab
            // 
            this.WithdrawLab.AutoSize = true;
            this.WithdrawLab.Location = new System.Drawing.Point(383, 116);
            this.WithdrawLab.Name = "WithdrawLab";
            this.WithdrawLab.Size = new System.Drawing.Size(64, 15);
            this.WithdrawLab.TabIndex = 12;
            this.WithdrawLab.Text = "Withdraw :";
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(93, 113);
            this.textDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDeposit.Multiline = true;
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(139, 27);
            this.textDeposit.TabIndex = 13;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnDeposit.Location = new System.Drawing.Point(236, 113);
            this.BtnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(90, 26);
            this.BtnDeposit.TabIndex = 16;
            this.BtnDeposit.Text = "Deposit ";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            // 
            // textWithdraw
            // 
            this.textWithdraw.Location = new System.Drawing.Point(475, 113);
            this.textWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWithdraw.Multiline = true;
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(139, 27);
            this.textWithdraw.TabIndex = 15;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnWithdraw.Location = new System.Drawing.Point(619, 113);
            this.BtnWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(90, 26);
            this.BtnWithdraw.TabIndex = 16;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            // 
            // TxtTranUser
            // 
            this.TxtTranUser.Location = new System.Drawing.Point(475, 178);
            this.TxtTranUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTranUser.Multiline = true;
            this.TxtTranUser.Name = "TxtTranUser";
            this.TxtTranUser.Size = new System.Drawing.Size(234, 27);
            this.TxtTranUser.TabIndex = 17;
            // 
            // TxtTranAmount
            // 
            this.TxtTranAmount.Location = new System.Drawing.Point(93, 180);
            this.TxtTranAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTranAmount.Multiline = true;
            this.TxtTranAmount.Name = "TxtTranAmount";
            this.TxtTranAmount.Size = new System.Drawing.Size(234, 27);
            this.TxtTranAmount.TabIndex = 18;
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnTransfer.Location = new System.Drawing.Point(348, 214);
            this.BtnTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(90, 26);
            this.BtnTransfer.TabIndex = 19;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            // 
            // TranStat
            // 
            this.TranStat.AutoSize = true;
            this.TranStat.Location = new System.Drawing.Point(348, 259);
            this.TranStat.Name = "TranStat";
            this.TranStat.Size = new System.Drawing.Size(72, 15);
            this.TranStat.TabIndex = 20;
            this.TranStat.Text = "Emtpy Lable";
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnChangePass.Location = new System.Drawing.Point(24, 314);
            this.BtnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(126, 28);
            this.BtnChangePass.TabIndex = 21;
            this.BtnChangePass.Text = "Change Password ";
            this.BtnChangePass.UseVisualStyleBackColor = false;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 364);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.TranStat);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.TxtTranAmount);
            this.Controls.Add(this.TxtTranUser);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.textDeposit);
            this.Controls.Add(this.WithdrawLab);
            this.Controls.Add(this.AmountLab);
            this.Controls.Add(this.WithdrawStat);
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
        private Label WithdrawStat;
        private Label AmountLab;
        private Label WithdrawLab;
        private TextBox textDeposit;
        private Button BtnDeposit;
        private TextBox textWithdraw;
        private Button BtnWithdraw;
        private TextBox TxtTranUser;
        private TextBox TxtTranAmount;
        private Button BtnTransfer;
        private Label TranStat;
        private Button BtnChangePass;
    }
}