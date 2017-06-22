using NLog;
using System.Windows.Forms;

namespace qQapTray
{
    public partial class TrayForm : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public TrayForm()
        {
            InitializeComponent();
            _logger.Debug("Tray form initialization");
        }
    }
}
