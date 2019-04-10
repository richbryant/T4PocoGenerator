using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblINIFileSectionEntries.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class INIFileSectionEntries 
    {
        public long Index { get; set; }
        public long SectionID { get; set; }
        public int? State { get; set; }
        public int? Type { get; set; }
        public string Key { get; set; }
        public string Comment { get; set; }
        public string Value { get; set; }
        public long? Order { get; set; }
        public long? ElementID { get; set; }
    }
}      
