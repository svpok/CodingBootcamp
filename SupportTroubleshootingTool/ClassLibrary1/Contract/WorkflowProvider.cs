using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Contract
{
    public class WorkflowProvider : IWorkflow
    {
        public List<Workflowinfo> Workflowslist
        {
            get { return new List<Workflowinfo>();  }
        }
    }
}
