using AwesomeSockets.Domain;
using AwesomeSockets.Domain.Sockets;
using AwesomeSockets.Sockets;
using NLog;
using QapShared;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace QapServer
{
    public partial class ServerForm : Form
    {
        private ISocket _listenSocket;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ServerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portTextBox.Text = Helper.DefaultServerPort.ToString();
            StartServer(int.Parse(portTextBox.Text));
        }

        private void StartServer(int serverPort)
        {
            if (_listenSocket != null)
            {
                _listenSocket.Close();
                _listenSocket = null;
            }
            _listenSocket = AweSock.TcpListen(serverPort);
            //Non-blocking mode
            AweSock.TcpAccept(_listenSocket, SocketCommunicationTypes.NonBlocking, AcceptClient);
            _logger.Info($"Listening on port: {serverPort}");
        }

        Socket AcceptClient(ISocket iSocket, Exception exception)
        {
            _logger.Debug($"Client connection Socket: {iSocket} Error: {exception}");
            if (exception != null)
                return null;

            return iSocket.GetSocket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartServer(int.Parse(portTextBox.Text));
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_listenSocket != null)
            {
                _listenSocket.Close();
                _listenSocket = null;
            }

        }
    }
}
