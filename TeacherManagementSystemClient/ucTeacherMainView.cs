﻿using System;
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
    public partial class ucTeacherMainView : UserControl
    {
                        public event EventHandler SortByNumberStudentsClicked;
                        public event EventHandler SortByNumberStudentsDescClicked;


        public ucTeacherMainView()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> TeachersClasses { get; set; }


        public void UpdateDataSource()
        {
            listboxTeacherClasses.DataSource = new BindingSource(TeachersClasses, null);

            listboxTeacherClasses.DisplayMember = "Value";
            listboxTeacherClasses.ValueMember = "Key";

        }

        /// <summary>
        /// Event handler for sort classes by name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortName_Click(object sender, EventArgs e)
        {

            var ascendingDic = TeachersClasses.OrderBy(pair => pair.Value).Take(10)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            TeachersClasses = ascendingDic;
            UpdateDataSource();
        }

        private void btnSortNameDesc_Click(object sender, EventArgs e)
        {
            var descendingDic = TeachersClasses.OrderByDescending(pair => pair.Value).Take(10)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            TeachersClasses = descendingDic;
            UpdateDataSource();
        }

        private void btnSortNo_Click(object sender, EventArgs e)
        {
            if (this.SortByNumberStudentsClicked != null)
                this.SortByNumberStudentsClicked(this, new EventArgs());
        }

        private void btnSortNoDesc_Click(object sender, EventArgs e)
        {
                        if (this.SortByNumberStudentsDescClicked != null)
                this.SortByNumberStudentsDescClicked(this, new EventArgs());
        }


    }
}