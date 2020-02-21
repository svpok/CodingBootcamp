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
            List<TraceInfo> traceInfos = session.SelectedTraces;
            List<EVLogInfo> evLogInfos = session.SelectedEVLogs;
            List<FileLogInfo> fileLogInfos = session.SelectedFileLogs;
            if (traceInfos != null)
            {
                foreach (TraceInfo trace in traceInfos)
                {
                    string iisapplicationpooltorestart = trace.IISApplicationPoolToRestart;
                    List<string> servicestorestart = trace.ServicesToRestart;
                    if (iisapplicationpooltorestart != null) { RestartPool(iisapplicationpooltorestart); }
                    if (servicestorestart != null)
                    {
                        foreach (string servicename in servicestorestart) { RestartService(servicename); }
                    }
                }
            }
            else { new Utilities.Logger().WriteInfo("No Traces Found you Waste my Time"); }
            if (evLogInfos != null)
            {
                foreach (EVLogInfo evLogInfo in evLogInfos)
                {
                    List<string> servicestorestart = evLogInfo.ServicesToRestart;
                    if (servicestorestart != null)
                    {
                        foreach (string servicename in servicestorestart) { RestartService(servicename); }
                    }
                }
            }
            else { new Utilities.Logger().WriteInfo("No EVlog Found you Waste my Time"); }
            if (fileLogInfos != null)
            {
                foreach (FileLogInfo fileLogInfo in fileLogInfos)
                {
                    List<string> servicestorestart = fileLogInfo.ServicesToRestart;
                    if (servicestorestart != null)
                    {
                        foreach (string servicename in servicestorestart) { RestartService(servicename); }
                    }
                }
            }
            else { new Utilities.Logger().WriteInfo("No FileLog Found you Waste my Time"); }

        }

            internal void RestartService(string serviceName)  // Will handle services that running in server 
        {
            ServiceController service = new ServiceController(serviceName);
            int timeoutMilliseconds = 1000;
            try
            {
                // to handle Process we must use timeout time to be sure that the process stopped then we can start it
                //else we get exception
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception e)
            {
             new Utilities.Logger().WriteError(e);
            }
        }

        
        internal void RestartPool(string appname)
        {
            ServerManager server = new ServerManager();
            ApplicationPool application = server.ApplicationPools[appname];
            try
            {
                application.Recycle();
            }
            catch (Exception e)
            {
                new Utilities.Logger().WriteError(e);

            }
                }
            }  
        }