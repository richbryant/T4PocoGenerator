using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblApplications.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Applications 
    {
        public long? ConfigID { get; set; }
        public long Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public short? State { get; set; }
        public string Version { get; set; }
        public long? BuildNumber { get; set; }
        public bool? Licensed { get; set; }
        public string XMLData { get; set; }
        public string Folder { get; set; }
        public int? ApplicationNumber { get; set; }
    }
}      
