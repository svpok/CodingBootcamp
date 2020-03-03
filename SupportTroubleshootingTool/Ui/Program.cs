using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Utilities;
namespace SupportTroubleshootingTool.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            new Logger().WriteInfo($"UserName: {Environment.UserName} {Environment.UserDomainName} login.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            var sessionProvider = new SessionProvider();
            var sessionInfo = sessionProvider.CurrentSession;
            if (sessionInfo == null)
            {
                try
                {
                    new NewSessionFormUi(sessionProvider).ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    new ExistingSessionFormUi(sessionProvider, null).ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            new Logger().WriteInfo($"UserName: {Environment.UserName} {Environment.UserDomainName} logout.");
            new Logger().WriteInfo("program exited");
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}