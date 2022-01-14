namespace Project
{
    partial class Deposit
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
            this.btn_deposit = new System.Windows.Forms.Button();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_depStat = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.Orange;
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_deposit.ForeColor = System.Drawing.Color.White;
            this.btn_deposit.Location = new System.Drawing.Point(218, 70);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(94, 29);
            this.btn_deposit.TabIndex = 9;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // textDeposit
            // 
            this.textDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDeposit.Location = new System.Drawing.Point(87, 71);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(125, 26);
            this.textDeposit.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.Location = new System.Drawing.Point(87, 25);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Balance:";
            // 
            // lbl_depStat
            // 
            this.lbl_depStat.AutoSize = true;
            this.lbl_depStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_depStat.Location = new System.Drawing.Point(189, 143);
            this.lbl_depStat.Name = "lbl_depStat";
            this.lbl_depStat.Size = new System.Drawing.Size(0, 20);
            this.lbl_depStat.TabIndex = 10;
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bal.Location = new System.Drawing.Point(87, 25);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 20);
            this.lbl_bal.TabIndex = 11;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(544, 243);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_depStat);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.textDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_deposit;
        private TextBox textDeposit;
        private Label label3;
        private Label lbl_balance;
        private Label label1;
        private Label lbl_depStat;
        private Label lbl_bal;
    }
}