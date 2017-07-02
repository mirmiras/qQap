using QapShared;

namespace QapTray
{
    class QapSettings : AppSettings<QapSettings>
    {
        const int MaxScreenShotsNumber = 10000;

        public bool MinimizeToTray { get; set; }
        public bool StartMinimized { get; set; }
        public int FullScreenSaveCounter { get; set; }
        public int WindowSaveCounter { get; set; }
        public int CapturePeriod { get; set; }
        public bool CaptureActiveWindow { get; set; }

        public QapSettings()
        {
            CapturePeriod = 10;
            FullScreenSaveCounter = -1;
            CapturePeriod = -1;
        }

        public int IncrementFullScreenSaveCounter()
        {
            FullScreenSaveCounter = GetNextNumber(FullScreenSaveCounter);
            return FullScreenSaveCounter;
        }

        public int IncrementWindowSaveCounter()
        {
            WindowSaveCounter = GetNextNumber(WindowSaveCounter);
            return WindowSaveCounter;
        }

        private int GetNextNumber(int counter)
        {
            if (++counter > MaxScreenShotsNumber)
                counter = 0;
            return counter;
        }

    }
}
