using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SessionInfo sessionInfo;
            sessionInfo = new SessionProvider().GetCurrentSession();
            if (sessionInfo == null)
            {
                Application.Run(new NewSessionFormUi());
            }
            else
            {
                ExistingSessionFormUi.SetMySession(sessionInfo);
                ExistingSessionFormUi window1 = new ExistingSessionFormUi();
                window1.ShowDialog();
            }
            
            //SupportTroubleshootingTool.Core.Utilities.Logger.WriteInfo("program exited");
            //SupportTroubleshootingTool.Core.Handlers.XmlHandler.XmlLoad("", "", "currency", "**");
        }
    }
}
