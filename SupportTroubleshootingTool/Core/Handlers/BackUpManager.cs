using SupportTroubleshootingTool.Core.Model;
using System.IO;
using SupportTroubleshootingTool.Core.Utilities;
using System;
using System.Collections.Generic;

namespace SupportTroubleshootingTool.Core.Handlers
{
    internal class BackUpManager
    {
        private readonly SessionInfo _session;
        private readonly string _backUpFolderPath;
        private readonly string _xmlRestoreSteps;
        public BackUpManager(SessionInfo session)
        {
            _session = session;
            _backUpFolderPath = Path.Combine(session.SessionOtputFolderPath, "SessionBackUp");
            _xmlRestoreSteps = Path.Combine(_backUpFolderPath, "backupsteps.xml");
        }

        internal void Backup()
        {
            try
            {
                if (!Directory.Exists(_backUpFolderPath))
                {
                    Directory.CreateDirectory(_backUpFolderPath);
                }
                BackupSteps steps = new BackupSteps();
                if (_session.LogLevel != LogLevelEnum.Current)
                {
                    BackupConfigFiles(steps, new List<ConfigItemInfo>(_session.SelectedEVLogs));
                    BackupConfigFiles(steps, new List<ConfigItemInfo>(_session.SelectedFileLogs));
                }
                BackupConfigFiles(steps, new List<ConfigItemInfo>(_session.SelectedTraces));
                SerialtionHelper<BackupSteps>.Serialize(steps, _xmlRestoreSteps);
                new Logger().WriteInfo("Backup Seccessfully.");
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"Faild to backup:{ex.Message}");
                throw new Exception($"Faild to backup:{ex.Message}");
            }
        }

        internal void Restore()
        {
            try
            {
                string[] FilesName = Directory.GetFiles(this._backUpFolderPath);
                BackupSteps steps = SerialtionHelper<BackupSteps>.Deserialize(_xmlRestoreSteps);
                for(int i =0; i<steps.FilePath.Count;i++)
                {
                    File.Copy(Path.Combine(this._backUpFolderPath,steps.FileName[i]), steps.FilePath[i],true);
                }
                new Logger().WriteInfo("Restore files seccessfully.");
            }
            catch(Exception ex)
            {
                new Logger().WriteError($"faild to restore:{ex.Message}");
                throw new Exception($"faild to restore:{ex.Message}");
            }
        }

        private void BackupConfigFiles(BackupSteps steps, List<ConfigItemInfo> configsList)
        {
            foreach (var configFileInfo in configsList)
            {
                var orgFileInfo = new FileInfo(configFileInfo.ConfigFilePath);
                var destFileInfo = Path.Combine(this._backUpFolderPath, orgFileInfo.Name);
                if (!File.Exists(destFileInfo))
                {
                    steps.FilePath.Add(orgFileInfo.FullName);
                    steps.FileName.Add(orgFileInfo.Name);
                    File.Copy(orgFileInfo.FullName, destFileInfo);
                }
            }
        }
    }
}