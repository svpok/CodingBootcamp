using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class WorkflowProvider : IWorkflow
    {
        const string WorkflowsRootFolder = @".\Configurations\Workflows";
        public WorkflowProvider()
        {
            try
            {
                if (!Directory.Exists(WorkflowsRootFolder))
                {
                    Directory.CreateDirectory(WorkflowsRootFolder);
                }

                CreateWorkflow();
                //Read workflows configurations and init Workflowslist
                this.WorkflowsList = new List<WorkflowInfo>();
            }
            catch (Exception ex)
            {
                //Log
            }
        }

        private void CreateWorkflow()
        {
            var w1 = new WorkflowInfo();
            w1.Name = "Workflow 1";
            w1.ConfigFile = "workflow1.xml";
            var evlog1 = new EVLogInfo()
            {
                Description = "EV1 Description ",
                ConfigFilePath = "",
            };
            w1.EVLogs.Add(evlog1);

        }

        public List<WorkflowInfo> WorkflowsList
        {
            get;
            private set;
        }
    }
}
