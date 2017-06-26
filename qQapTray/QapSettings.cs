namespace QapTray
{
    class QapSettings : AppSettings<QapSettings>
    {
        public bool MinimizeToTray { get; set; }
        public bool StartMinimized { get; set; }
        public int WindowSaveCounter { get; set; }
        public int FullScreenSaveCounter { get; set; }
        public int CapturePeriod { get; set; }

        public QapSettings()
        {
            CapturePeriod = 10;
        }
    }
}
