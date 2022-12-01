namespace TeacherManagementSystemClient
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.userControl31 = new TeacherManagementSystemClient.UserControl3();
            this.ucLogin1 = new TeacherManagementSystemClient.ucLogin();
            this.ucTeacherMainView1 = new TeacherManagementSystemClient.ucTeacherMainView();
            this.teacherViewClass1 = new TeacherManagementSystemClient.TeacherViewClass();
            this.ucParentMainView1 = new TeacherManagementSystemClient.ucParentMainView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(54, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(54, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(54, 401);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(54, 372);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // userControl31
            // 
            this.userControl31.ClassName = "";
            this.userControl31.EndDate = new System.DateTime(2022, 11, 30, 14, 11, 12, 495);
            this.userControl31.Location = new System.Drawing.Point(188, -3);
            this.userControl31.ModuleCode = "";
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(600, 450);
            this.userControl31.StartDate = new System.DateTime(2022, 11, 30, 14, 11, 12, 499);
            this.userControl31.TabIndex = 1;
            // 
            // ucLogin1
            // 
            this.ucLogin1.Location = new System.Drawing.Point(223, 0);
            this.ucLogin1.LogInBtnEnabled = false;
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Password = "";
            this.ucLogin1.Size = new System.Drawing.Size(600, 450);
            this.ucLogin1.TabIndex = 5;
            this.ucLogin1.Username = "";
            // 
            // ucTeacherMainView1
            // 
            this.ucTeacherMainView1.Location = new System.Drawing.Point(437, 70);
            this.ucTeacherMainView1.Name = "ucTeacherMainView1";
            this.ucTeacherMainView1.Size = new System.Drawing.Size(150, 150);
            this.ucTeacherMainView1.TabIndex = 2;
            this.ucTeacherMainView1.TeachersClasses = null;
            // 
            // teacherViewClass1
            // 
            this.teacherViewClass1.Location = new System.Drawing.Point(188, 12);
            this.teacherViewClass1.Name = "teacherViewClass1";
            this.teacherViewClass1.Size = new System.Drawing.Size(600, 450);
            this.teacherViewClass1.StudentMark = "";
            this.teacherViewClass1.Students = null;
            this.teacherViewClass1.SubmitBtnEnabled = true;
            this.teacherViewClass1.TabIndex = 6;
            // 
            // ucParentMainView1
            // 
            this.ucParentMainView1.Location = new System.Drawing.Point(206, 3);
            this.ucParentMainView1.Name = "ucParentMainView1";
            this.ucParentMainView1.Size = new System.Drawing.Size(600, 450);
            this.ucParentMainView1.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucParentMainView1);
            this.Controls.Add(this.teacherViewClass1);
            this.Controls.Add(this.ucTeacherMainView1);
            this.Controls.Add(this.ucLogin1);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnDisconnect;
        private Button btnConnect;
        private UserControl3 userControl31;
        private TeacherManagementSystemClient.ucLogin ucLogin1;
        private Button btnLogout;
        private ucTeacherMainView ucTeacherMainView1;
        private Button btnHome;
        private TeacherViewClass teacherViewClass1;
        private ucParentMainView ucParentMainView1;
    }
}