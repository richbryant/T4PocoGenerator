using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMonitoredAlerts.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MonitoredAlerts 
    {
        public long Index { get; set; }
        public long ActivityIndex { get; set; }
        public long? Recipient { get; set; }
        public int? Type { get; set; }
        public int? ConfigUsed { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? Date { get; set; }
        public short? State { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Result { get; set; }
        public long? MonitoredAlarmID { get; set; }
    }
}      
