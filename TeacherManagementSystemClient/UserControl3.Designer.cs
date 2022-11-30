namespace TeacherManagementSystemClient
{
    partial class UserControl3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.lblClasName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.textboxModuleCode = new System.Windows.Forms.TextBox();
            this.buttonCreateClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is third";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(263, 105);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(131, 23);
            this.textBoxClassName.TabIndex = 3;
            // 
            // lblClasName
            // 
            this.lblClasName.AutoSize = true;
            this.lblClasName.Location = new System.Drawing.Point(151, 108);
            this.lblClasName.Name = "lblClasName";
            this.lblClasName.Size = new System.Drawing.Size(66, 15);
            this.lblClasName.TabIndex = 4;
            this.lblClasName.Text = "ClassName";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(159, 158);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 15);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(263, 158);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(131, 23);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(263, 204);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(131, 23);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(159, 204);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 15);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(97, 249);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(120, 15);
            this.lblModuleCode.TabIndex = 9;
            this.lblModuleCode.Text = "Module Joining Code";
            // 
            // textboxModuleCode
            // 
            this.textboxModuleCode.Location = new System.Drawing.Point(263, 249);
            this.textboxModuleCode.Name = "textboxModuleCode";
            this.textboxModuleCode.Size = new System.Drawing.Size(131, 23);
            this.textboxModuleCode.TabIndex = 10;
            // 
            // buttonCreateClass
            // 
            this.buttonCreateClass.Location = new System.Drawing.Point(319, 316);
            this.buttonCreateClass.Name = "buttonCreateClass";
            this.buttonCreateClass.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateClass.TabIndex = 11;
            this.buttonCreateClass.Text = "Create";
            this.buttonCreateClass.UseVisualStyleBackColor = true;
            this.buttonCreateClass.Click += new System.EventHandler(this.buttonCreateClass_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCreateClass);
            this.Controls.Add(this.textboxModuleCode);
            this.Controls.Add(this.lblModuleCode);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblClasName);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.label1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxClassName;
        private Label lblClasName;
        private Label lblStartDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label lblEndDate;
        private Label lblModuleCode;
        private TextBox textboxModuleCode;
        private Button buttonCreateClass;
    }
}
