using NLog;
using Qap;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace QapTray
{
    public partial class TrayForm : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private QapSettings _qapSettings;
        const string FullScreenPrefix = "FullScreen";
        const string WindowPrefix = "Window";

        public TrayForm()
        {
            InitializeComponent();
            _logger.Debug("Tray form initialization");
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
            capturePeriodInSeconds.Value = _qapSettings.CapturePeriod;
            if (startMinimizedCheckBox.Checked)
                WindowState = FormWindowState.Minimized;
        }

        private void TrayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _qapSettings.MinimizeToTray = toTrayCheckBox.Checked;
            _qapSettings.StartMinimized = startMinimizedCheckBox.Checked;
            _qapSettings.CapturePeriod = (int)capturePeriodInSeconds.Value;
            QapSettings.Save(_qapSettings);
        }

        private void captureButton_Click(object sender, System.EventArgs e)
        {
            CaptureFullScreen();
        }

        private void CaptureFullScreen()
        {
            Image image = ScreenCapture.CaptureDesktop();
            if (image != null)
            {
                var captureFileName = GetCaptureFileName(true);
                _logger.Debug($"Saving full screen into: {captureFileName}");
                image.Save(captureFileName, ImageFormat.Png);
            }
        }

        private string GetCaptureFileName(string filePrefix, int cntWindow)
        {
            return $"{filePrefix}{cntWindow:0000}.png";
        }

        private string GetCaptureFileName(bool fullScreen)
        {
            string filePrefix = fullScreen ? FullScreenPrefix : WindowPrefix;
            var counter = fullScreen ? _qapSettings.IncrementFullScreenSaveCounter() : _qapSettings.IncrementWindowSaveCounter();
            return GetCaptureFileName(filePrefix, counter);
        }

        private void activeWindowCaptureButton_Click(object sender, System.EventArgs e)
        {
            CaptureActiveWindow();
        }

        private void CaptureActiveWindow()
        {
            Bitmap bmp = ScreenCapture.CaptureActiveWindow();
            if (bmp != null)
            {
                var captureFileName = GetCaptureFileName(false);
                _logger.Debug($"Saving active window into: {captureFileName}");
                bmp.Save(captureFileName, ImageFormat.Png);
            }
        }

        private void captureCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (captureCheckBox.Checked)
                captureTimer.Interval = (int)capturePeriodInSeconds.Value * 1000;
            captureTimer.Enabled = captureCheckBox.Checked;
        }

        private void captureTimer_Tick(object sender, System.EventArgs e)
        {
            if (captureActiveWindowCheckBox.Checked)
                CaptureActiveWindow();
            else
                CaptureFullScreen();
        }
    }
}
