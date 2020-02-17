using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace SupportTroubleshootingTool.Core.Handlers
{
    class ProcessHandler  
    {
        private SessionInfo session;

        public ProcessHandler(SessionInfo session)
        {
            this.session = session;
        }

        internal void RestartService()  // Will handle services that running in server 
        {
            ServiceController service = new ServiceController(session.WorkflowName);
            int timeoutMilliseconds = 1000;
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception e)
            {
             new Utilities.Logger().WriteError(e);
            }
        }

        
        internal void RestartPool()
        {
            ServerManager server = new ServerManager();
            ApplicationPool application = server.ApplicationPools[session.WorkflowName];
            var state = application.State;
            try { application.Stop(); }
            catch (Exception e){
                new SupportTroubleshootingTool.Core.Utilities.Logger().WriteError(e);

            }
        }
    }
}
