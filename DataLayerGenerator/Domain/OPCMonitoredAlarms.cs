using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblOPCMonitoredAlarms.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class OPCMonitoredAlarms 
    {
        public long Index { get; set; }
        public long? OPCAlarmId { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? Priority { get; set; }
        public int? State { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastActive { get; set; }
        public long? Activity { get; set; }
        public double? CurrentValue { get; set; }
        public DateTime? LastChecked { get; set; }
        public long? ActivityIndex { get; set; }
        public short? LastUpdatedBy { get; set; }
        public string AlarmCodeText { get; set; }
    }
}      
