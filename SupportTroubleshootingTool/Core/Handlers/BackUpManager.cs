using SupportTroubleshootingTool.Core.Model;
using System.IO;
using SupportTroubleshootingTool.Core.Utilities;
using System;

namespace SupportTroubleshootingTool.Core.Handlers
{
    internal class BackUpManager
    {
        private SessionInfo session;
        private string BackUpFolderPath;
        public BackUpManager(SessionInfo session)
        {
            this.session = session;
            this.BackUpFolderPath = Path.Combine(session.SessionOtputFolderPath, "SessionBackUp");
            if (!Directory.Exists(BackUpFolderPath))
            {
                Directory.CreateDirectory(BackUpFolderPath);
            }
        }

        internal void Backup()
        {
            try
            {
                BackupSteps steps = new BackupSteps();
                for (int i = 0; i < session.SelectedEVLogs.Count; i++)
                {
                    string FilePath = session.SelectedEVLogs[i].ConfigFilePath;
                    string[] split = FilePath.Split(new char[] { '\\' });
                    string FileName = split[split.Length - 1];
                    if (!File.Exists(Path.Combine(this.BackUpFolderPath, FileName)))
                    {
                        steps.FilePath.Add(FilePath);
                        steps.FileName.Add(FileName);
                        File.Copy(session.SelectedEVLogs[i].ConfigFilePath, Path.Combine(this.BackUpFolderPath, FileName));
                    }
                }
                for (int i = 0; i < session.SelectedFileLogs.Count; i++)
                {
                    string FilePath = session.SelectedFileLogs[i].ConfigFilePath;
                    string[] split = FilePath.Split(new char[] { '\\' });
                    string FileName = split[split.Length - 1];
                    if (!File.Exists(Path.Combine(this.BackUpFolderPath, FileName)))
                    {
                        steps.FilePath.Add(FilePath);
                        steps.FileName.Add(FileName);
                        File.Copy(session.SelectedFileLogs[i].ConfigFilePath, Path.Combine(this.BackUpFolderPath, FileName));
                    }

                }
                for (int i = 0; i < session.SelectedTraces.Count; i++)
                {
                    string FilePath = session.SelectedTraces[i].ConfigFilePath;
                    string[] split = FilePath.Split(new char[] { '\\' });
                    string FileName = split[split.Length - 1];
                    if (!File.Exists(Path.Combine(this.BackUpFolderPath, FileName)))
                    {
                        steps.FilePath.Add(FilePath);
                        steps.FileName.Add(FileName);
                        File.Copy(session.SelectedTraces[i].ConfigFilePath, Path.Combine(this.BackUpFolderPath, FileName));
                    }
                }
                SerialtionHelper<BackupSteps>.Serialize(steps, Path.Combine(this.BackUpFolderPath, "backupsteps.xml"));
            }
            catch(Exception ex)
            {
                new Logger().WriteError("Error backup");
                throw new Exception("Error backup");
            }
        }
        internal void Restore()
        {
            try
            {
                string[] FilesName = Directory.GetFiles(this.BackUpFolderPath);
                BackupSteps steps = SerialtionHelper<BackupSteps>.Deserialize(Path.Combine(this.BackUpFolderPath, "backupsteps.xml"));
                for (int i = 0; i < steps.FilePath.Count; i++)
                {
                    File.Delete(steps.FilePath[i]);
                    File.Copy(Path.Combine(this.BackUpFolderPath, steps.FileName[i]), steps.FilePath[i]);
                    //File.Move(Path.Combine(this.BackUpFolderPath, steps.FileName[i]), steps.FilePath[i]);
                }
            }
            catch(Exception ex)
            {
                new Logger().WriteError("Error restore");
                throw new Exception("Error restore");
            }
        }
    }
}