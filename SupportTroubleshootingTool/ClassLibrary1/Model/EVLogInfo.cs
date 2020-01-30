using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class EVLogInfo : BaseLogInfo
    {
        public EVLogInfo() : base()
        {
            Sources = new List<string>();
        }

        public string LogName { get; set; }
        [XmlArrayItem]
        public List<string> Sources { get; set; }
    }
}
