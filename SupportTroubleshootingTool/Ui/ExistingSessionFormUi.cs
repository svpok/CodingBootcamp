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

namespace SupportTroubleshootingTool.UI
{
    public partial class ExistingSessionFormUi : Form
    {
        private SessionProvider _sessionProvider;
        private SessionInfo _currentSession;
        private NewSessionFormUi _backForm;
        public ExistingSessionFormUi(SessionProvider sessionProvider, NewSessionFormUi backForm)
         { //TODO: Check sessionProvider and _currentSession are not null.
            //If null log error and show error dialog
            _sessionProvider = sessionProvider;
            _currentSession = _sessionProvider.CurrentSession;
            _backForm = backForm;
            InitializeComponent();
           butBack.Visible = _backForm != null;
        }
          private void ExistingSessionFormUi_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 720);
            this.loadData.Items.Add("workflow:" + _currentSession.WorkflowName);

            this.loadData.Items.Add("Event View Logs:");
            foreach (EVLogInfo EVlog in _currentSession.SelectedEVLogs)
            {
                this.loadData.Items.Add(EVlog.LogName);
            }
            
            this.loadData.Items.Add("File Logs:");
            foreach (FileLogInfo fileLog in _currentSession.SelectedFileLogs)
            {
                this.loadData.Items.Add(fileLog.LogFileName);
            }

            loadData.Items.Add("Traces:");
            foreach (TraceInfo trace in _currentSession.SelectedTraces)
            {
                this.loadData.Items.Add(trace.Description);
            }
            loadData.Items.Add($"loglevel:{_currentSession.LogLevel}");
            this.Size = new Size(680, 500);
            dateTimeFrom.Value = _sessionProvider.CurrentSession.From;
            dateTimeTo.Value = _sessionProvider.CurrentSession.To;
        }
        private void butCollectAndClose_Click(object sender, EventArgs e)
        {
            _sessionProvider.CurrentSession.From = dateTimeFrom.Value;
            _sessionProvider.CurrentSession.To = dateTimeTo.Value;
            bool s = _sessionProvider.CollectData();
            _sessionProvider.StopSession();
            if (s)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("The date and time is exist for this session,can't collect data,the session well close.");

            }
            
            if (dateTimeTo.Value < dateTimeFrom.Value)
            {
                 MessageBox.Show("It cannot be 'DateTo' a less from 'DateFrom'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            else
            {
                this.Close();
            }
           }
          private void butCollectWithoutClosingSession_Click(object sender, EventArgs e)
        {
            _sessionProvider.CurrentSession.From = dateTimeFrom.Value;
            _sessionProvider.CurrentSession.To = dateTimeTo.Value;
            _sessionProvider.CollectData();

        }
        //private void butBack_Click_1(object sender, EventArgs e)
        //{
        //    _backForm.Show();
        //    // this.Hide();
       //}
         private void butOpenSeesion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_currentSession.SessionOtputFolderPath);
        }

    }
}
