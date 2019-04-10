using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPTrends.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPTrends 
    {
        public long Index { get; set; }
        public long? CIPArea { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string XMLData { get; set; }
        public DateTime? DateCreated { get; set; }
        public short? State { get; set; }
        public DateTime? LastModified { get; set; }
    }
}      
