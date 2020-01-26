using System;

namespace SupportTroubleshootingTool.Core.Contracts
{

    interface ISession
    {
        SessionInfo CurrentSession();
        void StartSession(SessionInfo session);
        void StopSession(SessionInfo session);
        void CollectData(SessionInfo session);

    }
    class SessionInfo : ISession
    {

        SessionInfo ISession.CurrentSession()
        {
            SessionInfo a =new SessionInfo();
            return a;
        }
        void ISession.StartSession(SessionInfo session)
        {

        }
        void ISession.StopSession(SessionInfo session)
        {

        }
        void ISession.CollectData(SessionInfo session)
        {

        }


    }


}
