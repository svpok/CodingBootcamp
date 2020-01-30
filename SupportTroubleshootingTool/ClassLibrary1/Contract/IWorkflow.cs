using System;
using System.Collections.Generic;
using System.Text;
using SupportTroubleshootingTool.Core.Model;

namespace SupportTroubleshootingTool.Core.Contract
{
    public interface IWorkflow
    {
        List<WorkflowInfo> WorkflowsList { get; }
    }
}
