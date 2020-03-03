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
            this.loadData.Items.Add("workflow:  " + _currentSession.WorkflowName);
            string EVL = "";
            EVL = "Event View Logs:";
            int evilog = 1;
            foreach (EVLogInfo EVlog in _currentSession.SelectedEVLogs)
            {
                if (evilog == 1)
                {
                    EVL = EVL + " " + EVlog.LogName;
                    evilog = 0;
                }
                else
                    EVL = EVL + ", " + EVlog.LogName;
              }
               this.loadData.Items.Add(EVL);
            string fileloge = "";
            fileloge = "File Logs:";
            int log = 1;
            foreach (FileLogInfo fileLog in _currentSession.SelectedFileLogs)
            {
                if (log == 1)
                {
                    fileloge = fileloge + " " + fileLog.LogFileName;
                    log = 0;
                }
                else
                    fileloge = fileloge + ", " + fileLog.LogFileName;
            }
            this.loadData.Items.Add(fileloge);
            string trce = "";
            trce = "Traces:";
            int Trce = 1;
            foreach (TraceInfo trace in _currentSession.SelectedTraces)
            {
                if (Trce == 1)
                {
                    trce = trce + " " + trace.Description;
                    Trce = 0;
                }
                else
                    trce = trce + " ," + trace.Description;
            }
            this.loadData.Items.Add(trce);

            loadData.Items.Add($"loglevel:{_currentSession.LogLevel}");

            dateTimeFrom.Value = _sessionProvider.CurrentSession.From;
            dateTimeTo.MaxDate = DateTime.Now;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            new ToolTip().Show("data is collect", this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 1000);
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
                //_sessionProvider.CollectData();
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
 

