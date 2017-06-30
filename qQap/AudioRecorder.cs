using CSCore;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using NLog;
using System.Linq;

namespace Qap
{
    enum CaptureMode
    {
        Capture = 1,
        // ReSharper disable once UnusedMember.Local
        LoopbackCapture = 2
    }

    public class AudioRecorder
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        CaptureMode _captureMode = CaptureMode.LoopbackCapture;
        private WasapiCapture _soundIn;
        private MMDevice _device;
        int sampleRate = 48000;
        int bitsPerSample = 16;
        int channels = 2;
        private WaveWriter _waveWriter;
        private IWaveSource _convertedSource;

        public AudioRecorder()
        {
            InitializeRecording();
        }

        private void OnDatAvailable(object sender, DataAvailableEventArgs e)
        {
            //register an event handler for the DataAvailable event of 
            //the soundInSource
            //Important: use the DataAvailable of the SoundInSource
            //If you use the DataAvailable event of the ISoundIn itself
            //the data recorded by that event might won't be available at the
            //soundInSource yet

            _logger.Debug($"Audio data available - Bytes: {e.ByteCount} Format: {e.Format}");
            //read data from the converedSource
            //important: don't use the e.Data here
            //the e.Data contains the raw data provided by the 
            //soundInSource which won't have your target format
            byte[] buffer = new byte[_convertedSource.WaveFormat.BytesPerSecond / 2];
            int read;

            //keep reading as long as we still get some data
            //if you're using such a loop, make sure that soundInSource.FillWithZeros is set to false
            while ((read = _convertedSource.Read(buffer, 0, buffer.Length)) > 0)
            {
                //write the read data to a file
                // ReSharper disable once AccessToDisposedClosure
                _waveWriter.Write(buffer, 0, read);
            }
        }

        public void Start()
        {
            if (_device == null || (_soundIn != null && _soundIn.RecordingState == RecordingState.Recording))
                return;
            //create a new soundIn instance
            _soundIn = _captureMode == CaptureMode.Capture ? new WasapiCapture() : new WasapiLoopbackCapture();
            //optional: set some properties 
            _soundIn.Device = _device;

            //initialize the soundIn instance
            _soundIn.Initialize();

            //create a SoundSource around the the soundIn instance
            //this SoundSource will provide data, captured by the soundIn instance
            SoundInSource soundInSource = new SoundInSource(_soundIn) { FillWithZeros = false };

            //create a source, that converts the data provided by the
            //soundInSource to any other format
            //in this case the "Fluent"-extension methods are being used
            _convertedSource = soundInSource
                .ChangeSampleRate(sampleRate) // sample rate
                .ToSampleSource()
                .ToWaveSource(bitsPerSample); //bits per sample

            //channels...
            _convertedSource = channels == 1 ? _convertedSource.ToMono() : _convertedSource.ToStereo();
            _waveWriter = new WaveWriter("out.wav", _convertedSource.WaveFormat);

            soundInSource.DataAvailable += OnDatAvailable;
            _soundIn.Start();
        }

        public void Stop()
        {
            if (_soundIn.RecordingState == RecordingState.Stopped)
                return;
            _soundIn.Stop();
            _waveWriter.Dispose();
            _waveWriter = null;
        }

        public void InitializeRecording()
        {
            DataFlow dataFlow = _captureMode == CaptureMode.Capture ? DataFlow.Capture : DataFlow.Render;
            var devices = MMDeviceEnumerator.EnumerateDevices(dataFlow, DeviceState.Active);
            if (!devices.Any())
            {
                _logger.Error("No devices found.");
                return;
            }

            _logger.Info("Select device:");
            for (int i = 0; i < devices.Count; i++)
            {
                _logger.Info("- {0:#00}: {1}", i, devices[i].FriendlyName);
            }
            int selectedDeviceIndex = 0;
            _device = devices[selectedDeviceIndex];
        }
    }
}
