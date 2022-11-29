﻿using ClassLibrary.Enum;
using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TeacherManagementSystemClient.Utilities;

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

        // EVENT

        private UserModel thisUser;

        public Form2()
        {

            InitializeComponent();
            ucLogin.BringToFront();

            _serverIpAddress =  IPAddress.Parse(LOCALHOST);
            _port = DEFAULTPORT;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;


            // set up event handlers
            // --------------------

            this.ucLogin.LoginClicked += new EventHandler(LoginEventHandler_LoginClicked);
        }


        #region Show Hide Controls

        private void button1_Click(object sender, EventArgs e)
        {
            ucLogin.BringToFront();
            ucLogin.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl2.BringToFront();
            userControl2.Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl3.BringToFront();
            userControl3.Dock = DockStyle.Fill;
        }

        #endregion


        #region Event Handlers

        // Connect to a server
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
                ucLogin.LogInBtnEnabled = true;
                //btnDisconnect.Enabled = true; SEND
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


        private void SendCommandButtonHandler(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());
                    sw.WriteLine(ucLogin.Password);
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

                ArrayList msg = new ArrayList();
                msg.Add(MessageTypeEnum.ExchangePublicKeys);
                msg.Add("Hi");
                var serializedMsg = JsonSerializer.Serialize(msg);

                // Say hello to the server once a connection has been established.
                sw.WriteLine(serializedMsg);
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
                         var deserialisedMsg = JsonSerializer.Deserialize<ArrayList>(input);

                        MessageTypeEnum messageId = (MessageTypeEnum)Enum.Parse(typeof(MessageTypeEnum), deserialisedMsg[0].ToString());    
                         
                        switch (messageId)
                         {
                            case (MessageTypeEnum.UserLoginRequestResponse):
                            {
                                //_statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "From client: " + client.GetHashCode() + ": " + input); // gets unique hash code (id) of client

                                UserModel userModel = new UserModel();
                                userModel.UserName = deserialisedMsg[1].ToString();
                                userModel.Password = deserialisedMsg[2].ToString();
                                userModel.UserId = Convert.ToInt32(deserialisedMsg[3]);
                                userModel.Name = deserialisedMsg[4].ToString();
                                userModel.IsTeacher = Convert.ToBoolean(deserialisedMsg[5]);

                                thisUser = userModel;

                                //sw.WriteLine(serializedMsg);
                                //sw.Flush();
                             
                                break;
                            }

                            //case ("Server received: GetTeachers"):
                            //    {
                            //        sw.WriteLine(input);
                            //        sw.Flush();
                            //        //users = DeserealizeTeachers(client.GetStream());
                            //        break;
                            //    }

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
            ucLogin.LogInBtnEnabled = false;
        }


        private void DisconnectFromServer()
        {
            try
            {
                _client.Close();
                //_statusTextbox.InvokeExecute(stb => stb.Text += String.Empty);
                btnConnect.InvokeExecute(cb => cb.Enabled = true);
                btnDisconnect.InvokeExecute(dcb => dcb.Enabled = false);

                //ucLogin.InvokeExecute(cb => cb.LogInBtnEnabled == false);
                //_sendCommandBtn.InvokeExecute(dcb => dcb.Enabled = false);
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Disconnected from the server!");

            }
            catch (Exception ex)
            {
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Problem disconnecting from the server.");
                //_statusTextbox.InvokeExecute(stb => stb.Text += CRLF + ex.ToString());
            }
        }

            #endregion


        public void LoginEventHandler_LoginClicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.UserLoginRequestResponse);
                    msg.Add(ucLogin.Username);
                    msg.Add(ucLogin.Password);

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




    }
}
