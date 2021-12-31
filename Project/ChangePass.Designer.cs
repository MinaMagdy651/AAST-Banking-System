namespace Project
{
    partial class ChangePass
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.TxtOldPass = new System.Windows.Forms.TextBox();
            this.TxtNewPass = new System.Windows.Forms.TextBox();
            this.ChangePassStat = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password : ";
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.Location = new System.Drawing.Point(251, 251);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(111, 29);
            this.BtnChangePass.TabIndex = 2;
            this.BtnChangePass.Text = "Cancel";
            this.BtnChangePass.UseVisualStyleBackColor = true;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // TxtOldPass
            // 
            this.TxtOldPass.Location = new System.Drawing.Point(177, 57);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.PlaceholderText = "Enter the old password..";
            this.TxtOldPass.Size = new System.Drawing.Size(185, 27);
            this.TxtOldPass.TabIndex = 3;
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Location = new System.Drawing.Point(177, 139);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.PlaceholderText = "Enter the new password..";
            this.TxtNewPass.Size = new System.Drawing.Size(185, 27);
            this.TxtNewPass.TabIndex = 4;
            this.TxtNewPass.UseSystemPasswordChar = true;
            // 
            // ChangePassStat
            // 
            this.ChangePassStat.AutoSize = true;
            this.ChangePassStat.Location = new System.Drawing.Point(113, 208);
            this.ChangePassStat.Name = "ChangePassStat";
            this.ChangePassStat.Size = new System.Drawing.Size(0, 20);
            this.ChangePassStat.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(11, 251);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 29);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Change";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 360);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.ChangePassStat);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.TxtOldPass);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnChangePass;
        private TextBox TxtOldPass;
        private TextBox TxtNewPass;
        private Label ChangePassStat;
        private Button btn_save;
    }
}