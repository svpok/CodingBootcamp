using System;
using System.Collections.Generic;
using System.Text;
using SupportTroubleshootingTool.Core.Model;

namespace SupportTroubleshootingTool.Core.Contract
{
    public interface ISession
    {
        string SessionRootFolderPath { get; }
        SessionInfo GetCurrentSession();
        void StartSession(SessionInfo session);
        void StopSession(SessionInfo session);
        void CollectData(SessionInfo session);
    }
    
}
