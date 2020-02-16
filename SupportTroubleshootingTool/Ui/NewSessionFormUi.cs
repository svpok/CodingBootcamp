using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportTroubleshootingTool.UI
{
    public partial class NewSessionFormUi : Form
    {
        private WorkflowProvider _workflowProvider { get; set; }
        private SessionProvider _sessionProvider;

        public NewSessionFormUi(SessionProvider sessionProvider)
        {
            InitializeComponent();
            _sessionProvider = sessionProvider;
            _workflowProvider = new WorkflowProvider();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            var newSessionInfo = new SessionInfo();
            //TODO: fill newSessionInfo with the selected items
            _sessionProvider.StartSession(newSessionInfo);
        }

        private void NewSessionFormUi_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1050, 550);
            FillWorkflows();
        }
        public void FillWorkflows()
        {
            var bindingSource1 = new BindingSource();
            
            bindingSource1.DataSource = _workflowProvider.WorkflowsList;
            comboboxWorkflows.DataSource = bindingSource1.DataSource;
            comboboxWorkflows.DisplayMember = "Name";
        }
        public void LogsWorkflows(int index)
        {
            var bindingSource2 = new BindingSource();
            var selectedWorkflow = _workflowProvider.WorkflowsList[index];

            ListEv.Items.Clear();
            for (int i = 0; i < selectedWorkflow.EVLogs.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.EVLogs[i].LogName;
                ListEv.Items.Add(bindingSource2.DataSource);
            }
            ListFiles.Items.Clear();
            for (int i = 0; i < selectedWorkflow.FileLogs.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.FileLogs[i].LogFileName;
                ListFiles.Items.Add(bindingSource2.DataSource);
            }
            ListTraces.Items.Clear();
            for (int i = 0; i < selectedWorkflow.Traces.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.Traces[i].Name;
                ListTraces.Items.Add(bindingSource2.DataSource);
            }
        }
           
        private void comboboxWorkflows_SelectedValueChanged(object sender, EventArgs e)
        {
            LogsWorkflows(comboboxWorkflows.SelectedIndex);
        }

        private void butStart_Click_2(object sender, EventArgs e)
        {
            SessionInfo currentsession = new SessionInfo();
            WorkflowInfo current = _workflowProvider.WorkflowsList[comboboxWorkflows.SelectedIndex];
            currentsession.WorkflowName = current.Name;
            for (int i = 0; i < current.EVLogs.Count; i++)
            {
                if (ListEv.GetItemChecked(i) == true)
                {
                    currentsession.SelectedEVLogs.Add(current.EVLogs[i]);
                }
            }
            for (int i = 0; i < current.FileLogs.Count; i++)
            {
                if (ListFiles.GetItemChecked(i) == true)
                {
                    currentsession.SelectedFileLogs.Add(current.FileLogs[i]);
                }
            }
            for (int i = 0; i < current.Traces.Count; i++)
            {
                if (ListTraces.GetItemChecked(i) == true)
                {
                    currentsession.SelectedTraces.Add(current.Traces[i]);
                }
            }
            _sessionProvider.StartSession(currentsession);
            ExistingSessionFormUi window1 = new ExistingSessionFormUi(_sessionProvider, this);
            this.Hide();

            window1.ShowDialog();
            this.Close();
        }
        private void butReset_Click_1(object sender, EventArgs e)
        {
            comboboxWorkflows.SelectedIndex = 0;
            butCurrent.Checked = true;
        }

       
    }
    
}
