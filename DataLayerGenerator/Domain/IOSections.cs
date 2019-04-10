using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblIOSections.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class IOSections 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int? RangeStart { get; set; }
        public int? RangeEnd { get; set; }
        public string Comment { get; set; }
        public short? State { get; set; }
    }
}      
