using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblOPCAlarms.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class OPCAlarms 
    {
        public long Index { get; set; }
        public int? OPCServer { get; set; }
        public int? PLC { get; set; }
        public int? Area { get; set; }
        public string Address { get; set; }
        public long? ScanRate { get; set; }
        public string Description { get; set; }
        public string TagName { get; set; }
        public int? State { get; set; }
        public DateTime? LastActive { get; set; }
        public int? ErrorCategory { get; set; }
    }
}      
