namespace TeacherManagementSystemClient
{
    partial class ucTeacherMainView
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
            this.listboxTeacherClasses = new System.Windows.Forms.ListBox();
            this.lblClasses = new System.Windows.Forms.Label();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortNoAsc = new System.Windows.Forms.Button();
            this.btnViewClass = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listboxBroadcastMsg = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBroadcast = new System.Windows.Forms.Label();
            this.btnSortNoDesc = new System.Windows.Forms.Button();
            this.btnSortNameDesc = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listboxTeacherClasses
            // 
            this.listboxTeacherClasses.FormattingEnabled = true;
            this.listboxTeacherClasses.ItemHeight = 15;
            this.listboxTeacherClasses.Location = new System.Drawing.Point(22, 56);
            this.listboxTeacherClasses.Name = "listboxTeacherClasses";
            this.listboxTeacherClasses.Size = new System.Drawing.Size(250, 319);
            this.listboxTeacherClasses.TabIndex = 0;
            this.listboxTeacherClasses.SelectedValueChanged += new System.EventHandler(this.listboxTeacherClasses_SelectedValueChanged);
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(22, 38);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(45, 15);
            this.lblClasses.TabIndex = 1;
            this.lblClasses.Text = "Classes";
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(22, 381);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(111, 23);
            this.btnSortName.TabIndex = 2;
            this.btnSortName.Text = "Sort By Name >";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortNoAsc
            // 
            this.btnSortNoAsc.Location = new System.Drawing.Point(139, 381);
            this.btnSortNoAsc.Name = "btnSortNoAsc";
            this.btnSortNoAsc.Size = new System.Drawing.Size(133, 23);
            this.btnSortNoAsc.TabIndex = 3;
            this.btnSortNoAsc.Text = "Sort By # Students >";
            this.btnSortNoAsc.UseVisualStyleBackColor = true;
            this.btnSortNoAsc.Click += new System.EventHandler(this.btnSortNo_Click);
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(295, 56);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(75, 23);
            this.btnViewClass.TabIndex = 4;
            this.btnViewClass.Text = "View ";
            this.btnViewClass.UseVisualStyleBackColor = true;
            this.btnViewClass.Click += new System.EventHandler(this.btnViewClass_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(391, 56);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listboxBroadcastMsg
            // 
            this.listboxBroadcastMsg.FormattingEnabled = true;
            this.listboxBroadcastMsg.ItemHeight = 15;
            this.listboxBroadcastMsg.Location = new System.Drawing.Point(295, 206);
            this.listboxBroadcastMsg.Name = "listboxBroadcastMsg";
            this.listboxBroadcastMsg.Size = new System.Drawing.Size(275, 169);
            this.listboxBroadcastMsg.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBroadcast
            // 
            this.lblBroadcast.AutoSize = true;
            this.lblBroadcast.Location = new System.Drawing.Point(295, 188);
            this.lblBroadcast.Name = "lblBroadcast";
            this.lblBroadcast.Size = new System.Drawing.Size(184, 15);
            this.lblBroadcast.TabIndex = 9;
            this.lblBroadcast.Text = "Send Message to Selected Classes";
            // 
            // btnSortNoDesc
            // 
            this.btnSortNoDesc.Location = new System.Drawing.Point(139, 410);
            this.btnSortNoDesc.Name = "btnSortNoDesc";
            this.btnSortNoDesc.Size = new System.Drawing.Size(133, 23);
            this.btnSortNoDesc.TabIndex = 10;
            this.btnSortNoDesc.Text = "Sort By # Students <";
            this.btnSortNoDesc.UseVisualStyleBackColor = true;
            this.btnSortNoDesc.Click += new System.EventHandler(this.btnSortNoDesc_Click);
            // 
            // btnSortNameDesc
            // 
            this.btnSortNameDesc.Location = new System.Drawing.Point(22, 410);
            this.btnSortNameDesc.Name = "btnSortNameDesc";
            this.btnSortNameDesc.Size = new System.Drawing.Size(111, 23);
            this.btnSortNameDesc.TabIndex = 11;
            this.btnSortNameDesc.Text = "Sort By Name <";
            this.btnSortNameDesc.UseVisualStyleBackColor = true;
            this.btnSortNameDesc.Click += new System.EventHandler(this.btnSortNameDesc_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 15);
            this.lblUsername.TabIndex = 12;
            // 
            // ucTeacherMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSortNameDesc);
            this.Controls.Add(this.btnSortNoDesc);
            this.Controls.Add(this.lblBroadcast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listboxBroadcastMsg);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnViewClass);
            this.Controls.Add(this.btnSortNoAsc);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.listboxTeacherClasses);
            this.Name = "ucTeacherMainView";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listboxTeacherClasses;
        private Label lblClasses;
        private Button btnSortName;
        private Button btnSortNoAsc;
        private Button btnViewClass;
        private Button btnCreate;
        private Button btnDelete;
        private ListBox listboxBroadcastMsg;
        private Button button1;
        private Label lblBroadcast;
        private Button btnSortNoDesc;
        private Button btnSortNameDesc;
        private Label lblUsername;
    }




}
