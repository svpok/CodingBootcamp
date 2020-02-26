using SupportTroubleshootingTool.Core.Model;
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

        internal void CollectData(string outputfolder, string folderPath, string filter)
        {

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    new Utilities.Logger().WriteError("Logs Source Folders Not Found");
                    throw new Exception("Logs Source Folders Not Found");
                }
                DateTime from = _currentSession.From;
                DateTime to = _currentSession.To;
                string[] filePaths = Directory.GetFiles(folderPath, filter);
                foreach (string filepath in filePaths)
                {
                    var fileinfo = new FileInfo(filepath);
                    if ((DateTime.Compare(fileinfo.LastWriteTime, from) > 0) && (DateTime.Compare(fileinfo.LastWriteTime, to)<0))
                    {
                        fileinfo.CopyTo(outputfolder+"/"+fileinfo.Name);
                    }
                }
            }
            catch(Exception e)
            {
                new Utilities.Logger().WriteError(e);
                throw;

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
                // Create folder for each trace/filelog by description 
                // create list of files paths to be collected for each filelog/trace
                // copy files to folder
                foreach (TraceInfo trace in traces)
                {
                    string outputfolder = $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}\FileLogs\{trace.Description}";
                    if (!Directory.Exists(outputfolder))
                    {
                        Directory.CreateDirectory(outputfolder);
                    }
                    CollectData(outputfolder, trace.TracesPath, trace.TraceFileName);
                }
                foreach (FileLogInfo fileLogInfo in fileLogInfos)
                {
                    string outputfolder = $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}\FileLogs\{fileLogInfo.Description}";
                    if (!Directory.Exists(outputfolder))
                    {
                        Directory.CreateDirectory(outputfolder);
                    }
                    CollectData(outputfolder, fileLogInfo.LogsPath, fileLogInfo.LogFileName);
                }
            }
            catch(Exception e) { 
                new Utilities.Logger().WriteError(e);
                throw;
            }
        }
    }
}