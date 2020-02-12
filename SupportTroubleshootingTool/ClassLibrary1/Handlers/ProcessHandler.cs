using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Handlers
{
    class ProcessHandler  
    {

        public static void RestartService(string serviceName, int timeoutMilliseconds)  // Will handle services that running in server 
        {
            ServiceController service = new ServiceController(serviceName);
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
                Utilities.Logger.WriteError(e);
            }
        }

        internal static void RestartService(SessionInfo session)
        {
            
        }
    }
}
