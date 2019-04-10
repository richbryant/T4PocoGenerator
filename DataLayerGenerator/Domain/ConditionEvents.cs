using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConditionEvents.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ConditionEvents 
    {
        public long Index { get; set; }
        public short? State { get; set; }
        public int? ConditionID { get; set; }
        public DateTime? Date { get; set; }
        public long? ParentEvent { get; set; }
        public long? LastEvent { get; set; }
        public int? MimicID { get; set; }
    }
}      
