using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core
{
    public interface ISession
    {
            
        string SeesionRootFolderPath();
        SessionInfo CurrentSession();
        void StartSession(SessionInfo session);
        void StopSession(SessionInfo session);
        void CollectData(SessionInfo session);

    
    }
}
