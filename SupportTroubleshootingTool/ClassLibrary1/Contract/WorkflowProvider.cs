using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportTroubleshootingTool.Core.Utilities;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class WorkflowProvider : IWorkflow
    {
        public const string WorkflowsRootFolder = @".\Configurations\Workflows";
        public WorkflowProvider()
        {
            try
            {
                if (!Directory.Exists(WorkflowsRootFolder))
                {
                    Directory.CreateDirectory(WorkflowsRootFolder);
                }

                //Read workflows configurations and init Workflowslist
                CreateWorkflow(1);
                //Read workflows configurations and init Workflowslist
                this.WorkflowsList = new List<WorkflowInfo>();
                WorkflowInfo workflowInfo = new WorkflowInfo();
                for (int i = 1; i <= 3; i++) {
                    workflowInfo = SerialtionHelper<WorkflowInfo>.Deserialize(WorkflowsRootFolder + "\\w"+i+".xml");
                    WorkflowsList.Add(workflowInfo);
                }
                //SerialtionHelper<WorkflowProvider>.Serialize(this, WorkflowsRootFolder + "\\newtest.xml");
            }
            catch (Exception ex)
            {
                //Log
                Logger.WriteError(ex);
            }
        }

        private void LoadWorkflows()
        {
            this.WorkflowsList = new List<WorkflowInfo>();
        }

        private void CreateWorkflow(int wfId)
        {
            var w1 = new WorkflowInfo();
            w1.Name = $"workflow{wfId}";
            w1.ConfigFile = $"workflow{wfId}.xml";
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
