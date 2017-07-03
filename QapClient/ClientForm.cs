using AwesomeSockets.Domain.Sockets;
using AwesomeSockets.Sockets;
using QapShared;
using System.Windows.Forms;

namespace QapClient
{
    public partial class ClientForm : Form
    {
        private ISocket _serverSocket;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (_serverSocket != null)
                _serverSocket.Close();
            _serverSocket = AweSock.TcpConnect("127.0.0.1", Helper.DefaultServerPort);
        }
    }
}
