namespace Project
{
    partial class Loan
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
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_askLoan = new System.Windows.Forms.TextBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.askLoan_stat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bal.Location = new System.Drawing.Point(82, 9);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 20);
            this.lbl_bal.TabIndex = 24;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.Location = new System.Drawing.Point(82, 9);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_askLoan
            // 
            this.txtbox_askLoan.Location = new System.Drawing.Point(93, 59);
            this.txtbox_askLoan.Name = "txtbox_askLoan";
            this.txtbox_askLoan.Size = new System.Drawing.Size(125, 27);
            this.txtbox_askLoan.TabIndex = 26;
            this.txtbox_askLoan.TextChanged += new System.EventHandler(this.txtbox_askLoan_TextChanged);
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.Orange;
            this.btn_transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_transfer.ForeColor = System.Drawing.Color.White;
            this.btn_transfer.Location = new System.Drawing.Point(236, 59);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(141, 29);
            this.btn_transfer.TabIndex = 29;
            this.btn_transfer.Text = "Ask For Loan";
            this.btn_transfer.UseVisualStyleBackColor = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // askLoan_stat
            // 
            this.askLoan_stat.AutoSize = true;
            this.askLoan_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.askLoan_stat.Location = new System.Drawing.Point(143, 126);
            this.askLoan_stat.Name = "askLoan_stat";
            this.askLoan_stat.Size = new System.Drawing.Size(0, 20);
            this.askLoan_stat.TabIndex = 30;
            this.askLoan_stat.Click += new System.EventHandler(this.askLoan_stat_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(426, 190);
            this.Controls.Add(this.askLoan_stat);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.txtbox_askLoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bal;
        private Label lbl_balance;
        private Label label1;
        private Label label2;
        private TextBox txtbox_askLoan;
        private Button btn_transfer;
        private Label askLoan_stat;
    }
}