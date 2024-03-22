namespace Signup_App
{
    partial class Form2
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserLable = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.DobLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(89, 103);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Profile Details";
            // 
            // UserLable
            // 
            this.UserLable.AutoSize = true;
            this.UserLable.Location = new System.Drawing.Point(104, 173);
            this.UserLable.Name = "UserLable";
            this.UserLable.Size = new System.Drawing.Size(60, 13);
            this.UserLable.TabIndex = 2;
            this.UserLable.Text = "User Name";
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(104, 202);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(32, 13);
            this.EmailLable.TabIndex = 3;
            this.EmailLable.Text = "Email";
            // 
            // DobLable
            // 
            this.DobLable.AutoSize = true;
            this.DobLable.Location = new System.Drawing.Point(104, 227);
            this.DobLable.Name = "DobLable";
            this.DobLable.Size = new System.Drawing.Size(68, 13);
            this.DobLable.TabIndex = 4;
            this.DobLable.Text = "Date Of Birth";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DobLable);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.UserLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserLable;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.Label DobLable;
    }
}