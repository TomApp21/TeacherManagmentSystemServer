namespace TeacherManagementSystemClient
{
    partial class ucParentMainView
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
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblJoinClass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnJoinClass = new System.Windows.Forms.Button();
            this.btnViewClass = new System.Windows.Forms.Button();
            this.textBox2ClassesBroadcastMsgBox = new System.Windows.Forms.TextBox();
            this.labelClassBroadcastMsg = new System.Windows.Forms.Label();
            this.lblClassMark = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1ParentsClasses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(51, 51);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(45, 15);
            this.lblClasses.TabIndex = 1;
            this.lblClasses.Text = "Classes";
            // 
            // lblJoinClass
            // 
            this.lblJoinClass.AutoSize = true;
            this.lblJoinClass.Location = new System.Drawing.Point(288, 69);
            this.lblJoinClass.Name = "lblJoinClass";
            this.lblJoinClass.Size = new System.Drawing.Size(117, 15);
            this.lblJoinClass.TabIndex = 2;
            this.lblJoinClass.Text = "Join Class With Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnJoinClass
            // 
            this.btnJoinClass.Location = new System.Drawing.Point(468, 95);
            this.btnJoinClass.Name = "btnJoinClass";
            this.btnJoinClass.Size = new System.Drawing.Size(75, 23);
            this.btnJoinClass.TabIndex = 4;
            this.btnJoinClass.Text = "Join";
            this.btnJoinClass.UseVisualStyleBackColor = true;
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(176, 197);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(75, 23);
            this.btnViewClass.TabIndex = 5;
            this.btnViewClass.Text = "View";
            this.btnViewClass.UseVisualStyleBackColor = true;
            // 
            // textBox2ClassesBroadcastMsgBox
            // 
            this.textBox2ClassesBroadcastMsgBox.Location = new System.Drawing.Point(52, 293);
            this.textBox2ClassesBroadcastMsgBox.Multiline = true;
            this.textBox2ClassesBroadcastMsgBox.Name = "textBox2ClassesBroadcastMsgBox";
            this.textBox2ClassesBroadcastMsgBox.ReadOnly = true;
            this.textBox2ClassesBroadcastMsgBox.Size = new System.Drawing.Size(491, 138);
            this.textBox2ClassesBroadcastMsgBox.TabIndex = 6;
            // 
            // labelClassBroadcastMsg
            // 
            this.labelClassBroadcastMsg.AutoSize = true;
            this.labelClassBroadcastMsg.Location = new System.Drawing.Point(58, 275);
            this.labelClassBroadcastMsg.Name = "labelClassBroadcastMsg";
            this.labelClassBroadcastMsg.Size = new System.Drawing.Size(133, 15);
            this.labelClassBroadcastMsg.TabIndex = 7;
            this.labelClassBroadcastMsg.Text = "Messages from Teacher:";
            // 
            // lblClassMark
            // 
            this.lblClassMark.AutoSize = true;
            this.lblClassMark.Location = new System.Drawing.Point(111, 230);
            this.lblClassMark.Name = "lblClassMark";
            this.lblClassMark.Size = new System.Drawing.Size(34, 15);
            this.lblClassMark.TabIndex = 8;
            this.lblClassMark.Text = "Mark";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 9;
            // 
            // listBox1ParentsClasses
            // 
            this.listBox1ParentsClasses.FormattingEnabled = true;
            this.listBox1ParentsClasses.ItemHeight = 15;
            this.listBox1ParentsClasses.Location = new System.Drawing.Point(51, 79);
            this.listBox1ParentsClasses.Name = "listBox1ParentsClasses";
            this.listBox1ParentsClasses.Size = new System.Drawing.Size(200, 109);
            this.listBox1ParentsClasses.TabIndex = 10;
            // 
            // ucParentMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1ParentsClasses);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblClassMark);
            this.Controls.Add(this.labelClassBroadcastMsg);
            this.Controls.Add(this.textBox2ClassesBroadcastMsgBox);
            this.Controls.Add(this.btnViewClass);
            this.Controls.Add(this.btnJoinClass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblJoinClass);
            this.Controls.Add(this.lblClasses);
            this.Name = "ucParentMainView";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblClasses;
        private Label lblJoinClass;
        private TextBox textBox1;
        private Button btnJoinClass;
        private Button btnViewClass;
        private TextBox textBox2ClassesBroadcastMsgBox;
        private Label labelClassBroadcastMsg;
        private Label lblClassMark;
        private TextBox textBox2;
        private ListBox listBox1ParentsClasses;
    }
}
