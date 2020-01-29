using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class SessionProvider : ISession
    {
        public void CollectData(SessionInfo session)
        {
           
        }

        public SessionInfo CurrentSession()
        {
            return new SessionInfo();
        }

        public string SeesionRootFolderPath()
        {
            return "";
        }

        public void StartSession(SessionInfo session)
        {
            
        }

        public void StopSession(SessionInfo session)
        {
            
        }
    }
}
