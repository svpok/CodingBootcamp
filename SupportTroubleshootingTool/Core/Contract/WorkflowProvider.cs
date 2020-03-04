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
            new Utilities.Logger().WriteInfo("Successfully Deserialized WorkFlows");
        }
        private void LoadWorkflows()
        {
            try
            {
                if (!Directory.Exists(WorkflowsRootFolder))
                {
                    Directory.CreateDirectory(WorkflowsRootFolder);
                }
                this.WorkflowsList = new List<WorkflowInfo>() { new WorkflowInfo() };
                string[] Dir = Directory.GetFiles(WorkflowsRootFolder);
                foreach (var file in Dir)
                {
                    var workflowInfo = SerialtionHelper<WorkflowInfo>.Deserialize(file);
                    WorkflowsList.Add(workflowInfo);
                }
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"Faild to load WorkFlows{ex.Message}");
                throw new Exception($"Faild to load WorkFlows{ex.Message}");
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
