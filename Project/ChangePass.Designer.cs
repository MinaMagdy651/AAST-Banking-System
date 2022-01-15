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
            this.TxtOldPass = new System.Windows.Forms.TextBox();
            this.TxtNewPass = new System.Windows.Forms.TextBox();
            this.ChangePassStat = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
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
            // TxtOldPass
            // 
            this.TxtOldPass.Location = new System.Drawing.Point(177, 57);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.Size = new System.Drawing.Size(185, 27);
            this.TxtOldPass.TabIndex = 3;
            this.TxtOldPass.UseSystemPasswordChar = true;
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Location = new System.Drawing.Point(177, 139);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.Size = new System.Drawing.Size(185, 27);
            this.TxtNewPass.TabIndex = 4;
            this.TxtNewPass.UseSystemPasswordChar = true;
            // 
            // ChangePassStat
            // 
            this.ChangePassStat.AutoSize = true;
            this.ChangePassStat.Location = new System.Drawing.Point(75, 231);
            this.ChangePassStat.Name = "ChangePassStat";
            this.ChangePassStat.Size = new System.Drawing.Size(0, 20);
            this.ChangePassStat.TabIndex = 5;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Orange;
            this.btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(234, 186);
            this.btn_change.Margin = new System.Windows.Forms.Padding(0);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(128, 35);
            this.btn_change.TabIndex = 34;
            this.btn_change.Text = "Save Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(439, 348);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.ChangePassStat);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.TxtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtOldPass;
        private TextBox TxtNewPass;
        private Label ChangePassStat;
        private Button btn_change;
    }
}