using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblTrends.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Trends 
    {
        public short Index { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string XMLData { get; set; }
        public DateTime? DateCreated { get; set; }
        public short? State { get; set; }
        public DateTime? LastModified { get; set; }
        public int? MimicID { get; set; }
    }
}      
