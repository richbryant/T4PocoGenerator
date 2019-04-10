using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblOPCTags.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class OPCTags 
    {
        public long Index { get; set; }
        public int? OPCServer { get; set; }
        public int? PLC { get; set; }
        public string Address { get; set; }
        public long? ScanRate { get; set; }
        public string Description { get; set; }
        public string TagName { get; set; }
        public short? State { get; set; }
        public DateTime? LastActive { get; set; }
        public int? ErrorCategory { get; set; }
        public string DataType { get; set; }
        public int? Used { get; set; }
        public short Units { get; set; }
        public double Variance { get; set; }
        public short VarianceType { get; set; }
        public long UniqueID { get; set; }
        public long? CIPArea { get; set; }
    }
}      
