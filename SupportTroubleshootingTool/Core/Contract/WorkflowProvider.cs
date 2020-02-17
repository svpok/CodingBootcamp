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
            LoadWorkflows();
        }

        private void LoadWorkflows()
        {
            try
            {
                if (!Directory.Exists(WorkflowsRootFolder))
                {
                    Directory.CreateDirectory(WorkflowsRootFolder);
                }

                //Read workflows configurations and init Workflowslist
                this.WorkflowsList = new List<WorkflowInfo>() { new WorkflowInfo() };
                string[] s = Directory.GetFiles(WorkflowsRootFolder);

                //TODO: Find all files in WorkflowsRootFolder
                foreach (var file in s)
                {
                    var workflowInfo = SerialtionHelper<WorkflowInfo>.Deserialize(file);
                    WorkflowsList.Add(workflowInfo);
                }
                //SerialtionHelper<WorkflowProvider>.Serialize(this, WorkflowsRootFolder + "\\newtest.xml");
            }
            catch (Exception ex)
            {
                //Log
              new  Logger().WriteError(ex);
            }
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
