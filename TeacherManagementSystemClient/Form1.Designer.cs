namespace TeacherManagementSystemClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._sendCommandBtn = new System.Windows.Forms.Button();
            this._commandTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._cnnctBtn = new System.Windows.Forms.Button();
            this._discnnctBtn = new System.Windows.Forms.Button();
            this._ipAddressTextBox = new System.Windows.Forms.TextBox();
            this._portTxtBox = new System.Windows.Forms.TextBox();
            this._ipAddressLbl = new System.Windows.Forms.Label();
            this._portLabel = new System.Windows.Forms.Label();
            this._statusTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._statusTextbox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._sendCommandBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this._commandTextbox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(470, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 253);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _sendCommandBtn
            // 
            this._sendCommandBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sendCommandBtn.Location = new System.Drawing.Point(233, 210);
            this._sendCommandBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._sendCommandBtn.Name = "_sendCommandBtn";
            this._sendCommandBtn.Size = new System.Drawing.Size(222, 40);
            this._sendCommandBtn.TabIndex = 0;
            this._sendCommandBtn.Text = "Send Command";
            this._sendCommandBtn.UseVisualStyleBackColor = true;
            this._sendCommandBtn.Click += new System.EventHandler(this.SendCommandButtonHandler);
            // 
            // _commandTextbox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._commandTextbox, 2);
            this._commandTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commandTextbox.Location = new System.Drawing.Point(4, 113);
            this._commandTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._commandTextbox.Multiline = true;
            this._commandTextbox.Name = "_commandTextbox";
            this._commandTextbox.Size = new System.Drawing.Size(451, 91);
            this._commandTextbox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._cnnctBtn, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this._discnnctBtn, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this._ipAddressTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._portTxtBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this._ipAddressLbl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._portLabel, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(470, 262);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.7931F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.2069F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(459, 254);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _cnnctBtn
            // 
            this._cnnctBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cnnctBtn.Location = new System.Drawing.Point(233, 209);
            this._cnnctBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cnnctBtn.Name = "_cnnctBtn";
            this._cnnctBtn.Size = new System.Drawing.Size(222, 42);
            this._cnnctBtn.TabIndex = 0;
            this._cnnctBtn.Text = "Connect";
            this._cnnctBtn.UseVisualStyleBackColor = true;
            this._cnnctBtn.Click += new System.EventHandler(this.ConnectButtonHandler);
            // 
            // _discnnctBtn
            // 
            this._discnnctBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._discnnctBtn.Location = new System.Drawing.Point(4, 209);
            this._discnnctBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._discnnctBtn.Name = "_discnnctBtn";
            this._discnnctBtn.Size = new System.Drawing.Size(221, 42);
            this._discnnctBtn.TabIndex = 1;
            this._discnnctBtn.Text = "Disconnect";
            this._discnnctBtn.UseVisualStyleBackColor = true;
            this._discnnctBtn.Click += new System.EventHandler(this.DisconnectButtonHandler);
            // 
            // _ipAddressTextBox
            // 
            this._ipAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ipAddressTextBox.Location = new System.Drawing.Point(233, 50);
            this._ipAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._ipAddressTextBox.Name = "_ipAddressTextBox";
            this._ipAddressTextBox.Size = new System.Drawing.Size(222, 23);
            this._ipAddressTextBox.TabIndex = 2;
            this._ipAddressTextBox.Text = "127.0.0.1";
            this._ipAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _portTxtBox
            // 
            this._portTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portTxtBox.Location = new System.Drawing.Point(233, 124);
            this._portTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._portTxtBox.Name = "_portTxtBox";
            this._portTxtBox.Size = new System.Drawing.Size(222, 23);
            this._portTxtBox.TabIndex = 3;
            this._portTxtBox.Text = "5000";
            this._portTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _ipAddressLbl
            // 
            this._ipAddressLbl.AutoSize = true;
            this._ipAddressLbl.Location = new System.Drawing.Point(4, 47);
            this._ipAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ipAddressLbl.Name = "_ipAddressLbl";
            this._ipAddressLbl.Size = new System.Drawing.Size(65, 15);
            this._ipAddressLbl.TabIndex = 4;
            this._ipAddressLbl.Text = "IP Address:";
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Location = new System.Drawing.Point(4, 121);
            this._portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(32, 15);
            this._portLabel.TabIndex = 5;
            this._portLabel.Text = "Port:";
            this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _statusTextbox
            // 
            this._statusTextbox.Location = new System.Drawing.Point(4, 3);
            this._statusTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._statusTextbox.Multiline = true;
            this._statusTextbox.Name = "_statusTextbox";
            this._statusTextbox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this._statusTextbox, 2);
            this._statusTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._statusTextbox.Size = new System.Drawing.Size(458, 253);
            this._statusTextbox.TabIndex = 2;
            this._statusTextbox.TextChanged += new System.EventHandler(this._statusTextbox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 588);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 829);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "StudentTeacherClient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox _statusTextbox;
        private System.Windows.Forms.Button _sendCommandBtn;
        private System.Windows.Forms.TextBox _commandTextbox;
        private System.Windows.Forms.Button _cnnctBtn;
        private System.Windows.Forms.Button _discnnctBtn;
        private System.Windows.Forms.TextBox _ipAddressTextBox;
        private System.Windows.Forms.TextBox _portTxtBox;
        private System.Windows.Forms.Label _ipAddressLbl;
        private System.Windows.Forms.Label _portLabel;
        private TextBox textBox1;
    }
}