using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            SessionInfo sessionInfo = new SessionInfo();
           //sessionInfo = sessionInfo.Load("");
           //sessionInfo.SessionOtputFolderPath = @"C:\SupportTroubleshootingTool\Session";
           SessionProvider sessionProvider = new SessionProvider();

            //WorkflowProvider workflowProvider = new WorkflowProvider();
            //sessionProvider.StartSession(sessionInfo);
            //sessionProvider.StopSession(sessionInfo);
            //sessionInfo = sessionProvider.CurrentSession();

           // sessionProvider.StartSession(sessionInfo);
            //sessionProvider.StopSession(sessionInfo);

            //sessionInfo = sessionProvider.GetCurrentSession();
            //sessionProvider.StopSession(sessionInfo);

        }
    }
}
