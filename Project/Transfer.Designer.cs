namespace Project
{
    partial class Transfer
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTranAmount = new System.Windows.Forms.TextBox();
            this.TxtTranUser = new System.Windows.Forms.TextBox();
            this.transferstat = new System.Windows.Forms.Label();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bal.Location = new System.Drawing.Point(101, 9);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 20);
            this.lbl_bal.TabIndex = 21;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.Location = new System.Drawing.Point(101, 9);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "To:";
            // 
            // TxtTranAmount
            // 
            this.TxtTranAmount.Location = new System.Drawing.Point(98, 50);
            this.TxtTranAmount.Name = "TxtTranAmount";
            this.TxtTranAmount.Size = new System.Drawing.Size(125, 27);
            this.TxtTranAmount.TabIndex = 24;
            // 
            // TxtTranUser
            // 
            this.TxtTranUser.Location = new System.Drawing.Point(98, 97);
            this.TxtTranUser.Name = "TxtTranUser";
            this.TxtTranUser.Size = new System.Drawing.Size(125, 27);
            this.TxtTranUser.TabIndex = 25;
            // 
            // transferstat
            // 
            this.transferstat.AutoSize = true;
            this.transferstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferstat.Location = new System.Drawing.Point(82, 164);
            this.transferstat.Name = "transferstat";
            this.transferstat.Size = new System.Drawing.Size(0, 20);
            this.transferstat.TabIndex = 27;
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.Orange;
            this.btn_transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transfer.FlatAppearance.BorderSize = 0;
            this.btn_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_transfer.ForeColor = System.Drawing.Color.White;
            this.btn_transfer.Location = new System.Drawing.Point(245, 73);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(94, 29);
            this.btn_transfer.TabIndex = 28;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(448, 236);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.transferstat);
            this.Controls.Add(this.TxtTranUser);
            this.Controls.Add(this.TxtTranAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bal;
        private Label lbl_balance;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtTranAmount;
        private TextBox TxtTranUser;
        private Label transferstat;
        private Button btn_transfer;
    }
}