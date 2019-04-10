using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblSections.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Sections 
    {
        public int BitKey { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }
        public int? Allocation { get; set; }
        public int? Order { get; set; }
    }
}      
