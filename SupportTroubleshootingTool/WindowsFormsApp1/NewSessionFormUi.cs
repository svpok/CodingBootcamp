using SupportTroubleshootingTool.Core.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewSessionFormUi : Form
    {
        private WorkflowProvider WorkflowProvider { get; set; }
        public NewSessionFormUi()
        {
            InitializeComponent();
            WorkflowProvider = new WorkflowProvider();
        }

        private void butStart_Click(object sender, EventArgs e)
        {

            // ExistingSessionFormUi window1=new ExistingSessionFormUi();
            // this.Hide();

            //window1.ShowDialog();
            //this.Close();


        }

        private void NewSessionFormUi_Load(object sender, EventArgs e)
        {
           
            this.Size = new Size(680, 500);
          

            FillWorkflows();

        }
        public void FillWorkflows()
        {
            var bindingSource1 = new BindingSource();
           
            bindingSource1.DataSource = WorkflowProvider.WorkflowsList;
            comboboxWorkflows.DataSource = bindingSource1.DataSource;
            comboboxWorkflows.Items.Add(0);
            comboboxWorkflows.DisplayMember = "Name";
            //comboboxWorkflows. = "Name";

        }
        public void LogsWorkflows(int idex)
        {
            var bindingSource2 = new BindingSource();
            /*
            ListEv.Items.Clear();
            bindingSource2.DataSource = WorkflowProvider.WorkflowsList[idex].EVLogs[0].LogName;
            ListEv.Items.Add(bindingSource2.DataSource);
            */

            ListEv.Items.Clear();
            for (int i = 0; i < WorkflowProvider.WorkflowsList[idex].EVLogs.Count; i++)
            {
                bindingSource2.DataSource = WorkflowProvider.WorkflowsList[idex].EVLogs[i].LogName;
                ListEv.Items.Add(bindingSource2.DataSource);
            }

            /*
            ListFiles.Items.Clear();
            bindingSource2.DataSource = WorkflowProvider.WorkflowsList[idex].FileLogs[0].LogFileName;
            ListFiles.Items.Add(bindingSource2.DataSource);
            */
            ListFiles.Items.Clear();
            for (int i = 0; i < WorkflowProvider.WorkflowsList[idex].FileLogs.Count; i++)
            {
                bindingSource2.DataSource = WorkflowProvider.WorkflowsList[idex].FileLogs[i].LogFileName;
                ListFiles.Items.Add(bindingSource2.DataSource);
            }

            ListTraces.Items.Clear();
            for (int i = 0; i < WorkflowProvider.WorkflowsList[idex].Traces.Count; i++)
            {
                bindingSource2.DataSource = WorkflowProvider.WorkflowsList[idex].Traces[i].Name;
                ListTraces.Items.Add(bindingSource2.DataSource);
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butCurrent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butInformation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butWarning_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butError_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butReset_Click(object sender, EventArgs e)
        {

        }

        private void butStart_Click_1(object sender, EventArgs e)
        {
            ExistingSessionFormUi window1 = new ExistingSessionFormUi();
            this.Hide();

            window1.ShowDialog();
            this.Close();

        }

        private void comboboxWorkflows_SelectedValueChanged(object sender, EventArgs e)
        {
            LogsWorkflows(comboboxWorkflows.SelectedIndex);
        }

        private void comboboxWorkflows_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogsWorkflows(0);
        }

        private void ListTraces_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogsWorkflows(0);
        }

        private void BoxLogs_Enter(object sender, EventArgs e)
        {

        }

        private void butStart_Click_2(object sender, EventArgs e)
        {
            ExistingSessionFormUi window1 = new ExistingSessionFormUi();
            this.Hide();

            window1.ShowDialog();
            this.Close();
        }
    }
}
