using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Config 
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public long? Max { get; set; }
        public long? Min { get; set; }
        public string Default { get; set; }
        public string Format { get; set; }
        public string Units { get; set; }
        public int? Allocation { get; set; }
    }
}      
