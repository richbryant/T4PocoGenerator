using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblBatchHeader.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class BatchHeader 
    {
        public long Index { get; set; }
        public long? ProdIndex { get; set; }
        public int? Area { get; set; }
        public int? StationID { get; set; }
        public string Areas { get; set; }
        public string ProdCode { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeDescription { get; set; }
        public decimal? BatchSize { get; set; }
        public int? TargetBatches { get; set; }
        public int? ActualBatches { get; set; }
        public int? Status { get; set; }
        public int? Mode { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateFinished { get; set; }
        public string OperatorSched { get; set; }
        public string OperatorProd { get; set; }
        public int? CIP { get; set; }
    }
}      
