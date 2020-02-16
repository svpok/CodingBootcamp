using SupportTroubleshootingTool.Core.Contract;
using SupportTroubleshootingTool.Core.Model;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

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





        private void butStart_Click_1(object sender, EventArgs e)
        {
            ExistingSessionFormUi window1 = new ExistingSessionFormUi();
            this.Hide();

            window1.ShowDialog();
            this.Close();

        }

        private void comboboxWorkflows_SelectedValueChanged(object sender, EventArgs e)
        {
            //string namestr = " ";
           // comboboxWorkflows.Items.Add(null);
            LogsWorkflows(comboboxWorkflows.SelectedIndex);
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
            SessionInfo currentsession = new SessionInfo();
            WorkflowInfo current = WorkflowProvider.WorkflowsList[comboboxWorkflows.SelectedIndex];
            currentsession.From = dateTimeFrom.Value.ToUniversalTime();
            currentsession.To = dateTimeTo.Value.ToUniversalTime();
            currentsession.WorkflowName = current.Name;
            for (int i = 0; i < current.EVLogs.Count; i++)
            {
                if (ListEv.GetItemChecked(i) == true)
                {

                    currentsession.SelectedEVLogs.Add(current.EVLogs[i]);
                   // MessageBox.Show("current.EVLogs[i].ToString()");
                }
            
            }


            for (int i = 0; i < current.FileLogs.Count; i++)
            {
                if (ListFiles.GetItemChecked(i) == true)
                {

                    currentsession.SelectedFileLogs.Add(current.FileLogs[i]);
                    //MessageBox.Show("current.FileLogs[i].ToString()");
                }

            }

            for (int i = 0; i < current.Traces.Count; i++)
            {
                if (ListTraces.GetItemChecked(i) == true)
                {

                    currentsession.SelectedTraces.Add(current.Traces[i]);
                   // MessageBox.Show("current.Traces[i].ToString()");
                }

            }
            new SessionProvider().StartSession(currentsession);
            ExistingSessionFormUi.SetMySession(currentsession);
            ExistingSessionFormUi window1 = new ExistingSessionFormUi();
            this.Hide();

            window1.ShowDialog();
            this.Close();
        }

        private void butReset_Click_1(object sender, EventArgs e)
        {
            //comboboxWorkflows.Items.Clear();

            comboboxWorkflows.SelectedIndex = 0;
            dateTimeFrom.Value = DateTime.Now;
            dateTimeTo.Value = DateTime.Now;
            butCurrent.Checked = true;
        
        }

        
    }
    
}
