using NLog;
using NLog.LayoutRenderers;
using System.Diagnostics;

namespace Qap
{
    [LayoutRenderer("process_start_time")]
    public class ProcessStartTimeLayoutRenderer : DateLayoutRenderer
    {
        private Process _process;

        protected override void InitializeLayoutRenderer()
        {
            base.InitializeLayoutRenderer();
            this._process = Process.GetCurrentProcess();
        }

        protected override void CloseLayoutRenderer()
        {
            if (this._process != null)
            {
                this._process.Close();
                this._process = null;
            }

            base.CloseLayoutRenderer();
        }

        protected override void Append(System.Text.StringBuilder builder, LogEventInfo logEvent)
        {
            if (this._process != null)
            {
                builder.Append(this._process.StartTime.ToString(this.Format, this.Culture));
            }
        }
    }
}
