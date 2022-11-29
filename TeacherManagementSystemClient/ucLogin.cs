using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManagementSystemClient.Utilities;

namespace TeacherManagementSystemClient
{
    public partial class ucLogin : UserControl
    {
        private string pw; 
                public event EventHandler LoginClicked;

        public ucLogin()
        {
            InitializeComponent();
        }

        #region Properties

        public string Username
        {
            get { return textBox1Username.Text; }
            set { textBox1Username.Text = value;}
        }

        public string Password
        {
            get { return textBox1Password.Text; }
            set { textBox1Password.Text = value;}
        }

        public bool LogInBtnEnabled
        {
            get { return buttonLogin.Enabled; }
            set { buttonLogin.InvokeExecute(lb => lb.Enabled = value);}
        }

        #endregion

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.LoginClicked != null) 
                this.LoginClicked(this, new EventArgs());
        }
    }
}
