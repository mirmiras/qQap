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
            _listenSocket = AweSock.TcpListen(Helper.DefaultServerPort);
            //Non-blocking mode
            AweSock.TcpAccept(_listenSocket, SocketCommunicationTypes.NonBlocking, AcceptClient);
            _logger.Info($"Listening on port: {Helper.DefaultServerPort}");
        }

        Socket AcceptClient(ISocket iSocket, Exception exception)
        {
            _logger.Debug($"Client connection Socket: {iSocket} Error: {exception}");
            if (exception != null)
                return null;

            return iSocket.GetSocket();
        }
    }
}
