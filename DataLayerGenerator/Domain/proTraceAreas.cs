using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblproTraceAreas.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class proTraceAreas 
    {
        public long? ConfigID { get; set; }
        public long Index { get; set; }
        public int AreaNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? State { get; set; }
        public int? Allocation { get; set; }
        public string XMLData { get; set; }
        public string Comment { get; set; }
        public string Version { get; set; }
        public long? BuildNumber { get; set; }
    }
}      
