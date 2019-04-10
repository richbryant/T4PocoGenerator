using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblBatchInstructions.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class BatchInstructions 
    {
        public long Index { get; set; }
        public int StationID { get; set; }
        public int Vessel { get; set; }
        public int BatchNo { get; set; }
        public decimal LineNo { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Instruction { get; set; }
        public string Parameter { get; set; }
        public string MatDesc { get; set; }
        public decimal? TargetWeight { get; set; }
        public decimal? ActualWeight { get; set; }
        public decimal? PosTol { get; set; }
        public decimal? NegTol { get; set; }
        public string UserData { get; set; }
        public string Operator { get; set; }
        public string AcceptedBy { get; set; }
        public int? Grouped { get; set; }
        public int? Addition { get; set; }
        public int? Append { get; set; }
        public decimal? SG { get; set; }
        public int? Void { get; set; }
        public int? Scale { get; set; }
        public decimal? BatchFactor { get; set; }
        public long? VehicleIndex { get; set; }
        public long? SubContainer { get; set; }
        public long? PreweighIndex { get; set; }
        public int? Status { get; set; }
        public int UOM { get; set; }
        public string HUCode { get; set; }
        public int? QA { get; set; }
    }
}      
