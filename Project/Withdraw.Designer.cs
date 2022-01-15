namespace Project
{
    partial class Withdraw
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
            this.lbl_bal = new System.Windows.Forms.Label();
            this.lbl_WithdrawStat = new System.Windows.Forms.Label();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bal.Location = new System.Drawing.Point(82, 9);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 20);
            this.lbl_bal.TabIndex = 18;
            this.lbl_bal.Click += new System.EventHandler(this.lbl_bal_Click);
            // 
            // lbl_WithdrawStat
            // 
            this.lbl_WithdrawStat.AutoSize = true;
            this.lbl_WithdrawStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawStat.Location = new System.Drawing.Point(123, 124);
            this.lbl_WithdrawStat.Name = "lbl_WithdrawStat";
            this.lbl_WithdrawStat.Size = new System.Drawing.Size(0, 20);
            this.lbl_WithdrawStat.TabIndex = 17;
            this.lbl_WithdrawStat.Click += new System.EventHandler(this.lbl_WithdrawStat_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.Orange;
            this.btn_withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_withdraw.Location = new System.Drawing.Point(213, 54);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(94, 29);
            this.btn_withdraw.TabIndex = 16;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // textWithdraw
            // 
            this.textWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWithdraw.Location = new System.Drawing.Point(82, 55);
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(125, 26);
            this.textWithdraw.TabIndex = 15;
            this.textWithdraw.TextChanged += new System.EventHandler(this.textWithdraw_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.Location = new System.Drawing.Point(82, 9);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 13;
            this.lbl_balance.Click += new System.EventHandler(this.lbl_balance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Balance:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 147);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_WithdrawStat);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bal;
        private Label lbl_WithdrawStat;
        private Button btn_withdraw;
        private TextBox textWithdraw;
        private Label label3;
        private Label lbl_balance;
        private Label label1;
    }
}