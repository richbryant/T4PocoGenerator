using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblEventSignificant.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class EventSignificant 
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Allocation { get; set; }
        public int? Value { get; set; }
    }
}      
