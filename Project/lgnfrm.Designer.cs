namespace Project
{
    partial class lgnfrm
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.btn_lgin = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(45, 29);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(121, 20);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Account Number";
            this.lbl_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(45, 104);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 20);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(165, 29);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PlaceholderText = "Enter account number ";
            this.usernametxt.Size = new System.Drawing.Size(168, 27);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(165, 100);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PlaceholderText = "Enter  password";
            this.passwordtxt.Size = new System.Drawing.Size(168, 27);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // btn_lgin
            // 
            this.btn_lgin.Location = new System.Drawing.Point(45, 167);
            this.btn_lgin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lgin.Name = "btn_lgin";
            this.btn_lgin.Size = new System.Drawing.Size(113, 31);
            this.btn_lgin.TabIndex = 4;
            this.btn_lgin.Text = "Login";
            this.btn_lgin.UseVisualStyleBackColor = true;
            this.btn_lgin.Click += new System.EventHandler(this.btn_lgin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(193, 167);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 31);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lgnfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(480, 244);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_lgin);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lgnfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.lgnfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_username;
        private Label lbl_password;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Button btn_lgin;
        private Button btn_exit;
    }
}