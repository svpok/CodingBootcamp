using System;
using System.Runtime.Serialization;

namespace SupportTroubleshootingTool.Core.Utilities
{
    [Serializable]
    internal class NonCriticalException : Exception
    {
        public NonCriticalException()
        {
        }

        public NonCriticalException(string message) : base(message)
        {
        }

        public NonCriticalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NonCriticalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}