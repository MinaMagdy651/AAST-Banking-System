namespace Project
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_changepw = new System.Windows.Forms.Button();
            this.btn_debt = new System.Windows.Forms.Button();
            this.btn_loan = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_signout);
            this.panelMenu.Controls.Add(this.btn_changepw);
            this.panelMenu.Controls.Add(this.btn_debt);
            this.panelMenu.Controls.Add(this.btn_loan);
            this.panelMenu.Controls.Add(this.btn_transfer);
            this.panelMenu.Controls.Add(this.btn_withdraw);
            this.panelMenu.Controls.Add(this.btn_deposit);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 533);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_signout
            // 
            this.btn_signout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_signout.Image = global::Project.Properties.Resources.icons8_sign_out_48__2_;
            this.btn_signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signout.Location = new System.Drawing.Point(0, 440);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_signout.Size = new System.Drawing.Size(220, 60);
            this.btn_signout.TabIndex = 7;
            this.btn_signout.Text = " Sign Out";
            this.btn_signout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // btn_changepw
            // 
            this.btn_changepw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_changepw.FlatAppearance.BorderSize = 0;
            this.btn_changepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_changepw.Image = global::Project.Properties.Resources.icons8_password_reset_48__1_;
            this.btn_changepw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changepw.Location = new System.Drawing.Point(0, 380);
            this.btn_changepw.Name = "btn_changepw";
            this.btn_changepw.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_changepw.Size = new System.Drawing.Size(220, 60);
            this.btn_changepw.TabIndex = 6;
            this.btn_changepw.Text = " Change Password";
            this.btn_changepw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changepw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changepw.UseVisualStyleBackColor = true;
            this.btn_changepw.Click += new System.EventHandler(this.btn_changepw_Click);
            // 
            // btn_debt
            // 
            this.btn_debt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_debt.FlatAppearance.BorderSize = 0;
            this.btn_debt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_debt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_debt.Image = global::Project.Properties.Resources.icons8_debt_48__1_;
            this.btn_debt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debt.Location = new System.Drawing.Point(0, 320);
            this.btn_debt.Name = "btn_debt";
            this.btn_debt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_debt.Size = new System.Drawing.Size(220, 60);
            this.btn_debt.TabIndex = 5;
            this.btn_debt.Text = " Debt";
            this.btn_debt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_debt.UseVisualStyleBackColor = true;
            this.btn_debt.Click += new System.EventHandler(this.btn_debt_Click);
            // 
            // btn_loan
            // 
            this.btn_loan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_loan.FlatAppearance.BorderSize = 0;
            this.btn_loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_loan.Image = global::Project.Properties.Resources.icons8_loan_48__1_;
            this.btn_loan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loan.Location = new System.Drawing.Point(0, 260);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_loan.Size = new System.Drawing.Size(220, 60);
            this.btn_loan.TabIndex = 4;
            this.btn_loan.Text = " Loan";
            this.btn_loan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transfer.FlatAppearance.BorderSize = 0;
            this.btn_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_transfer.Image = global::Project.Properties.Resources.icons8_transfer_48__1_;
            this.btn_transfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transfer.Location = new System.Drawing.Point(0, 200);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_transfer.Size = new System.Drawing.Size(220, 60);
            this.btn_transfer.TabIndex = 3;
            this.btn_transfer.Text = " Transfer";
            this.btn_transfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_withdraw.FlatAppearance.BorderSize = 0;
            this.btn_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_withdraw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_withdraw.Image = global::Project.Properties.Resources.icons8_withdrawal_48__1_;
            this.btn_withdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_withdraw.Location = new System.Drawing.Point(0, 140);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_withdraw.Size = new System.Drawing.Size(220, 60);
            this.btn_withdraw.TabIndex = 2;
            this.btn_withdraw.Text = " Withdraw";
            this.btn_withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_deposit.FlatAppearance.BorderSize = 0;
            this.btn_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deposit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_deposit.Image = global::Project.Properties.Resources.icons8_deposit_48__1_;
            this.btn_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deposit.Location = new System.Drawing.Point(0, 80);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_deposit.Size = new System.Drawing.Size(220, 60);
            this.btn_deposit.TabIndex = 0;
            this.btn_deposit.Text = " Deposit";
            this.btn_deposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.btn_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.lbl_Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(581, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(156, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(288, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "AAST Banking System";
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(220, 80);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(581, 453);
            this.panelDeskTop.TabIndex = 2;
            this.panelDeskTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeskTop_Paint);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_home.Image = global::Project.Properties.Resources.icons8_home_48;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(220, 77);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 533);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btn_debt;
        private Button btn_loan;
        private Button btn_transfer;
        private Button btn_withdraw;
        private Button btn_deposit;
        private Panel panelLogo;
        private Button btn_signout;
        private Button btn_changepw;
        private Panel panelTitle;
        private Label lbl_Title;
        private PictureBox pictureBox1;
        private Panel panelDeskTop;
        private Button btn_home;
    }
}