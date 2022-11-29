namespace TeacherManagementSystemClient
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.textBox1Password = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(235, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(235, 149);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(100, 23);
            this.textBox1Username.TabIndex = 1;
            // 
            // textBox1Password
            // 
            this.textBox1Password.Location = new System.Drawing.Point(235, 197);
            this.textBox1Password.Name = "textBox1Password";
            this.textBox1Password.Size = new System.Drawing.Size(100, 23);
            this.textBox1Password.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(235, 131);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.buttonLogin.Location = new System.Drawing.Point(235, 237);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.textBox1Password);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.labelPassword);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPassword;
        private TextBox textBox1Username;
        private TextBox textBox1Password;
        private Label lblUsername;
        private Button buttonLogin;
    }
}
