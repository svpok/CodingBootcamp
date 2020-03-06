using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;

namespace SupportTroubleshootingTool.Core.Contract
{
    internal class FilesHandler
    {
        private SessionInfo _currentSession;
        public FilesHandler(SessionInfo currentSession)
        {
            _currentSession = currentSession;
        }
        internal void CollectData(string outputfolder, string sourcefolder, string filter)
        {
            try
            {
                if (!Directory.Exists(sourcefolder))
                {
                    new Utilities.Logger().WriteError("Logs Source Folder Not Found");
                    return;
                }
                DateTime from = _currentSession.From;
                DateTime to = _currentSession.To;
                string[] filePaths = Directory.GetFiles(sourcefolder, filter);
                foreach (string filepath in filePaths)
                {
                    var fileinfo = new FileInfo(filepath);
                    if ((DateTime.Compare(fileinfo.LastWriteTime, from) >= 0) && (DateTime.Compare(fileinfo.LastWriteTime, to) <= 0))
                    {
                        if (!Directory.Exists(outputfolder))
                        {
                            Directory.CreateDirectory(outputfolder);
                        }
                        fileinfo.CopyTo($"{outputfolder}/{fileinfo.Name}");
                        new Utilities.Logger().WriteInfo($"File {fileinfo.Name} copied to folder {outputfolder} ");
                    }
                }
            }catch(Exception ex)
            {
                new Utilities.Logger().WriteError(ex);
                throw new NonCriticalException($"Failed to Copy Files {ex.Message}");
            }

        }
        internal void CollectData()
        {
            try
            {
                List<TraceInfo> traces = _currentSession.SelectedTraces;
                List<FileLogInfo> fileLogInfos = _currentSession.SelectedFileLogs;
                string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
                string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
                foreach (TraceInfo trace in traces)
                {
                    string outputfolder = $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}\{trace.Description}";
                    CollectData(outputfolder, trace.TracesPath, trace.TraceFileName);
                }
                foreach (FileLogInfo fileLogInfo in fileLogInfos)
                {
                    string outputfolder = $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}\{fileLogInfo.Description}";
                    CollectData(outputfolder, fileLogInfo.LogsPath, fileLogInfo.LogFileName);
                }
                new Logger().WriteInfo("Collecting trace files and log files seccessfully.");
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"faild to Collect trace files and log files:{ex.Message}");
                throw new NonCriticalException($"Failed to Copy Files {ex.Message}");
            }
        }
    }
}