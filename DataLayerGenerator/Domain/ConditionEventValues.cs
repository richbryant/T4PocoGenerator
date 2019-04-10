using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConditionEventValues.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ConditionEventValues 
    {
        public long Index { get; set; }
        public long? ConditionEventID { get; set; }
        public long? OPCTagID { get; set; }
        public int? IOID { get; set; }
        public string Value { get; set; }
        public DateTime? Date { get; set; }
        public int? ConditionID { get; set; }
    }
}      
