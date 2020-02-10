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
    public partial class ExistingSessionFormUi : Form
    {
        static SessionInfo mysession = new SessionInfo();

        public static void SetMySession(SessionInfo session)
        {

            mysession = session;

        }
        public ExistingSessionFormUi()
        {
            InitializeComponent();
        }

        private void ExistingSessionFormUi_Load(object sender, EventArgs e)
        {
            this.loadData.Items.Add("workflow:" + mysession.WorkflowName);
            this.loadData.Items.Add("Date and Time:    From" + mysession.From.ToUniversalTime());
            this.loadData.Items.Add("\n To:" + mysession.To.ToUniversalTime());

            foreach (EVLogInfo EVlog in mysession.SelectedEVLogs)
                this.loadData.Items.Add("Event View Logs:\n" + EVlog.LogName);


            foreach (FileLogInfo fileLog in mysession.SelectedFileLogs)
            {
                this.loadData.Items.Add("File Logs:" + fileLog.LogFileName);
            }


            foreach (TraceInfo trace in mysession.SelectedTraces)
            {
                this.loadData.Items.Add("Traces:" + trace.Name);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            //using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            //{
            //    if (fbd.ShowDialog() == DialogResult.OK)
            //    {

            //        //foreach (string item in Directory.GetFiles(fbd.SelectedPath))
            //        {
            //        }
            // }
            // }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            NewSessionFormUi window2 = new NewSessionFormUi();
            this.Hide();

            window2.ShowDialog();
            this.Close();
        }
    }
}
