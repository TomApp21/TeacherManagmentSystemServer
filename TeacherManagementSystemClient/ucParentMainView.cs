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
                public Dictionary<string, string> Classes { get; set; }

        public ucParentMainView()
        {
            InitializeComponent();
        }

        public void UpdateDataSource()
        {
            listBox1ParentsClasses.DataSource = new BindingSource(Classes, null);

            listBox1ParentsClasses.DisplayMember = "Value";
            listBox1ParentsClasses.ValueMember = "Key";

        }

    }
}
