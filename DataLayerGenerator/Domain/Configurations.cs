using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConfigurations.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Configurations 
    {
        public long Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public long? Version { get; set; }
        public int? State { get; set; }
        public string XMLData { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}      
