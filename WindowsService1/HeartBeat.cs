using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleHeartbeatService
{
    public class HeartBeat
    {
        private readonly Timer _timer;

        public HeartBeat()
        {
            _timer = new Timer(1000){AutoReset = true };
            _timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[]{DateTime.Now.ToString()};
            File.AppendAllLines(@"C:\Temp\Demos\Heartbeat.txt",lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

    }
}
