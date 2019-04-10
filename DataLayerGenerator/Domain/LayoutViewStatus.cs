using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblLayoutViewStatus.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class LayoutViewStatus 
    {
        public int LayoutViewID { get; set; }
        public short State { get; set; }
        public long IOVersion { get; set; }
        public long ConditionsVersion { get; set; }
        public DateTime? LastChecked { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime? FirstRecordedDate { get; set; }
    }
}      
