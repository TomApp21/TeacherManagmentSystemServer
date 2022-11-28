using ClassLibrary.Models;
using ClassLibrary.Handlers;
using ClassLibrary.Queries;
using MediatR;
using System.Net;
using System.Net.Sockets;
using TeacherManagementSystemClient.Utilities;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TeacherManagementSystemClient
{
    public partial class Form1 : Form
    {
        static List<TeacherModel> DeserealizeTeachers(NetworkStream stream)
        {
            BinaryFormatter bf =   new BinaryFormatter();

            var x = bf.Deserialize(stream);


            return (List<TeacherModel>)bf.Deserialize(stream);
        }


      // Constants
        private const String CRLF = "\r\n";
        private const String LOCALHOST = "127.0.0.1";
        private const int DEFAULTPORT = 5000;

        // Fields
        private IPAddress _serverIpAddress;
        private int _port;
        private TcpClient _client;

        private readonly IMediator _mediator;

        List<TeacherModel> teachers= new List<TeacherModel>();

        public Form1(IMediator mediator)
        {
            _mediator = mediator;


            InitializeComponent();


            _serverIpAddress = GetIPAddress(_ipAddressTextBox.Text);
            _port = GetPort(_portTxtBox.Text);

            _cnnctBtn.Enabled = true;
            _discnnctBtn.Enabled = false;
            _sendCommandBtn.Enabled = false;    
        }

        private async void init()
        {
            teachers = await _mediator.Send(new GetPersonListQuery());
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

                _cnnctBtn.Enabled = false;
                _discnnctBtn.Enabled = true;
                _sendCommandBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                _statusTextbox.Text += CRLF + "Problem connecting to server.";
                _statusTextbox.Text += CRLF + ex.ToString();
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
                    sw.WriteLine(_commandTextbox.Text);
                    sw.Flush();
                    _commandTextbox.Text += CRLF + "Command sent to server: " + _commandTextbox.Text;
                    _commandTextbox.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                _statusTextbox.Text += CRLF + "Problem sending command to the server!";
                _statusTextbox.Text += CRLF + ex.ToString();
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
                                    teachers = DeserealizeTeachers(client.GetStream());
                                    break;
                                }

                            default:
                                {
                                    _statusTextbox.InvokeExecute(SendToBack => SendToBack.Text += CRLF + ". Received from Server: " + input);
                                    break;
                                }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                _statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Problem communicating with the server. Commention hay have disconnected.");
                _statusTextbox.InvokeExecute(stb => stb.Text += CRLF + ex.ToString());
            }

            _cnnctBtn.InvokeExecute(cb => cb.Enabled = true);
            _discnnctBtn.InvokeExecute(dcb => dcb.Enabled = false);
        }


        private void DisconnectFromServer()
        {
            try
            {
                _client.Close();
                _statusTextbox.InvokeExecute(stb => stb.Text += String.Empty);
                _cnnctBtn.InvokeExecute(cb => cb.Enabled = true);
                _discnnctBtn.InvokeExecute(dcb => dcb.Enabled = false);
                _sendCommandBtn.InvokeExecute(dcb => dcb.Enabled = false);
                _statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Disconnected from the server!");

            }
            catch (Exception ex) 
            {
                _statusTextbox.InvokeExecute(stb => stb.Text += CRLF + "Problem disconnecting from the server.");
                _statusTextbox.InvokeExecute(stb => stb.Text += CRLF +  ex.ToString());
            }
        }



        private IPAddress GetIPAddress(string ipAddress)
        {
            IPAddress address = IPAddress.Parse(LOCALHOST);

            try
            {
                if (!IPAddress.TryParse(ipAddress, out address)) {

                    address = IPAddress.Parse(ipAddress);
                }
            }
            catch (Exception ex)
            {
                _statusTextbox.Text += CRLF + "Invalid IP address - Client will connect to: " + _serverIpAddress.ToString();
                _statusTextbox.Text += CRLF + ex.ToString();
            }
            return address;
        }

        private int GetPort(string serverPort)
        {
            int port = DEFAULTPORT;

            try
            {
                if (!Int32.TryParse(serverPort, out port))
                {

                    port = 5000;
                }
            }
            catch (Exception ex)
            {
                _statusTextbox.Text += CRLF + "Invalid port value - Client will connect to port: " + port.ToString();
                _statusTextbox.Text += CRLF + ex.ToString();
            }
            return port;
        }


        #endregion

        private void _statusTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}