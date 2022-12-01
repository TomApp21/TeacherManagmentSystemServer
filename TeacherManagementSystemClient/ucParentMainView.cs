using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManagementSystemClient
{
    public partial class ucParentMainView : UserControl
    {
        public event EventHandler ViewParentClassMark;
        public event EventHandler JoinClass;
        public event EventHandler SelectedValueClassParentChanged; 
                public Dictionary<string, string> Classes { get; set; }

        public ucParentMainView()
        {
            InitializeComponent();
        }

        public string SelectedParentClassValue {
            get { return listBox1ParentsClasses.SelectedValue.ToString();  }
        }
        public string StudentMark {
            get { return textBoxMark.Text; }
            set { textBoxMark.Text = value; }
        }

        public string JoinClassCode {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        
        
        public bool InvalidMsgVisible {
            get { return labelInvalid.Visible; }
            set { labelInvalid.Visible = value; }
        }
        
        public string SetUserName
        {
            set { lblUsername.Text = value;}
        }

        public void UpdateDataSource()
        {
            listBox1ParentsClasses.DataSource = new BindingSource(Classes, null);

            listBox1ParentsClasses.DisplayMember = "Value";
            listBox1ParentsClasses.ValueMember = "Key";

        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
                        if (this.ViewParentClassMark != null) 
                this.ViewParentClassMark(this, new EventArgs());
        }

        private void btnJoinClass_Click(object sender, EventArgs e)
        {
                           if (this.JoinClass != null) 
                this.JoinClass(this, new EventArgs());
        }

        private void listBox1ParentsClasses_SelectedValueChanged(object sender, EventArgs e)
        {
            
                        if (this.SelectedValueClassParentChanged != null) 
                this.SelectedValueClassParentChanged(this, new EventArgs());
        }
    }
}
