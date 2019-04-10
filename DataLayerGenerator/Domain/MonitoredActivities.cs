using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMonitoredActivities.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MonitoredActivities 
    {
        public long Index { get; set; }
        public long MonitoredAlarmID { get; set; }
        public DateTime? Date { get; set; }
        public double? Value { get; set; }
        public string AlarmCodeText { get; set; }
        public int State { get; set; }
        public int ReasonCode { get; set; }
        public string ReasonText { get; set; }
        public int? User { get; set; }
    }
}      
