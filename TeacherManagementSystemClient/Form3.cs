
using ClassLibrary.Enum;
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


                // Say hello to the server once a connection has been established.
                sw.WriteLine("Hello from a client! Ready to do your bidding.");
                sw.Flush();

                while(client.Connected)
                {
                    input = sr.ReadLine(); // block until server sends something.

                    if (input == null)
                    {
                        DisconnectFromServer();
                    }
                    else
                    {
                         switch (input)
                        {
                            case ("Server received: GetTeachers"):
                                {
                                    sw.WriteLine(input);
                                    sw.Flush();
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
                btnConnect.InvokeExecute(cb => cb.Enabled = true);
                btnDisconnect.InvokeExecute(dcb => dcb.Enabled = false);
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

 


    }
}
