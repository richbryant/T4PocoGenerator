using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblArchiveDBs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ArchiveDBs 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Version { get; set; }
        public int? State { get; set; }
    }
}      
