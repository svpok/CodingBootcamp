<<<<<<< HEAD
﻿using System;
=======
﻿using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using System;
>>>>>>> cbcf3efec043346fe2ff0200f8268b90ffd9232d
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
    public partial class NewSessionFormUi : Form
    {
        
        private WorkflowProvider _workflowProvider { get; set; }
        private SessionProvider _sessionProvider;
        private bool flag;

        public NewSessionFormUi(SessionProvider sessionProvider)
        {
            InitializeComponent();
            _sessionProvider = sessionProvider;
            _workflowProvider = new WorkflowProvider();
        }
        private void NewSessionFormUi_Load(object sender, EventArgs e)
        {

            flag = true;
            this.Size = new Size(1250, 720);


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
                bindingSource2.DataSource = selectedWorkflow.EVLogs[i].Description;
                ListEv.Items.Add(bindingSource2.DataSource);
            }
            ListFiles.Items.Clear();
            for (int i = 0; i < selectedWorkflow.FileLogs.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.FileLogs[i].Description;
                ListFiles.Items.Add(bindingSource2.DataSource);
            }
            ListTraces.Items.Clear();
            for (int i = 0; i < selectedWorkflow.Traces.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.Traces[i].Description;
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

            if (butInformation.Checked)
            {
                currentsession.LogLevel = LogLevelEnum.Information;
            }
            if (butWarning.Checked)
            {
                currentsession.LogLevel = LogLevelEnum.Warning;
            }
            if (butError.Checked)
            {
                currentsession.LogLevel = LogLevelEnum.Error;
            }
            if (currentsession.SelectedEVLogs.Count == 0 && currentsession.SelectedFileLogs.Count == 0 && currentsession.SelectedTraces.Count == 0)
            {
                string message = "you can't show";
                MessageBox.Show(message);
            }
            else
            {
                _sessionProvider.StartSession(currentsession);
                ExistingSessionFormUi window1 = new ExistingSessionFormUi(_sessionProvider, this);
                this.Hide();
                window1.ShowDialog();
                this.Close();
            }

        }
        private void butAll_Click_1(object sender, EventArgs e)
        {
            selectd(ListEv);
            selectd(ListFiles);
            selectd(ListTraces);
            if (flag)
            {
                butAll.Text = "Unselect all";
                flag = false;
            }
            else
            {
                butAll.Text = "Select all";
                flag = true;
            }
        }
        private void selectd(CheckedListBox checkedList)
        {
            for (int i = 0; i < checkedList.Items.Count; i++)
            {
                checkedList.SetItemChecked(i, flag);
            }
        }
    }
    }

