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
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password : ";
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.Location = new System.Drawing.Point(168, 188);
            this.BtnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(97, 22);
            this.BtnChangePass.TabIndex = 2;
            this.BtnChangePass.Text = "Cancel";
            this.BtnChangePass.UseVisualStyleBackColor = true;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // TxtOldPass
            // 
            this.TxtOldPass.Location = new System.Drawing.Point(155, 43);
            this.TxtOldPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.Size = new System.Drawing.Size(110, 23);
            this.TxtOldPass.TabIndex = 3;
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Location = new System.Drawing.Point(155, 104);
            this.TxtNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.Size = new System.Drawing.Size(110, 23);
            this.TxtNewPass.TabIndex = 4;
            // 
            // ChangePassStat
            // 
            this.ChangePassStat.AutoSize = true;
            this.ChangePassStat.Location = new System.Drawing.Point(99, 156);
            this.ChangePassStat.Name = "ChangePassStat";
            this.ChangePassStat.Size = new System.Drawing.Size(0, 15);
            this.ChangePassStat.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(10, 188);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 22);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Change";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.ChangePassStat);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.TxtOldPass);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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