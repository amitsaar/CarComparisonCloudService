using CarComparisonWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace CarComparisonWebAPI.Diagnostics
{
    public class DefaultTracer : ITracer
    {
        public void WriteTrace(TraceLevel level, string TagID, string message)
        {
            switch (level)
            {
                case TraceLevel.Off:
                    break;
                case TraceLevel.Error:
                    Trace.TraceError(TagID + ":" + message);
                    break;
                case TraceLevel.Warning:
                    Trace.TraceWarning(TagID + ":" + message);
                    break;
                case TraceLevel.Info:
                    Trace.TraceInformation(TagID + ":" + message);
                    break;
                case TraceLevel.Verbose:
                    Trace.TraceInformation(TagID + ":" + message);
                    break;
                default:
                    break;
            }
        }
    }
}