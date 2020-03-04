using System;
using System.IO;
using System.Windows.Forms;
using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;

namespace SupportTroubleshootingTool.UI
{
    public partial class ExistingSessionFormUi : Form
    {
        private SessionProvider _sessionProvider;
        private SessionInfo _currentSession;
        public ExistingSessionFormUi(SessionProvider sessionProvider, NewSessionFormUi backForm)
        { //TODO: Check sessionProvider and _currentSession are not null.
            //If null log error and show error dialog
            _sessionProvider = sessionProvider;
            _currentSession = _sessionProvider.CurrentSession;

            InitializeComponent();
           
        }    
        private void ExistingSessionFormUi_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + _currentSession.SessionID; 
            
            dateTimeFrom.Value = _currentSession.From;
            dateTimeTo.Value = _currentSession.To;
            dateTimeTo.MaxDate = DateTime.Now;

            InitSessionInfoDetails();
        }
        private void InitSessionInfoDetails()
        {
            this.loadData.Items.Clear();
            this.loadData.Items.Add("Workflow:  " + _currentSession.WorkflowName);
            loadData.Items.Add($"Log Level:  {_currentSession.LogLevel}");

            if (_currentSession.SelectedEVLogs.Count > 0)
            {
                this.loadData.Items.Add("");
                loadData.Items.Add("Event View Logs:");
                foreach (EVLogInfo EVlog in _currentSession.SelectedEVLogs)
                {
                    loadData.Items.Add(EVlog.Description);
                }
            }

            if (_currentSession.SelectedFileLogs.Count > 0)
            {
                this.loadData.Items.Add("");
                loadData.Items.Add("File Logs:");
                foreach (FileLogInfo fileLog in _currentSession.SelectedFileLogs)
                {
                    loadData.Items.Add(fileLog.Description);
                }
            }

            if (_currentSession.SelectedTraces.Count > 0)
            {
                this.loadData.Items.Add("");
                loadData.Items.Add("Traces:");
                foreach (TraceInfo trace in _currentSession.SelectedTraces)
                {
                    loadData.Items.Add(trace.Description);
                }
            }

            if (_currentSession.OutputDirNames.Count > 0)
            {
                this.loadData.Items.Add("");
                loadData.Items.Add("Collected Data For Time Filters:");
                foreach (string dirName in _currentSession.OutputDirNames)
                {
                    this.loadData.Items.Add(dirName);
                }
            }
        }
        private void butCollectDataClick(object sender, EventArgs e)
        {
            try
            {
                _currentSession.From = dateTimeFrom.Value;
                _currentSession.To = dateTimeTo.Value;
                string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
                string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
                string path = Path.Combine(_currentSession.SessionOtputFolderPath,
                            "OutputData",
                            $@"{from}_{to}");
                if (Directory.Exists(path))
                {
                    DialogResult dialogResult = MessageBox.Show("Data for the same data and time already was collect ! ," +
                   "Do you want to override it?," +
                   "\nClick Ok,to override." +
                   "\nClick cancel,to change date and time.", "Collect data", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        _sessionProvider.CollectData(true);
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else
                {
                    _sessionProvider.CollectData();
                    InitSessionInfoDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
         private void butOpenSeesion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_currentSession.SessionOtputFolderPath);
        }
        private void butCloseSessionClick(object sender, EventArgs e)
        {
            try
            {
                _sessionProvider.CurrentSession.From = dateTimeFrom.Value;
                _sessionProvider.CurrentSession.To = dateTimeTo.Value;
                _sessionProvider.StopSession();
                this.Close();
            }
            catch(Exception ex)
            {
                new Logger().WriteError(ex);
                MessageBox.Show("Failed to close Session" + ex.Message);
            }
        }
        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimeTo.MinDate = dateTimeFrom.Value.AddHours(1);
        }
        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFrom.MaxDate = dateTimeTo.Value.AddHours(-1);
        }  
    }    
 }
 

