using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblFeederInterlocksCurrent.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class FeederInterlocksCurrent 
    {
        public long Index { get; set; }
        public long MatIndex { get; set; }
        public int Area { get; set; }
        public int Vessel { get; set; }
        public int StationID { get; set; }
        public int? Status { get; set; }
        public int? GroupLineNo { get; set; }
        public int? InstructionNo { get; set; }
    }
}      
