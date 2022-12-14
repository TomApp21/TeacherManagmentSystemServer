namespace TeacherManagementSystemClient
{
    partial class TeacherViewClass
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.lblStudentMark = new System.Windows.Forms.Label();
            this.textBox1StuMark = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 15;
            this.listBoxStudents.Location = new System.Drawing.Point(38, 58);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(192, 214);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedValueChanged += new System.EventHandler(this.listBoxStudents_SelectedValueChanged);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(38, 40);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(53, 15);
            this.labelStudents.TabIndex = 1;
            this.labelStudents.Text = "Students";
            // 
            // lblStudentMark
            // 
            this.lblStudentMark.AutoSize = true;
            this.lblStudentMark.Location = new System.Drawing.Point(261, 58);
            this.lblStudentMark.Name = "lblStudentMark";
            this.lblStudentMark.Size = new System.Drawing.Size(100, 15);
            this.lblStudentMark.TabIndex = 2;
            this.lblStudentMark.Text = "Assignment Mark";
            // 
            // textBox1StuMark
            // 
            this.textBox1StuMark.Location = new System.Drawing.Point(399, 55);
            this.textBox1StuMark.Name = "textBox1StuMark";
            this.textBox1StuMark.Size = new System.Drawing.Size(100, 23);
            this.textBox1StuMark.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(424, 99);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(38, 278);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Student Mark";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 15);
            this.lblUsername.TabIndex = 6;
            // 
            // TeacherViewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1StuMark);
            this.Controls.Add(this.lblStudentMark);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "TeacherViewClass";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxStudents;
        private Label labelStudents;
        private Label lblStudentMark;
        private TextBox textBox1StuMark;
        private Button btnSubmit;
        private Button btnView;
        private Label lblUsername;
    }
}
