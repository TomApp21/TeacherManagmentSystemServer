using ClassLibrary.Models;
using System.Net;
using System.Net.Sockets;
using TeacherManagmentSystemServer.Utilities;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MediatR;
using ClassLibrary.Queries;

namespace TeacherManagmentSystemServer
{
    public partial class Form1 : Form
    {

        private readonly IMediator _mediator;
        // Server app needs to listen on a port.


        // Constants
        private const string CRLF = "\r\n";

        // Fields
        private List<TcpClient> _tcpClientList;
        private TcpListener _listener; // listens for incoming connections
        private int _clientCount;
        private bool _continue;
        private int _port;

        // declarations
        List<TeacherModel> teachers;


        public Form1(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();

            // get list of teachers




            _tcpClientList = new List<TcpClient>();
            _cnnctdClientsTextbox.Text = "0";

            _sendCommandBtn.Enabled = false;
            _StartServerBtn.Enabled = true;
            _StopServerBtn.Enabled = false;

            _statusTextBox.Text = String.Empty;

            //_listener = new TcpListener();
            //_clientCount = 0;
            //_continue = false;
            //_port
        }

        #region Event Handlers

        private void StartServerBtnHandler(object sender, EventArgs e)
        {
            try
            {
                if (!Int32.TryParse(_portTextBox.Text, out _port))
                {
                    _port = 5000;
                    _statusTextBox.Text += CRLF + "You entered an invalid port number. Using port " + _port;
                }
                Thread t = new Thread(ListenForIncomingConnections);
                t.Name = "Student Teacher Listener Thread";
                t.IsBackground = true;
                t.Start();

                _sendCommandBtn.Enabled = true;
                _StartServerBtn.Enabled = false;
                _StopServerBtn.Enabled = true;

            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem Starting server.";
                _statusTextBox.Text += CRLF + ex.ToString();
            }
        }

        private void StopServerBtnHandler(object sender, EventArgs e)
        {
            _continue = false;

            // This is in the thread so don't need to do invoke ex status textbox.
            _statusTextBox.Text = String.Empty;
            _statusTextBox.Text = "Shutting down server, disconnecting all clients...";

            try
            {
                foreach (TcpClient client in _tcpClientList)
                {
                    client.Close();
                    _clientCount -= 1;
                    _cnnctdClientsTextbox.Text = _clientCount.ToString();
                }
                // clear disconnected clients
                _tcpClientList.Clear();

                _listener.Stop();
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += "Problem stopping the server, or client connections forcebly closed.";
                _statusTextBox.Text += CRLF + ex.ToString();
            }

            _sendCommandBtn.Enabled = false;
            _StartServerBtn.Enabled = true;
            _StopServerBtn.Enabled = false;
            _clientCount = 0;
        
        }

        private void SendCommandBtnHandler(object sender, EventArgs e)
        {
            try
            {
                foreach (TcpClient client in _tcpClientList)
                {

                    StreamWriter sw = new StreamWriter(client.GetStream());
                    sw.WriteLine(_clientCommandTextbox.Text);
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem sending commands to clients...";
                _statusTextBox.Text += CRLF + ex.ToString();
            }
            _clientCommandTextbox.Text = String.Empty;
        }


        #endregion


        #region Regular Methods

        // thi method in a different thread
        private void ListenForIncomingConnections()
        {
            try
            {
                _continue = true;
                _listener = new TcpListener(IPAddress.Any, _port);
                _listener.Start();
                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "server started, listening on port:" + _port);

                // accepts incoming connections
                while (_continue)
                {
                    _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Waiting for incoming client connections.");

                    TcpClient client = _listener.AcceptTcpClient(); // Blocks until client connection accepted.
                    _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Incoming client connection accepted.");

                    // create a new thread for new client connection
                    Thread t = new Thread(ProcessClientRequests);
                    t.IsBackground = true;
                    t.Start(client);
                }




            }
            catch (SocketException se)
            {

            }
            catch (Exception ex)
            {
                _statusTextBox.InvokeExecute(stb => stb.Text += ex.ToString());

            }

            _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Exiting listener thread...");
            _statusTextBox.InvokeExecute(stb => stb.Text = String.Empty);

        } // end ListenForIncomingClientConnections


        private void ProcessClientRequests(object tcpClient)
        {
            TcpClient client = (TcpClient)tcpClient;

            // add to list so can broadcast messages to it and send shutdown events
            _tcpClientList.Add(client);
            _clientCount += 1;
            _cnnctdClientsTextbox.InvokeExecute(cctb => cctb.Text = _clientCount.ToString());


            string input = string.Empty;

            try
            {
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                while (client.Connected)
                {
                    input = sr.ReadLine(); // block until it receives something from the client

                    // something comes from client

                    switch (input)
                    {
                        // implement commands here
                        case ("GetTeachers"):
                            {
                                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "From client: " + client.GetHashCode() + ": " + input); // gets unique hash code (id) of client
                                SerializeTeachers(client.GetStream());
                                client.GetStream().Flush();
                                sw.WriteLine("Server received: " + input);

                                break;
                            }


                        default:
                            {
                                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "From client: " + client.GetHashCode() + ": " + input); // gets unique hash code (id) of client
                                sw.WriteLine("Server received: " + input);
                                sw.Flush();

                                break;
                            }
                    }
                }
            }
            catch (SocketException se)
            {
                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Problem processing client request.");
                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + se.ToString());

            }
            catch (Exception ex)
            {
                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Problem processing client request.");
                _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + ex.ToString());
            }

            _tcpClientList.Remove(client);
            _clientCount -= 1;
            _cnnctdClientsTextbox.InvokeExecute(cctb => cctb.Text = _clientCount.ToString());
            _statusTextBox.InvokeExecute(stb => stb.Text += CRLF + "Finished processing client requests for client:" + client.GetHashCode());
        }

        #endregion

        private async void SerializeTeachers(NetworkStream stream)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(stream, await _mediator.Send(new GetPersonListQuery()));
            }
            catch (Exception ex)
            {

            }
        }


        //private async Task<List<TeacherModel>> GetTeacherList()
        //{
        //    return await _mediator.Send(new GetPersonListQuery());
        //}



    }
}