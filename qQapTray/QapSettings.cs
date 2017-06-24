namespace qQapTray
{
    class QapSettings : AppSettings<QapSettings>
    {
        public bool MinimizeToTray { get; set; }
        public bool StartMinimized { get; set; }
    }
}
