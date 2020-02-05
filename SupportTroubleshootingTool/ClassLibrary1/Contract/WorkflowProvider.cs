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

                CreateWorkflow(1);
                CreateWorkflow(2);
                CreateWorkflow(3);
                LoadWorkflows();
                //Read workflows configurations and init Workflowslist
               
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
            Save(w1);
        }

        public List<WorkflowInfo> WorkflowsList
        {
            get;
            private set;
        }
        public void Save(WorkflowInfo data)
        {
            WorkflowProvider workflowProvider = new WorkflowProvider();
            XmlSerializer writer = new XmlSerializer(typeof(WorkflowInfo));
            TextWriter s = new StreamWriter($"{WorkflowsRootFolder}\\" + "\\WorkFlowInfo.xml");

            //FileStream file = File.Create(path);
            writer.Serialize(s, data);
            s.Close();
        }
        public WorkflowInfo Load(string xmlPath)
        {
            WorkflowProvider workflowProvider = new WorkflowProvider();
            WorkflowInfo workflowInfo = null;
            string path = xmlPath;

            XmlSerializer serializer = new XmlSerializer(typeof(WorkflowInfo));

            StreamReader reader = new StreamReader(path);
            workflowInfo = (WorkflowInfo)serializer.Deserialize(reader);
            reader.Close();
            return workflowInfo;
        }
    }
}
