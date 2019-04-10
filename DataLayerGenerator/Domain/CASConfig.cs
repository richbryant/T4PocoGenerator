using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCASConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CASConfig 
    {
        public short Index { get; set; }
        public string ServiceAddress { get; set; }
        public DateTime? DateLastChanged { get; set; }
        public string CASMonitorAddress { get; set; }
        public string Theme { get; set; }
        public DateTime? MonitoringLastChanged { get; set; }
        public int? MaxReportingRows { get; set; }
        public int? TankfarmLayoutRows { get; set; }
        public bool? CASServiceEnabled { get; set; }
        public string Siren { get; set; }
        public string SirenActivated { get; set; }
        public string WatchDog { get; set; }
        public int? AdminArea { get; set; }
        public long? FeaturesEnabled { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int MaxDays { get; set; }
        public bool OPCCopy { get; set; }
    }
}      
