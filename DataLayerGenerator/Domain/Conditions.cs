using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConditions.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Conditions 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public short State { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? MimicID { get; set; }
        public DateTime? LastActive { get; set; }
        public long? LastEvent { get; set; }
        public int? DelayPeriod { get; set; }
        public int? NotifySuppress { get; set; }
        public int? LeadingTime { get; set; }
        public int? TrailingTime { get; set; }
    }
}      
