using System.Diagnostics;

namespace CarComparisonWebAPI.Diagnostics
{
    public interface ITracer
    {
        void WriteTrace(TraceLevel level, string TagID, string message);
    
    }
}