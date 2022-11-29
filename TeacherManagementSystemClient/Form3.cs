
using ClassLibrary.Enum;
using ClassLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManagementSystemClient.Utilities;

namespace TeacherManagementSystemClient
{
    public partial class Form3 : Form
    {
       // Constants
        private const String CRLF = "\r\n";
        private const String LOCALHOST = "127.0.0.1";
        private const int DEFAULTPORT = 5000;

        // Fields
        private IPAddress _serverIpAddress;
        private int _port;
        private TcpClient _client;

        private UserModel thisUser;


        public Form3()
        {
            InitializeComponent();
            ucLogin1.BringToFront();

            _serverIpAddress =  IPAddress.Parse(LOCALHOST);
            _port = DEFAULTPORT;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            //_sendCommandBtn.Enabled = false;

            this.ucLogin1.LoginClicked += new EventHandler(LoginEventHandler_LoginClicked);

            
        }



        #region Event Handlers

        // Connect to a server
        private void ConnectButtonHandler(object sender, EventArgs e)
        {
            try
            {
                _client = new TcpClient(_serverIpAddress.ToString(), _port);
                Thread t = new Thread(ProcessClientTransactions);
                t.IsBackground = true;
                t.Start(_client);

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                //_sendCommandBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem connecting to server.";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }



        private void DisconnectButtonHandler(object sender, EventArgs e)
        {
            DisconnectFromServer();
        }


        //private void SendCommandButtonHandler(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_client.Connected)
        //        {
        //            StreamWriter sw = new StreamWriter(_client.GetStream());
        //            sw.WriteLine(_commandTextbox.Text);
        //            sw.Flush();

        //            _commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
        //            _commandTextbox.Text = String.Empty;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _statusTextbox.Text += CRLF + "Problem sending command to the server!";
        //        _statusTextbox.Text += CRLF + ex.ToString();
        //    }
        //}

        #endregion

        #region Utility Methods


        private void ProcessClientTransactions(object tcpClient)
        {
            // cast as TcpClient to get access to all associated methods.
            TcpClient client = (TcpClient)tcpClient;
            
            string input = String.Empty;
            StreamReader sr = null;
            StreamWriter sw = null;

            try
            {
                sr = new StreamReader(client.GetStream());
                sw = new StreamWriter(client.GetStream());

                // Build initial client connection message
                // ---------------------------------------
                ArrayList msg = new ArrayList();
                msg.Add(MessageTypeEnum.ClientConnection);

                var serializedMsg = JsonSerializer.Serialize(msg);


                // Say hello to the server once a connection has been established.
                sw.WriteLine(serializedMsg);
                sw.Flush();

                while(client.Connected)
                {
                    input = sr.ReadLine(); // block until server sends something.

                    var deserializedMsg = JsonSerializer.Deserialize<ArrayList>(input);
                    MessageTypeEnum messageId = (MessageTypeEnum)Enum.Parse(typeof(MessageTypeEnum), deserializedMsg[0].ToString());


                    if (input == null)
                    {
                        DisconnectFromServer();
                    }
                    else
                    {
                         switch (messageId)
                        {
                            case (MessageTypeEnum.UserLoginRequestResponse):
                                {
                                    
                                    UserModel userModel = new UserModel();
                                    userModel.UserName = deserializedMsg[1].ToString();
                                    userModel.Password = deserializedMsg[2].ToString();
                                    userModel.UserId = Convert.ToInt32(deserializedMsg[3].ToString());
                                    userModel.Name = deserializedMsg[4].ToString();
                                    userModel.IsTeacher = Convert.ToBoolean(deserializedMsg[5].ToString());

                                    thisUser = userModel;

                                    // show logout button
                                    btnLogout.Enabled = true;
                                    ucTeacherMainView1.InvokeExecute(x => x.BringToFront());
                                    ucTeacherMainView1.InvokeExecute(x => x.Dock = DockStyle.Fill);

                                    GetTeacherClasses();

                                    //sw.WriteLine(input);
                                    //sw.Flush();
                                   break;
                                }
                            case (MessageTypeEnum.GetClassesList) :
                                {

                                    List<ClassModel> teachersClassesModel = new List<ClassModel>();
                                    Dictionary<int, string> classes = new Dictionary<int, string>();

                                    String[] strClassIdList = deserializedMsg[1].ToString().Split(',');
                                    String[] strClassNameList = deserializedMsg[2].ToString().Split(',');


                                    var dic2 = strClassIdList.Zip(strClassNameList).ToDictionary(x => x.First, x => x.Second)

              











                                    //teachers

                                    //userModel.UserName = deserializedMsg[1].ToString();
                                    //userModel.Password = deserializedMsg[2].ToString();
                                    //userModel.UserId = Convert.ToInt32(deserializedMsg[3].ToString());
                                    //userModel.Name = deserializedMsg[4].ToString();
                                    //userModel.IsTeacher = Convert.ToBoolean(deserializedMsg[5].ToString());

                                    //thisUser = userModel;

                                    // show logout button
                                    btnLogout.Enabled = true;
                                    ucTeacherMainView1.InvokeExecute(x => x.BringToFront());
                                    ucTeacherMainView1.InvokeExecute(x => x.Dock = DockStyle.Fill);

                                    GetTeacherClasses();

                                    //sw.WriteLine(input);
                                    //sw.Flush();
                                   break;
                                }



                            default:
                                {
                                    //_statusTextbox.InvokeExecute(SendToBack => SendToBack.Text += CRLF + ". Received from Server: " + input);
                                    break;
                                }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Problem communicating with the server. Commention hay have disconnected.");
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + ex.ToString());
            }

            btnConnect.InvokeExecute(cb => cb.Enabled = true);
            btnDisconnect.InvokeExecute(dcb => dcb.Enabled = false);
        }


        private void DisconnectFromServer()
        {
            try
            {
                _client.Close();
                //_statusTextbox.InvokeExecute(stb => stb.Text += String.Empty);
                btnConnect.InvokeExecute(cb => cb.Enabled = false);
                btnDisconnect.InvokeExecute(dcb => dcb.Enabled = true);
                //btns.InvokeExecute(dcb => dcb.Enabled = false);
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Disconnected from the server!");

            }
            catch (Exception ex) 
            {
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Problem disconnecting from the server.");
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF +  ex.ToString());
            }
        }


        public void LoginEventHandler_LoginClicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.UserLoginRequestResponse);
                    msg.Add(ucLogin1.Username);
                    msg.Add(ucLogin1.Password);

                    var serializedMsg = JsonSerializer.Serialize(msg);


                    sw.WriteLine(serializedMsg);
                    sw.Flush();
                    //_commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
                    //_commandTextbox.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem sending command to the server!";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }

        public void GetTeacherClasses()
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.GetClassesList);
                    msg.Add(thisUser.UserId);

                    var serializedMsg = JsonSerializer.Serialize(msg);


                    sw.WriteLine(serializedMsg);
                    sw.Flush();
                    //_commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
                    //_commandTextbox.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem sending command to the server!";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }



        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _client = new TcpClient(_serverIpAddress.ToString(), _port);
                Thread t = new Thread(ProcessClientTransactions);
                t.IsBackground = true;
                t.Start(_client);

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                ucLogin1.LogInBtnEnabled = true;
                //btnDisconnect.Enabled = true; SEND
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem connecting to server.";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }

        /// <summary>
        /// Log user out, hide nav menu options, show lg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            thisUser = new UserModel();
            ucLogin1.BringToFront();
        }
    }
}
