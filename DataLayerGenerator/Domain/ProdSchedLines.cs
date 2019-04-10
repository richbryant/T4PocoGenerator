using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProdSchedLines.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProdSchedLines 
    {
        public long Index { get; set; }
        public int Area { get; set; }
        public int StationID { get; set; }
        public int? Status { get; set; }
        public int? Batches { get; set; }
        public DateTime? JitDate { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateFinished { get; set; }
        public string Stations { get; set; }
    }
}      
