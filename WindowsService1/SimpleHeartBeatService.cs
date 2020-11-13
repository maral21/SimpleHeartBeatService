using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using SimpleHeartbeatService;

namespace SimpleHeartBeatService
{
    [RunInstaller(true)]
    public partial class SimpleHeartBeatService : ServiceBase
    {
        private HeartBeat heartbeatservice;
        public SimpleHeartBeatService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.heartbeatservice.Start();
        }

        protected override void OnStop()
        {
            this.heartbeatservice.Stop();
        }
    }
}
