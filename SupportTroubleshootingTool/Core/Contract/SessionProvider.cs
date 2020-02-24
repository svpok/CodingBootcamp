using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using SupportTroubleshootingTool.Core.Handlers;
using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class SessionProvider : ISession
    {
        private SessionInfo _currentSession;
        public SessionProvider()
        {
            var path = ConfigurationManager.AppSettings["SessionRootFolderPath"];
            if (!Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(path);
                }catch(Exception ex)
                {
                    throw new Exception($"0:{ex.Message}");
                }
            }
            SessionRootFolderPath = path;
        }
        public string SessionRootFolderPath
        {
            get;
            private set;
        }
        public SessionInfo CurrentSession
        {
            get
            {
                if (_currentSession != null)
                {
                    return _currentSession;
                }
                string[] s = Directory.GetDirectories(SessionRootFolderPath, "*open", SearchOption.AllDirectories);
                //Search in this.SessionRootFolderPath the session folder that is opened. - done
                //yyyy-MM-dd-hh-mm_workflowName_open - open session
                //yyyy-MM-dd-hh-mm_workflowName_close - closed session
                //if such folder exists create SessionInfo object from the SessionInfo.xml and return it. - done
                //Otherwise return null; - done
                if (s.Length == 1)
                {
                    _currentSession = SerialtionHelper<SessionInfo>.Deserialize(s[0] + "\\SessionInfo.xml");
                    return _currentSession;
                }
                if (s.Length > 1)
                {
                    new  Logger().WriteWarning("two Session or more is open.");
                    throw new Exception("two Session or more is open.");
                }
                return null;
            }
        }
        public void StartSession(SessionInfo session)
        {
            try
            {
                _currentSession = session;
                _currentSession.SessionOtputFolderPath = Path.Combine(SessionRootFolderPath,
                                                        $"{_currentSession.SessionFolderPath}_open");
                System.IO.Directory.CreateDirectory($@"{_currentSession.SessionOtputFolderPath}");
                SerialtionHelper<SessionInfo>.Serialize(_currentSession,
                    $@"{_currentSession.SessionOtputFolderPath}\SessionInfo.xml");
                //session.Save();
                //Build session folder name yyyy-MM-dd-hh-mm_workflowName_open -done
                //Create the folder under this.SessionRootFolderPath - done
                //Save SessionInfo.xml - done
                //Crete backup (BackupHandler) - done
                new BackUpManager(_currentSession).Backup();
                //Open log levels (XmlHandler) - done
                //Open traces (XmlHanlder) - done
                new XmlHandler(_currentSession).ChangeConfig();
                //Restart processes (ProcessHandler) - done
                //new ProcessHandler(_currentSession).RestartService();
            }
            catch(Exception ex)
            {
                new  Logger().WriteError(ex);
                throw new Exception($"1:{ex.Message}");
            }
        }
        public void StopSession(bool cls=true)
        {
            try
            {
                if (cls)
                {


                    if (_currentSession == null)
                    {
                        throw new Exception("There no session to close.");
                    }
                    //Resore from backup (BackupHandler)
                    new BackUpManager(_currentSession).Restore();
                    //Restart processes (ProcessHandler)
                    //new ProcessHandler(_currentSession);
                    //Rename session folder from open to close - done
                    System.IO.Directory.Move($"{SessionRootFolderPath}\\{_currentSession.SessionFolderPath}_open",
                    $"{SessionRootFolderPath}\\{_currentSession.SessionFolderPath}_close");
                }


            }
            catch (Exception ex)
            {
                new  Logger().WriteError(ex);
                throw new Exception($"2:{ex.Message}");
            }
        }
        public bool CollectData()
        {
            try
            {
                string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
                string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
                string path = Path.Combine(_currentSession.SessionOtputFolderPath,
                                            "OutputData",
                                            $@"{from}_{to}");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    //Create Output folder for this collect operation
                    //Collect Log events (EVLogHandler)
                    //new EVLogHandler(_currentSession).CollectData();
                    //Collect file logs (FileLogHandler)
                    //Collect traces (TraceHanler)
                    //new FilesHandler(_currentSession).CollectData();
                    //new PackageHandler(_currentSession).Packaging();
                    SerialtionHelper<SessionInfo>.Serialize(_currentSession,
                    $@"{_currentSession.SessionOtputFolderPath}\SessionInfo.xml");
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Logger().WriteError(ex);
                throw new Exception($"3:{ex.Message}") ;
            }
            return true;
        }
    }
}
