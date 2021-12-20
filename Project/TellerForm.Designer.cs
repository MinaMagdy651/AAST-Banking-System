namespace Project
{
    partial class TellerForm
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
            this.AccNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AccNum
            // 
            this.AccNum.Location = new System.Drawing.Point(336, 132);
            this.AccNum.Name = "AccNum";
            this.AccNum.Size = new System.Drawing.Size(277, 27);
            this.AccNum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add New Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccNum);
            this.Controls.Add(this.label1);
            this.Name = "TellerForm";
            this.Text = "TellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox AccNum;
        private Button button1;
        private Button button2;
    }
}