using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblAlarmLogs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class AlarmLogs 
    {
        public DateTime? DateTime { get; set; }
        public int? StationID { get; set; }
        public string Alarm { get; set; }
        public string ProdCode { get; set; }
        public int? BatchNo { get; set; }
        public int? Action { get; set; }
        public string AcceptedBy { get; set; }
    }
}      
