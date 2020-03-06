using SupportTroubleshootingTool.Core.Handlers;
using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using System;
using System.Configuration;
using System.IO;
namespace SupportTroubleshootingTool.Core.Contract
{
    public class SessionProvider
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
                    new Logger().WriteInfo($"Success to creat directry:{path}");
                }catch(Exception ex)
                {
                    new Logger().WriteError($"File create error:{ex.Message}");
                    throw new Exception($"File create error:{ex.Message}");
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
                try
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
                        new Logger().WriteInfo("Return full currentSession.");
                        return _currentSession;
                    }
                    if (s.Length > 1)
                    {
                        throw new Exception("two Session or more is open.");
                    }
                    new Logger().WriteInfo("Return NULL currentSession.");
                    return null;
                }
                catch (Exception ex)
                {
                    new Logger().WriteError($"Faild to return CurrentSession:{ex.Message}");
                    throw new Exception($"Faild to return CurrentSession:{ex.Message}");
                }

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
                new ProcessHandler(_currentSession).RestartService();
                new Logger().WriteInfo("Starting new successfully.");
            }
            // catch non critic exeption
            catch(NonCriticalException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"Faild to start session:{ex.Message}");
                throw new Exception($"Faild to start session:{ ex.Message}");
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
                    new ProcessHandler(_currentSession);
                    //Rename session folder from open to close - done
                    System.IO.Directory.Move($"{SessionRootFolderPath}\\{_currentSession.SessionFolderPath}_open",
                    $"{SessionRootFolderPath}\\{_currentSession.SessionFolderPath}_close");
                }
                new Logger().WriteInfo("Closing session successfully.");

            }
            catch (Exception ex)
            {
                new  Logger().WriteError($"faild to close session:{ex.Message}");
                throw new Exception($"faild to close session:{ex.Message}");
            }
        }
        public bool CollectData(bool flag = false)
        {
            try
            {
                string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
                string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
                string path = Path.Combine(_currentSession.SessionOtputFolderPath,
                                            "OutputData",
                                            $@"{from}_{to}");
                string zipFile = Path.Combine(_currentSession.SessionOtputFolderPath,
                                            "OutputData",
                                            $@"{_currentSession.WorkflowName}_{from}_{to}.zip");

                if (!Directory.Exists(path) || flag)
                {
                    if (flag)
                    {
                        File.Delete(zipFile);
                        Directory.Delete(path, true);
                    }
                    Directory.CreateDirectory(path);
                    //Create Output folder for this collect operation
                    //Collect Log events (EVLogHandler)
                    //new EVLogHandler(_currentSession).CollectData();
                    //Collect file logs (FileLogHandler)
                    //Collect traces (TraceHanler)
                    new FilesHandler(_currentSession).CollectData();
                    string name = new DirectoryInfo(path).Name;
                    if (!_currentSession.OutputDirNames.Contains(name))
                    {
                        _currentSession.OutputDirNames.Add(name);
                    }
                     new PackageHandler(_currentSession).Packaging();        
                    SerialtionHelper<SessionInfo>.Serialize(_currentSession,
                    $@"{_currentSession.SessionOtputFolderPath}\SessionInfo.xml");
                }
                else
                {
                    return false;
                }
                new Logger().WriteInfo("Collect data successfully.");
                return true;
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"Faild to Collect data:{ex.Message}");
                throw new Exception($"Faild to Collect data:{ex.Message}");
            }
            
        }
    }
}
