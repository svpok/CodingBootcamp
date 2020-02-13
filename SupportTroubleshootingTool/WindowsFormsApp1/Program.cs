using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Handlers;
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
            var sessionInfo = sessionProvider.CurrentSession;
            if (sessionInfo == null)
            {
                new NewSessionFormUi(sessionProvider).ShowDialog();
            }
            else
            {
                new ExistingSessionFormUi(sessionProvider, null).ShowDialog();
            }

            //SupportTroubleshootingTool.Core.Utilities.Logger.WriteInfo("program exited");
            ConfigXML obj = new ConfigXML(@"C:\Users\Amal Saleh\Desktop\CodingBootcamp\XML.xml");
            obj.Change(@"//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']/@currency", "$$$$");
            obj.Save();
        }
    }
}
