using NLog;
using qQap;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace qQapTray
{
    public partial class TrayForm : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private int _cntFull;
        private int _cntWindow;
        private QapSettings _qapSettings;

        public TrayForm()
        {
            InitializeComponent();
            _logger.Debug("Tray form initialization");
        }

        private void captureButton_Click(object sender, System.EventArgs e)
        {
            Image image = ScreenCapture.CaptureDesktop();
            if (image != null)
            {
                var captureFileName = GetCaptureFileName(_cntFull++);
                _logger.Debug($"Saving full screen into: {captureFileName}");
                image.Save(captureFileName, ImageFormat.Png);
            }
            Bitmap bmp = ScreenCapture.CaptureActiveWindow();
            if (bmp != null)
            {
                var captureFileName = GetCaptureFileName(_cntWindow++);
                _logger.Debug($"Saving active window into: {captureFileName}");
                bmp.Save(captureFileName, ImageFormat.Png);
            }
        }

        private string GetCaptureFileName(int cntWindow)
        {
            return $"testWindow{cntWindow:0000}.png";
        }

        private void TrayForm_Resize(object sender, System.EventArgs e)
        {
            if (!toTrayCheckBox.Checked) return;
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(5);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;

        }

        private void TrayForm_Load(object sender, System.EventArgs e)
        {
            _qapSettings = QapSettings.Load();
            toTrayCheckBox.Checked = _qapSettings.MinimizeToTray;
            startMinimizedCheckBox.Checked = _qapSettings.StartMinimized;
            if (startMinimizedCheckBox.Checked)
                WindowState = FormWindowState.Minimized;
        }

        private void TrayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _qapSettings.MinimizeToTray = toTrayCheckBox.Checked;
            _qapSettings.StartMinimized = startMinimizedCheckBox.Checked;
            QapSettings.Save(_qapSettings);
        }
    }
}
