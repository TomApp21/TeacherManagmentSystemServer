using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManagementSystemClient
{
    public partial class Form2 : Form
    {
        // Constants
        private const String CRLF = "\r\n";
        private const String LOCALHOST = "127.0.0.1";
        private const int DEFAULTPORT = 5000;

        // Fields
        private IPAddress _serverIpAddress;
        private int _port;
        private TcpClient _client;

        public Form2()
        {
            InitializeComponent();
            userControl11.BringToFront();

            _serverIpAddress =  IPAddress.Parse(LOCALHOST);
            _port = DEFAULTPORT;

        }


        #region Show Hide Controls

            private void CreateInstance(Control module) {
            var controls = panelContainer.Controls.OfType<UserControl>().ToList();

            foreach(var control in controls) {
                control.Dispose();
            }

            panelContainer.Controls.Add(module);
            module.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateInstance(new UserControl1());

        }

        private void button2_Click(object sender, EventArgs e)
        {
                CreateInstance(new UserControl2());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateInstance(new UserControl3());
        }

        #endregion




    }
}
