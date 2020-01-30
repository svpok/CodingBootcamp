using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using System;
using System.IO;

using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class SessionProvider : ISession
    {
        string path;
        public SessionProvider()
        {
            path = ConfigurationManager.AppSettings["SessionRootFolderPath"];
        }

        public SessionInfo CurrentSession()
        {

            //Search in this.SessionRootFolderPath the session folder that is opened.
            //yyyy-MM-dd-hh-mm_workflowName_open - open session
            //yyyy-MM-dd-hh-mm_workflowName_close - closed session
            //if such folder exists create SessionInfo object from the SessionInfo.xml and return it.
            //Otherwise return null;
            return null;
        }

        public string SessionRootFolderPath()
        {
            //check if folder does not exist and create it 
            if (!Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }

        public void StartSession(SessionInfo session)
        {
            try
            {
                System.IO.Directory.CreateDirectory($"{session.SessionOtputFolderPath}\\{DateTime.Now.ToString("yyyy-MM-dd-hh-mm")}_{session.SessionID}_open");
                //Build session folder name yyyy-MM-dd-hh-mm_workflowName_open
                //Create the folder under this.SessionRootFolderPath
                //Save SessionInfo.xml
                //Crete backup (BackupHandler)
                //Open log levels (XmlHandler)
                //Open traces (XmlHanlder)
                //Restart processes (ProcessHandler)

            }
            catch(Exception ex)
            {
                Logger.WriteError(ex);
                throw new Exception($"Failed to start session: {ex.Message}");
            }

        }

        public void StopSession(SessionInfo session)
        {
            //Rename session folder from open to close
            //Restore from backups
            try
            {
                if (!Directory.Exists(path))
                {
                    //Rename session folder from open to close
                    //Resore from backup (BackupHandler)

                    //Restart processes (ProcessHandler)
                }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                throw new Exception($"Failed to stop session: {ex.Message}");
            }
        }

        public void CollectData(SessionInfo session)
        {
            try
            {
                //Create Output folder for this collect operation
                //Collect Log events (EVLogHandler)
                //Collect file logs (FileLogHandler)
                //Collect traces (TraceHanler)

            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                throw new Exception($"Failed to collect data for session");
            }
        }
    }
}
