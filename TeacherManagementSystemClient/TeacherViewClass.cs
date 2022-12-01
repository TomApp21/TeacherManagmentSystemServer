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
    public partial class TeacherViewClass : UserControl
    {
        public event EventHandler ViewStudentMark;
        public event EventHandler SelectedStudentValueChanged;
                public event EventHandler SubmitStudentMarkClicked;

        public Dictionary<string, string> Students { get; set; }

        public string SelectedStudentValue {
            get { return listBoxStudents.SelectedValue.ToString();  }
        }

        public string StudentMark {
            get { return textBox1StuMark.Text; }
            set { textBox1StuMark.Text = value; }
        }


        public void SetTextboxReadonly()
        {
            textBox1StuMark.ReadOnly = true;
        }

        public bool SubmitBtnEnabled { 
             get { return btnSubmit.Enabled; }
            set { btnSubmit.Enabled = value; }
        }

                public string SetUserName
        {
            set { lblUsername.Text = value;}
        }
        public bool ViewStudentEnabled
        {
            get
            {
                return btnView.Enabled;
            }
            set
            {
                btnView.Enabled = value;
            }
        }

        public TeacherViewClass()
        {
            InitializeComponent();
        }

        
        public void UpdateDataSource()
        {
            listBoxStudents.DataSource = new BindingSource(Students, null);

            listBoxStudents.DisplayMember = "Value";
            listBoxStudents.ValueMember = "Key";

            if (Students.Count == 0)
            {
                ViewStudentEnabled = false;
            }
            else
            {
                ViewStudentEnabled = true;
            }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.ViewStudentMark != null) 
                this.ViewStudentMark(this, new EventArgs());
        }

        private void listBoxStudents_SelectedValueChanged(object sender, EventArgs e)
        {
                        if (this.SelectedStudentValueChanged != null) 
                this.SelectedStudentValueChanged(this, new EventArgs());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
                if (this.SubmitStudentMarkClicked != null) 
                this.SubmitStudentMarkClicked(this, new EventArgs());
        }
    }
}
