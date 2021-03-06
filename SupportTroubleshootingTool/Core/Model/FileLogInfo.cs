﻿using System;
using System.Xml.Serialization;
namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class FileLogInfo : BaseLogInfo
    {
        public FileLogInfo() : base()
        {
        }
        [XmlElement]
        public string LogsPath { get; set; }
        [XmlElement]
        public string LogFileName { get; set; }
    }
}