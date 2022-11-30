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
    public partial class UserControl3 : UserControl
    {
        public event EventHandler CreateClassBtnClicked;

        #region Properties

        public string ClassName
        {
            get { return textBoxClassName.Text; }
            set { textBoxClassName.Text = value;}
        }

        public DateTime StartDate
        {
            get { return dateTimePickerStart.Value; }
            set { dateTimePickerStart.Value = value;}
        }
        public DateTime EndDate
        {
            get { return dateTimePickerEnd.Value; }
            set { dateTimePickerEnd.Value = value;}
        }

        public string ModuleCode
        {
            get { return textboxModuleCode.Text; }
            set { textboxModuleCode.Text = value;}
        }

        #endregion


        public UserControl3()
        {
            InitializeComponent();
        }

        public void InitializeForm()
        {
            textBoxClassName.Clear();
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerStart.MinDate = DateTime.Now;
            textboxModuleCode.Clear();
        }

        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
                   // check all controls populatwed
                        if (this.CreateClassBtnClicked != null) 
                this.CreateClassBtnClicked(this, new EventArgs());
     
        }
    }
}
