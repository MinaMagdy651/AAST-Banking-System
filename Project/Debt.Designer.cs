namespace Project
{
    partial class Debt
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
            this.label4 = new System.Windows.Forms.Label();
            this.debt_stat = new System.Windows.Forms.Label();
            this.btn_debt = new System.Windows.Forms.Button();
            this.txtbox_debt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_debt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bal.Location = new System.Drawing.Point(82, 9);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 20);
            this.lbl_bal.TabIndex = 27;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.Location = new System.Drawing.Point(82, 9);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(235, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Debt:";
            // 
            // debt_stat
            // 
            this.debt_stat.AutoSize = true;
            this.debt_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.debt_stat.Location = new System.Drawing.Point(147, 126);
            this.debt_stat.Name = "debt_stat";
            this.debt_stat.Size = new System.Drawing.Size(0, 20);
            this.debt_stat.TabIndex = 34;
            // 
            // btn_debt
            // 
            this.btn_debt.BackColor = System.Drawing.Color.Orange;
            this.btn_debt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_debt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_debt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_debt.ForeColor = System.Drawing.Color.White;
            this.btn_debt.Location = new System.Drawing.Point(235, 65);
            this.btn_debt.Name = "btn_debt";
            this.btn_debt.Size = new System.Drawing.Size(141, 29);
            this.btn_debt.TabIndex = 33;
            this.btn_debt.Text = "Pay Debt";
            this.btn_debt.UseVisualStyleBackColor = false;
            this.btn_debt.Click += new System.EventHandler(this.btn_debt_Click);
            // 
            // txtbox_debt
            // 
            this.txtbox_debt.Location = new System.Drawing.Point(89, 66);
            this.txtbox_debt.Name = "txtbox_debt";
            this.txtbox_debt.Size = new System.Drawing.Size(125, 27);
            this.txtbox_debt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Amount:";
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_debt.Location = new System.Drawing.Point(282, 9);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(0, 20);
            this.lbl_debt.TabIndex = 35;
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(443, 183);
            this.Controls.Add(this.lbl_debt);
            this.Controls.Add(this.debt_stat);
            this.Controls.Add(this.btn_debt);
            this.Controls.Add(this.txtbox_debt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Name = "Debt";
            this.Text = "Debt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bal;
        private Label lbl_balance;
        private Label label1;
        private Label label4;
        private Label debt_stat;
        private Button btn_debt;
        private TextBox txtbox_debt;
        private Label label5;
        private Label lbl_debt;
    }
}