namespace Project
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chck_male = new System.Windows.Forms.CheckBox();
            this.chck_female = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.chck_Fixed = new System.Windows.Forms.CheckBox();
            this.chck_Saving = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(151, 76);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(114, 27);
            this.txt_name.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(151, 161);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(114, 27);
            this.txt_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(151, 239);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(114, 27);
            this.txt_address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(151, 301);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(114, 27);
            this.txt_Phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(151, 373);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(114, 27);
            this.txt_balance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balance";
            // 
            // chck_male
            // 
            this.chck_male.AutoSize = true;
            this.chck_male.Location = new System.Drawing.Point(65, 426);
            this.chck_male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chck_male.Name = "chck_male";
            this.chck_male.Size = new System.Drawing.Size(64, 24);
            this.chck_male.TabIndex = 10;
            this.chck_male.Text = "Male";
            this.chck_male.UseVisualStyleBackColor = true;
            this.chck_male.CheckedChanged += new System.EventHandler(this.chck_male_CheckedChanged);
            // 
            // chck_female
            // 
            this.chck_female.AutoSize = true;
            this.chck_female.Location = new System.Drawing.Point(186, 426);
            this.chck_female.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chck_female.Name = "chck_female";
            this.chck_female.Size = new System.Drawing.Size(79, 24);
            this.chck_female.TabIndex = 11;
            this.chck_female.Text = "Female";
            this.chck_female.UseVisualStyleBackColor = true;
            this.chck_female.CheckedChanged += new System.EventHandler(this.chck_female_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(73, 541);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 31);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(554, 541);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 31);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // chck_Fixed
            // 
            this.chck_Fixed.AutoSize = true;
            this.chck_Fixed.Location = new System.Drawing.Point(186, 474);
            this.chck_Fixed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chck_Fixed.Name = "chck_Fixed";
            this.chck_Fixed.Size = new System.Drawing.Size(66, 24);
            this.chck_Fixed.TabIndex = 15;
            this.chck_Fixed.Text = "Fixed";
            this.chck_Fixed.UseVisualStyleBackColor = true;
            this.chck_Fixed.CheckedChanged += new System.EventHandler(this.chck_Fixed_CheckedChanged);
            // 
            // chck_Saving
            // 
            this.chck_Saving.AutoSize = true;
            this.chck_Saving.Location = new System.Drawing.Point(65, 474);
            this.chck_Saving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chck_Saving.Name = "chck_Saving";
            this.chck_Saving.Size = new System.Drawing.Size(75, 24);
            this.chck_Saving.TabIndex = 14;
            this.chck_Saving.Text = "Saving";
            this.chck_Saving.UseVisualStyleBackColor = true;
            this.chck_Saving.CheckedChanged += new System.EventHandler(this.chck_Saving_CheckedChanged_1);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 600);
            this.Controls.Add(this.chck_Fixed);
            this.Controls.Add(this.chck_Saving);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.chck_female);
            this.Controls.Add(this.chck_male);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_address;
        private Label label3;
        private TextBox txt_Phone;
        private Label label4;
        private TextBox txt_balance;
        private Label label5;
        private CheckBox chck_male;
        private CheckBox chck_female;
        private Button btn_add;
        private Button btn_back;
        private CheckBox chck_Fixed;
        private CheckBox chck_Saving;
    }
}