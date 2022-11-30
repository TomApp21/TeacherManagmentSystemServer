
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


        private Dictionary<string, string> teachersClasses = new Dictionary<string, string>();


        private string selectedClassValue;
        private string selectedStudentValue;

        public Form3()
        {
            InitializeComponent();
            ucLogin1.BringToFront();

            _serverIpAddress = IPAddress.Parse(LOCALHOST);
            _port = DEFAULTPORT;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnHome.Visible = false;
            btnLogout.Visible = false;
            //_sendCommandBtn.Enabled = false;

            this.ucLogin1.LoginClicked += new EventHandler(LoginEventHandler_LoginClicked);
            this.ucTeacherMainView1.SortByNumberStudentsClicked += new EventHandler(SortByNumStudentsAsc_SortByNumStudentsClicked);
            this.ucTeacherMainView1.SortByNumberStudentsDescClicked += new EventHandler(SortByNumStudentsDesc_SortByNumStudentsClicked);
            this.ucTeacherMainView1.CreateClassClicked += new EventHandler(CreateClass_CreateClassClicked);

            this.userControl31.CreateClassBtnClicked += new EventHandler(CreateClassForm_Clicked);
            this.ucTeacherMainView1.DeleteClassClicked += new EventHandler(DeleteClass_Clicked);

            this.ucTeacherMainView1.SelectedValueChanged += new EventHandler(SelectedClassValue_Changed);

            this.ucTeacherMainView1.ViewClassClicked += new EventHandler(ViewClass_Clicked);

            this.teacherViewClass1.ViewStudentMark += new EventHandler(ViewStudentMark_Clicked);
            this.teacherViewClass1.SelectedStudentValueChanged += new EventHandler(SelectedStudentValue_Changed);

            this.teacherViewClass1.SubmitStudentMarkClicked += new EventHandler(SubmitMark_Clicked);
        }



        #region Event Handlers


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

                btnHome.Visible = true;
                btnLogout.Visible = true;

                //btnDisconnect.Enabled = true; SEND
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem connecting to server.";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
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

                while (client.Connected)
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
                            case (MessageTypeEnum.GetClassesList):
                                {

                                    List<ClassModel> teachersClassesModel = new List<ClassModel>();
                                    Dictionary<int, string> classes = new Dictionary<int, string>();


                                    String[] strClassIdList = deserializedMsg[1].ToString().Split(',');
                                    String[] strClassNameList = deserializedMsg[2].ToString().Split(',');


                                    var dic2 = strClassIdList.Zip(strClassNameList).ToDictionary(x => x.First, x => x.Second);

                                    PopulateTeacherClassesListbox(dic2);
                                    break;
                                }
                            case (MessageTypeEnum.GetClassesOrderedByStudents):
                                {

                                    List<ClassModel> teachersClassesModel = new List<ClassModel>();
                                    Dictionary<int, string> classes = new Dictionary<int, string>();

                                    String[] strClassIdList = deserializedMsg[1].ToString().Split(',');
                                    String[] strClassNameList = deserializedMsg[2].ToString().Split(',');


                                    var dic2 = strClassIdList.Zip(strClassNameList).ToDictionary(x => x.First, x => x.Second);

                                    PopulateTeacherClassesListbox(dic2);
                                    break;
                                }
                            case (MessageTypeEnum.GetStudentsForClass):
                                {
                                    teacherViewClass1.InvokeExecute(x => x.BringToFront());
                                    teacherViewClass1.InvokeExecute(x => x.Dock = DockStyle.Fill);

                                    
                                    Dictionary<int, string> students = new Dictionary<int, string>();

                                    String[] strStudentIdList = deserializedMsg[1].ToString().Split(',');
                                    String[] strStudentNameList = deserializedMsg[2].ToString().Split(',');


                                    var dic = strStudentIdList.Zip(strStudentNameList).ToDictionary(x => x.First, x => x.Second);

                                    PopulateStudentsListbox(dic);

                                    break;
                                }
                            case (MessageTypeEnum.GetStudentMark):
                                {
                                    teacherViewClass1.InvokeExecute(x => x.StudentMark = deserializedMsg[1].ToString());

                                    break;
                                }
                            //case (MessageTypeEnum.SubmitStudentMark):
                            //    {
                            //        teacherViewClass1.InvokeExecute(x => x.StudentMark = deserializedMsg[1].ToString());

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

            btnHome.InvokeExecute(cb => cb.Visible = false);
            btnLogout.InvokeExecute(cb => cb.Visible = false);
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



        #region Main Form Event Handlers


        #endregion

        #region Login Event Handlers

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

        #region Teacher Class View Event Handlers

        public void SortByNumStudentsAsc_SortByNumStudentsClicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.GetClassesOrderedByStudents);
                    msg.Add(thisUser.UserId);
                    msg.Add("true");

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

        public void SortByNumStudentsDesc_SortByNumStudentsClicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.GetClassesOrderedByStudents);
                    msg.Add(thisUser.UserId);
                    msg.Add("false");

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

        public void CreateClass_CreateClassClicked(object sender, EventArgs e)
        {
            userControl31.InvokeExecute(x => x.BringToFront());
        }

        public void DeleteClass_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.DeleteClass);
                    msg.Add(thisUser.UserId);
                    msg.Add(ucTeacherMainView1.SelectedClassValue);

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

        private void SelectedClassValue_Changed(object sender, EventArgs e)
        {
            selectedClassValue = ucTeacherMainView1.SelectedClassValue;
        }



        #endregion

        #region Teacher Create Class View Event Handler

        public void CreateClassForm_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.CreateClass);
                    msg.Add(thisUser.UserId);
                    msg.Add(userControl31.ClassName);
                    msg.Add(userControl31.StartDate);
                    msg.Add(userControl31.EndDate);
                    msg.Add(userControl31.ModuleCode);

                    var serializedMsg = JsonSerializer.Serialize(msg);


                    sw.WriteLine(serializedMsg);
                    sw.Flush();

                    userControl31.InvokeExecute(x => x.InitializeForm());
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
        public void SelectedStudentValue_Changed(object sender, EventArgs e)
        {
            selectedStudentValue = teacherViewClass1.SelectedStudentValue;
        }
        

        public void ViewStudentMark_Clicked(object sender, EventArgs e)
        {

            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.GetStudentMark);
                    msg.Add(thisUser.UserId);
                    msg.Add(teacherViewClass1.SelectedStudentValue);  // selectedStudentValue);
                    msg.Add(ucTeacherMainView1.SelectedClassValue);

                    var serializedMsg = JsonSerializer.Serialize(msg);

                    sw.WriteLine(serializedMsg);
                    sw.Flush();
                    //_commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
                    //_commandTextbox.Text = String.Empty;
                    teacherViewClass1.InvokeExecute(x => x.SubmitBtnEnabled = true);
                }
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem sending command to the server!";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SubmitMark_Clicked(object sender, EventArgs e)
        { 
            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.SubmitStudentMark);
                    msg.Add(teacherViewClass1.SelectedStudentValue); // selectedStudentValue);
                    msg.Add(ucTeacherMainView1.SelectedClassValue);
                    msg.Add(teacherViewClass1.StudentMark);


                    var serializedMsg = JsonSerializer.Serialize(msg);

                    sw.WriteLine(serializedMsg);
                    sw.Flush();

                    teacherViewClass1.InvokeExecute(x => x.SubmitBtnEnabled = false);

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

        
        


        public void ViewClass_Clicked(object sender, EventArgs e)
        {

            try
            {
                if (_client.Connected)
                {
                    StreamWriter sw = new StreamWriter(_client.GetStream());

                    ArrayList msg = new ArrayList();
                    msg.Add(MessageTypeEnum.GetStudentsForClass);
                    msg.Add(thisUser.UserId);
                    msg.Add(ucTeacherMainView1.SelectedClassValue);

                    var serializedMsg = JsonSerializer.Serialize(msg);

                    sw.WriteLine(serializedMsg);
                    sw.Flush();
                    //_commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
                    //_commandTextbox.Text = String.Empty;
                                teacherViewClass1.InvokeExecute(x => x.BringToFront());

                }
            }
            catch (Exception ex)
            {
                //_statusTextbox.Text += CRLF + "Problem sending command to the server!";
                //_statusTextbox.Text += CRLF + ex.ToString();
            }
        }
        #region
        #endregion














        #region Control Data Sources
        /// <summary>
        /// Updates datasource on user control.
        /// </summary>
        private void PopulateTeacherClassesListbox(Dictionary<string, string> teachersClasses)
        {

            if (teachersClasses.ContainsKey(String.Empty))
            {
                teachersClasses.Remove(String.Empty);
                ucTeacherMainView1.InvokeExecute(x => x.DeleteEnabled = false);
            }
            else
            {
                ucTeacherMainView1.InvokeExecute(x => x.DeleteEnabled = true);
            }

            ucTeacherMainView1.InvokeExecute(x => x.TeachersClasses = teachersClasses);
            ucTeacherMainView1.InvokeExecute(x => x.UpdateDataSource());
        }

                /// <summary>
        /// Updates datasource on user control.
        /// </summary>
        private void PopulateStudentsListbox(Dictionary<string, string> theseStudents)
        {

            //if (theseStudents.ContainsKey(String.Empty))
            //{
            //    theseStudents.Remove(String.Empty);
            //    ucTeacherMainView1.InvokeExecute(x => x.DeleteEnabled = false);
            //}
            //else
            //{
            //    ucTeacherMainView1.InvokeExecute(x => x.DeleteEnabled = true);
            //}

            teacherViewClass1.InvokeExecute(x => x.Students = theseStudents);
            teacherViewClass1.InvokeExecute(x => x.UpdateDataSource());
        }


        #endregion


        /// <summary>
        /// Format windows/ show hide controls depending on role.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (thisUser.IsTeacher)
            {
                try
                {
                    if (_client.Connected)
                    {
                        StreamWriter sw = new StreamWriter(_client.GetStream());

                        ArrayList msg = new ArrayList();
                        msg.Add(MessageTypeEnum.GetClassesOrderedByStudents);
                        msg.Add(thisUser.UserId);
                        msg.Add("true");

                        var serializedMsg = JsonSerializer.Serialize(msg);

                        sw.WriteLine(serializedMsg);
                        sw.Flush();

                        ucTeacherMainView1.InvokeExecute(x => x.BringToFront());
                        teacherViewClass1.InvokeExecute(x => x.StudentMark = "");
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
            else
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
