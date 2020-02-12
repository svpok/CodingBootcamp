using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
namespace SupportTroubleshootingTool.UI
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
            var sessionProvider = new SessionProvider();
            var sessionInfo = sessionProvider.GetCurrentSession();
            if (sessionInfo == null)
            {
                new NewSessionFormUi(sessionProvider).ShowDialog();
            }
            else
            {
                new ExistingSessionFormUi(sessionProvider, null).ShowDialog();
            }

            //SupportTroubleshootingTool.Core.Utilities.Logger.WriteInfo("program exited");
            //SupportTroubleshootingTool.Core.Handlers.XmlHandler.XmlLoad("", "", "currency", "**");
        }
    }
}
