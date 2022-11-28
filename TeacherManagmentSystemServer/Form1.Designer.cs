namespace TeacherManagmentSystemServer
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
            this._cnnctedClientsLbl = new System.Windows.Forms.Label();
            this._cnnctdClientsTextbox = new System.Windows.Forms.TextBox();
            this._sendCommandBtn = new System.Windows.Forms.Button();
            this._clientCommandTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._StartServerBtn = new System.Windows.Forms.Button();
            this._StopServerBtn = new System.Windows.Forms.Button();
            this._portLbl = new System.Windows.Forms.Label();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this._statusTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.10825F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.89175F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._statusTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._cnnctedClientsLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._cnnctdClientsTextbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._sendCommandBtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._clientCommandTextbox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(620, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.04762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 253);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _cnnctedClientsLbl
            // 
            this._cnnctedClientsLbl.AutoSize = true;
            this._cnnctedClientsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cnnctedClientsLbl.Location = new System.Drawing.Point(4, 0);
            this._cnnctedClientsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._cnnctedClientsLbl.Name = "_cnnctedClientsLbl";
            this._cnnctedClientsLbl.Size = new System.Drawing.Size(146, 30);
            this._cnnctedClientsLbl.TabIndex = 0;
            this._cnnctedClientsLbl.Text = "Connected Clients:";
            this._cnnctedClientsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _cnnctdClientsTextbox
            // 
            this._cnnctdClientsTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cnnctdClientsTextbox.Location = new System.Drawing.Point(158, 3);
            this._cnnctdClientsTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cnnctdClientsTextbox.Name = "_cnnctdClientsTextbox";
            this._cnnctdClientsTextbox.ReadOnly = true;
            this._cnnctdClientsTextbox.Size = new System.Drawing.Size(147, 23);
            this._cnnctdClientsTextbox.TabIndex = 1;
            this._cnnctdClientsTextbox.Text = "0";
            this._cnnctdClientsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _sendCommandBtn
            // 
            this._sendCommandBtn.Location = new System.Drawing.Point(158, 224);
            this._sendCommandBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._sendCommandBtn.Name = "_sendCommandBtn";
            this._sendCommandBtn.Size = new System.Drawing.Size(147, 25);
            this._sendCommandBtn.TabIndex = 2;
            this._sendCommandBtn.Text = "Send Command";
            this._sendCommandBtn.UseVisualStyleBackColor = true;
            this._sendCommandBtn.Click += new System.EventHandler(this.SendCommandBtnHandler);
            // 
            // _clientCommandTextbox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._clientCommandTextbox, 2);
            this._clientCommandTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientCommandTextbox.Location = new System.Drawing.Point(4, 101);
            this._clientCommandTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._clientCommandTextbox.Multiline = true;
            this._clientCommandTextbox.Name = "_clientCommandTextbox";
            this._clientCommandTextbox.Size = new System.Drawing.Size(301, 117);
            this._clientCommandTextbox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._StartServerBtn, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this._StopServerBtn, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this._portLbl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._portTextBox, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(620, 262);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.51685F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48315F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(309, 254);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _StartServerBtn
            // 
            this._StartServerBtn.Location = new System.Drawing.Point(158, 224);
            this._StartServerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._StartServerBtn.Name = "_StartServerBtn";
            this._StartServerBtn.Size = new System.Drawing.Size(147, 27);
            this._StartServerBtn.TabIndex = 0;
            this._StartServerBtn.Text = "Start Server";
            this._StartServerBtn.UseVisualStyleBackColor = true;
            this._StartServerBtn.Click += new System.EventHandler(this.StartServerBtnHandler);
            // 
            // _StopServerBtn
            // 
            this._StopServerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._StopServerBtn.Location = new System.Drawing.Point(4, 224);
            this._StopServerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._StopServerBtn.Name = "_StopServerBtn";
            this._StopServerBtn.Size = new System.Drawing.Size(146, 27);
            this._StopServerBtn.TabIndex = 1;
            this._StopServerBtn.Text = "Stop Server";
            this._StopServerBtn.UseVisualStyleBackColor = true;
            this._StopServerBtn.Click += new System.EventHandler(this.StopServerBtnHandler);
            // 
            // _portLbl
            // 
            this._portLbl.AutoSize = true;
            this._portLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portLbl.Location = new System.Drawing.Point(4, 192);
            this._portLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._portLbl.Name = "_portLbl";
            this._portLbl.Size = new System.Drawing.Size(146, 29);
            this._portLbl.TabIndex = 2;
            this._portLbl.Text = "Listen on Port:";
            this._portLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _portTextBox
            // 
            this._portTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portTextBox.Location = new System.Drawing.Point(158, 195);
            this._portTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(147, 23);
            this._portTextBox.TabIndex = 3;
            this._portTextBox.Text = "5000";
            this._portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _statusTextBox
            // 
            this._statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusTextBox.Location = new System.Drawing.Point(4, 3);
            this._statusTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._statusTextBox.Multiline = true;
            this._statusTextBox.Name = "_statusTextBox";
            this._statusTextBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this._statusTextBox, 2);
            this._statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._statusTextBox.Size = new System.Drawing.Size(608, 513);
            this._statusTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Student Teacher Server";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button _StartServerBtn;
        private System.Windows.Forms.Button _StopServerBtn;
        private System.Windows.Forms.Label _portLbl;
        private System.Windows.Forms.TextBox _statusTextBox;
        private System.Windows.Forms.TextBox _portTextBox;
        private System.Windows.Forms.Label _cnnctedClientsLbl;
        private System.Windows.Forms.TextBox _cnnctdClientsTextbox;
        private System.Windows.Forms.Button _sendCommandBtn;
        private System.Windows.Forms.TextBox _clientCommandTextbox;
    }
}