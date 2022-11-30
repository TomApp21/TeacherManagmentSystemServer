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
        public event ViewStudentMark

        public Dictionary<string, string> Students { get; set; }

        public string SelectedStudentValue {
            get { return listBoxStudents.SelectedValue.ToString();  }
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

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
