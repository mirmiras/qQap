using CSCore;
using CSCore.SoundIn;
using NLog;

namespace Qap
{
    public class AudioRecorder
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private WasapiLoopbackCapture _loopbackCaputre;

        public AudioRecorder()
        {
            InitAudioRecording();
        }

        public void InitAudioRecording()
        {
            _loopbackCaputre = new CSCore.SoundIn.WasapiLoopbackCapture(10, new WaveFormat());
            _loopbackCaputre.DataAvailable += OnDatAvailable;
            _loopbackCaputre.Initialize();
        }

        private void OnDatAvailable(object sender, DataAvailableEventArgs e)
        {
            _logger.Debug($"Audio data available - Bytes: {e.ByteCount} Format: {e.Format}");
        }

        public void Start()
        {

            _loopbackCaputre.Start();
        }

        public void Stop()
        {
            _loopbackCaputre.Stop();
        }
    }
}
