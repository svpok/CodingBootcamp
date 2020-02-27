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

            //SupportTroubleshootingTool.Core.Utilities.Logger.WriteInfo("program exited");

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}
