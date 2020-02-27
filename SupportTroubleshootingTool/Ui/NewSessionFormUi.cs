
﻿using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
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
        private bool flag;
        public NewSessionFormUi(SessionProvider sessionProvider)
        {
            InitializeComponent();
            _sessionProvider = sessionProvider;
            _workflowProvider = new WorkflowProvider();
        }
        private void NewSessionFormUi_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                    (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            flag = true;
            this.Size = new Size(820, 700);
            this.butStart.Enabled = false;
            this.butAll.Enabled = false;
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
            ListFiles.Items.Clear();
            ListTraces.Items.Clear();
            butStart.Enabled = IsNotEmptyWorkflow(selectedWorkflow);
            butAll.Enabled= IsNotEmptyWorkflow(selectedWorkflow);
            for (int i = 0; i < selectedWorkflow.EVLogs.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.EVLogs[i].Description;
                ListEv.Items.Add(bindingSource2.DataSource);
            }
            for (int i = 0; i < selectedWorkflow.FileLogs.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.FileLogs[i].Description;
                ListFiles.Items.Add(bindingSource2.DataSource);
            }
            for (int i = 0; i < selectedWorkflow.Traces.Count; i++)
            {
                bindingSource2.DataSource = selectedWorkflow.Traces[i].Description;
                ListTraces.Items.Add(bindingSource2.DataSource);
            }
        }
        private bool IsNotEmptyWorkflow(WorkflowInfo selectedWorkflow)
        {
            return selectedWorkflow.EVLogs.Any() ||
                selectedWorkflow.FileLogs.Any() ||
                selectedWorkflow.Traces.Any();
        }
        private void comboboxWorkflows_SelectedValueChanged(object sender, EventArgs e)
        {
            LogsWorkflows(comboboxWorkflows.SelectedIndex);
        }
        private void butStart_Click(object sender, EventArgs e)
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
                MessageBox.Show(this,
                   "At least one log or traces should be selected.",
                   "Start Session Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    _sessionProvider.StartSession(currentsession);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ExistingSessionFormUi window1 = new ExistingSessionFormUi(_sessionProvider, this);
                this.Hide();
                window1.ShowDialog();
                this.Close();
            }
            this.butAll.Enabled = true;
        }
        private void butAll_Click(object sender, EventArgs e)
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

