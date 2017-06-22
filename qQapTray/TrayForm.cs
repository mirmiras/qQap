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
    }
}
